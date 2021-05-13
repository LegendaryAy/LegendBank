using LegendBankBeta.Lib.Commons;
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
    public class LegendBankUserTest
    {
        /// <summary>
        /// Test for getting customer by id
        /// </summary>
        [Fact]
        public void GetCustomerByIdTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new UserRepository(context);

                //Act
                var actual = sut.GetCustomerById(sut.CreateCustomer("Ayobami", "Baddo"));

                //Assert
                Assert.IsType<Customer>(actual);
            }
            
        }

        /// <summary>
        /// Test for getting user by id
        /// </summary>
        [Fact]
        public void GetUserByIdTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new UserRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var email = "ay@yahoo.com";
                var password = Utilities.GenerateHash("hgfiyghgr");

                //Act
                var actual = sut.GetUserById(sut.CreateUser(email, password[0], password[1], customer.Id));

                //Assert
                Assert.IsType<User>(actual);
            }
        }

        /// <summary>
        /// Test for creating customer
        /// </summary>
        [Fact]
        public void CreateCustomerTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new UserRepository(context);
                
                //Act
                var actual = sut.CreateCustomer("Ayobami", "Baddo");

                //Assert
                Assert.IsType<string>(actual);
            }
            
        }

        /// <summary>
        /// Test for Creating User
        /// </summary>
        [Fact]
        public void CreateUserTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new UserRepository(context);
                var customer = new Customer { FirstName = "Ayobami", LastName = "Baddo" };
                var email = "ay@yahoo.com";
                var password = Utilities.GenerateHash("hgfiyghgr");

                //Act
                var actual = sut.CreateUser(email, password[0], password[1], customer.Id);

                //Assert
                Assert.IsType<string>(actual);
            }
        }
    }
}
