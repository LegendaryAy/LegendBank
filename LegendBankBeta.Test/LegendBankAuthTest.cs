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
    public class LegendBankAuthTest
    {
        /// <summary>
        /// Test for Registering a customer
        /// </summary>
        [Fact]
        public void RegisterTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new UserRepository(context);
                var auth = new AuthRepository(context, sut);
                var details = new string[] { "Ayobami", "Baddo", "ay@gmail.com" };
                var password = Utilities.GenerateHash("hgfiyghgr");
                
                //Act
                var actual = sut.GetCustomerById(auth.Register(details[0], details[1], details[2], password[0], password[1]));

                //Assert
                Assert.IsType<Customer>(actual);
            }
        }

        /// <summary>
        /// Test for registering a customer with an email already in the database
        /// </summary>
        [Fact]
        public void RegisterWithExistingEmail()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new UserRepository(context);
                var auth = new AuthRepository(context, sut);
                var details = new string[] { "Ayobami", "Baddo", "ayo@gmail.com", "Legend", "Boss", "legend@gmail.com" };
                var password1 = Utilities.GenerateHash("abcde");
                var password2 = Utilities.GenerateHash("12345");
                auth.Register(details[0], details[1], details[2], password1[0], password1[1]);

                //Act & Assert
                Assert.Throws<ArgumentException>(() => auth.Register(details[3], details[4], details[2], password2[0], password2[1]));
            }                
        }

        /// <summary>
        /// Login Test
        /// </summary>
        [Fact]
        public void LoginTest()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new UserRepository(context);
                var auth = new AuthRepository(context, sut);
                var details = new string[] { "Ayobami", "Baddo", "ayobami@gmail.com", "Legend", "Boss", "legends@gmail.com" };
                var password1 = Utilities.GenerateHash("abcde");
                var password2 = Utilities.GenerateHash("12345");
                auth.Register(details[0], details[1], details[2], password1[0], password1[1]);
                auth.Register(details[3], details[4], details[5], password2[0], password2[1]);

                //Act
                var login = auth.Login("ayobami@gmail.com", "abcde");

                //Assert
                Assert.True(login);
            }
            
        }

        /// <summary>
        /// Test for logging in with wrong email format
        /// </summary>
        [Fact]
        public void LoginWithWrongEmailFormat()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new UserRepository(context);
                var auth = new AuthRepository(context, sut);
                var details = new string[] { "Ayobami", "Baddo", "seyi@gmail.com", "Legend", "Boss", "legendary@gmail.com" };
                var password1 = Utilities.GenerateHash("abcde");
                var password2 = Utilities.GenerateHash("12345");
                auth.Register(details[0], details[1], details[2], password1[0], password1[1]);
                auth.Register(details[3], details[4], details[5], password2[0], password2[1]);

                //Act & Assert
                Assert.Throws<ArgumentException>(() => auth.Login("ay.com", "abcde"));
            }
        }

        [Fact]
        public void LoginWithWrongPassword()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new UserRepository(context);
                var auth = new AuthRepository(context, sut);
                var details = new string[] { "Ayobami", "Baddo", "oluwaseyi@gmail.com", "Legend", "Boss", "legendaryay@gmail.com" };
                var password1 = Utilities.GenerateHash("abcde");
                var password2 = Utilities.GenerateHash("12345");
                auth.Register(details[0], details[1], details[2], password1[0], password1[1]);
                auth.Register(details[3], details[4], details[5], password2[0], password2[1]);

                //Act & Assert
                Assert.Throws<ArgumentException>(() => auth.Login("oluwaseyi@gmail.com", "abcd"));
            }
            
        }

        /// <summary>
        /// Test for logging in with unregistered email
        /// </summary>
        [Fact]
        public void LoginWithUnregisteredEmail()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<LegendBankContext>().UseInMemoryDatabase("TestDatabase").Options;
            using (var context = new LegendBankContext(options))
            {
                var sut = new UserRepository(context);
                var auth = new AuthRepository(context, sut);
                var details = new string[] { "Ayobami", "Baddo", "samuel@gmail.com", "Legend", "Boss", "legendbaba@gmail.com" };
                var password1 = Utilities.GenerateHash("abcde");
                var password2 = Utilities.GenerateHash("12345");
                auth.Register(details[0], details[1], details[2], password1[0], password1[1]);
                auth.Register(details[3], details[4], details[5], password2[0], password2[1]);

                //Act & Assert
                Assert.Throws<ArgumentException>(() => auth.Login("baddo@gmail.com", "abcd"));
            }
            
        }
    }
}
