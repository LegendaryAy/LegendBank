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
    public class LegendBankAccountTest
    {
        /// <summary>
        /// Test for getting accounts by id 
        /// </summary>
        [Fact]
        public void GetAccountByIdTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };

                //Act & Assert
                var actual = sut.GetAccountById(sut.CreateCurrentAccount(10000, customer.Id));
                Assert.IsType<Account>(actual);
            }
        }

        /// <summary>
        /// Test for creating savings account
        /// </summary>
        [Fact]
        public void CreateAccountTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var expected = "Savings Account";

                //Act
                var actual = sut.GetAccountById(sut.CreateAccount(10000, customer.Id)).AccountType;

                //Assert
                Assert.Equal(expected, actual);
            }
              
        }

        /// <summary>
        /// Test for creating current account
        /// </summary>
        [Fact]
        public void CreateCurrentAccountTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var expected = "Current Account";

                //Act
                var actual = sut.GetAccountById(sut.CreateCurrentAccount(10000, customer.Id)).AccountType;

                //Assert
                Assert.Equal(expected, actual);
            }
        }

        /// <summary>
        /// Test for getting account list
        /// </summary>
        [Fact]
        public void GetAccountListTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var account1 = sut.CreateAccount(1000, customer.Id);
                var account2 = sut.CreateCurrentAccount(1000, customer.Id);

                //Act
                var actual = sut.GetAccountList(customer.Id);

                //Assert
                Assert.IsType<List<Account>>(actual);
            }

        }

        /// <summary>
        /// Test for getting transactions list
        /// </summary>
        [Fact]
        public void GetTransactionsByIdTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new AccountRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };

                //Act & Assert
                var actual = sut.GetAllTransactionsbyAccountId(sut.CreateCurrentAccount(10000, customer.Id));
                Assert.IsType<List<Transaction>>(actual);
            }            
        }
    }
}
