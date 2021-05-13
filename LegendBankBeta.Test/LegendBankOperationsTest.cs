using LegendBankBeta.Lib.Core.Repositories;
using LegendBankBeta.Lib.Data;
using LegendBankBeta.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LegendBankBeta.Test
{
    public class LegendBankOperationsTest
    {
        /// <summary>
        /// Test for Checking Balance
        /// </summary>
        [Fact]
        public void GetBalanceTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var account = sut.GetAccountById(sut.CreateAccount(10000, customer.Id));
                var expected = 10000;

                //Act
                var actual = sut.GetBalance(account);

                //Assert
                Assert.Equal(expected, actual);
            }
            
        }

        /// <summary>
        /// Test for Deposit
        /// </summary>
        [Fact]
        public void DepositTest()
        {   
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var account = sut.GetAccountById(sut.CreateAccount(10000, customer.Id));
                sut.Deposit(account, 20000);
                var expected = 30000;


                //Act
                var actual = sut.GetBalance(account);

                //Assert
                Assert.Equal(expected, actual);
            }
            
        }

        /// <summary>
        /// Test for Depositing negative numbers
        /// </summary>
        [Fact]
        public void DepositNegativeTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var account = sut.GetAccountById(sut.CreateAccount(10000, customer.Id));

                //Act & Assert
                Assert.Throws<InvalidOperationException>(() => sut.Deposit(account, -2000));
            }
            
        }

        /// <summary>
        /// Test for Withdraw
        /// </summary>
        [Fact]
        public void WithdrawTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var account = sut.GetAccountById(sut.CreateAccount(40000, customer.Id));
                sut.Withdraw(account, 20000);
                var expected = 20000;

                //Act
                var actual = sut.GetBalance(account);

                //Assert
                Assert.Equal(expected, actual);
            } 
        }

        /// <summary>
        /// Test for withdrawing negative numbers
        /// </summary>
        [Fact]
        public void WithdrawNegativeTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using(var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var account = sut.GetAccountById(sut.CreateAccount(10000, customer.Id));

                //Act & Assert
                Assert.Throws<InvalidOperationException>(() => sut.Withdraw(account, -2000));
            }
            
        }

        /// <summary>
        /// Test for withdrawing amount greater than balance
        /// </summary>
        [Fact]
        public void WithdrawLargerAmountTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var account = sut.GetAccountById(sut.CreateAccount(10000, customer.Id));

                //Act & Assert
                Assert.Throws<InvalidOperationException>(() => sut.Withdraw(account, 20000));
            }
        }

        /// <summary>
        /// Test for withdrawing beyond the minimum amount
        /// </summary>
        [Fact]
        public void WithdrawMoreThanMinimunAmountTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var account = sut.GetAccountById(sut.CreateAccount(10000, customer.Id));

                //Act & Assert
                Assert.Throws<InvalidOperationException>(() => sut.Withdraw(account, 9100));
            } 
        }

        /// <summary>
        /// Test for Transfer
        /// </summary>
        [Fact]
        public void TransferTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer1 = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var customer2 = new Customer { FirstName = "Legend", LastName = "Baddo" };
                var account1 = sut.GetAccountById(sut.CreateAccount(10000, customer1.Id));
                var account2 = sut.GetAccountById(sut.CreateCurrentAccount(10000, customer2.Id));
                sut.Transfer(account1, account2.AccountNumber, 5000, "Test");
                var expected1 = 5000;
                var expected2 = 15000;

                //Act
                var actual1 = sut.GetBalance(account1);
                var actual2 = sut.GetBalance(account2);

                //Assert
                Assert.Equal(expected1, actual1);
                Assert.Equal(expected2, actual2);
            }
                
        }

        /// <summary>
        /// Test for transfering negative numbers
        /// </summary>
        [Fact]
        public void TransferNegativeTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer1 = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var customer2 = new Customer { FirstName = "Legend", LastName = "Baddo" };
                var account1 = sut.GetAccountById(sut.CreateAccount(10000, customer1.Id));
                var account2 = sut.GetAccountById(sut.CreateCurrentAccount(10000, customer2.Id));

                //Act & Assert
                Assert.Throws<InvalidOperationException>(() => sut.Transfer(account1, account2.AccountNumber, -5000, "Test"));
            }
            
        }

        /// <summary>
        /// Test for withdrawing amount greater than balance
        /// </summary>
        [Fact]
        public void TransferLargerAmountTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer1 = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var customer2 = new Customer { FirstName = "Legend", LastName = "Baddo" };
                var account1 = sut.GetAccountById(sut.CreateAccount(10000, customer1.Id));
                var account2 = sut.GetAccountById(sut.CreateCurrentAccount(10000, customer2.Id));

                //Act & Assert
                Assert.Throws<InvalidOperationException>(() => sut.Transfer(account1, account2.AccountNumber, 15000, "Test"));
            }
        }

        /// <summary>
        /// Test for withdrawing beyond the minimum amount
        /// </summary>
        [Fact]
        public void TransferMoreThanMinimunAmountTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer1 = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var customer2 = new Customer { FirstName = "Legend", LastName = "Baddo" };
                var account1 = sut.GetAccountById(sut.CreateAccount(10000, customer1.Id));
                var account2 = sut.GetAccountById(sut.CreateCurrentAccount(10000, customer2.Id));

                //Act & Assert
                Assert.Throws<InvalidOperationException>(() => sut.Transfer(account1, account2.AccountNumber, 9100, "Test"));
            }
            
        }
    }
}

