using LegendBankBeta.Lib.Commons;
using LegendBankBeta.Lib.Core.Interfaces;
using LegendBankBeta.Lib.Data;
using LegendBankBeta.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendBankBeta.Lib.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LegendBankContext _context;

        public UserRepository (LegendBankContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates Customer 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public string CreateCustomer(string firstName, string lastName)
        {
            var customer = new Customer
            {
                FirstName = Utilities.RemoveDigitFromStart(Utilities.FirstCharacterToUpper(firstName)),
                LastName = Utilities.RemoveDigitFromStart(Utilities.FirstCharacterToUpper(lastName)),
            };

            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer.Id;
        }

        /// <summary>
        /// Creates User Object 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passwordHash"></param>
        /// <param name="passwordSalt"></param>
        /// <param name="customerId"></param>
        public string CreateUser(string email, byte[] passwordHash, byte[] passwordSalt, string customerId)
        {
            var user = new User
            {
                Email = email,
                PasswordHash = Convert.ToBase64String(passwordHash),
                PasswordSalt = Convert.ToBase64String(passwordSalt),
                CustomerId = customerId

            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        /// <summary>
        /// Gets Customer by ID 
        /// </summary>
        /// <param name="customerId"></param>
        public Customer GetCustomerById(string customerId)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == customerId);
            return customer;
        }

        /// <summary>
        /// Gets User Info by ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public User GetUserById(string userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            return user;
        }
    }
}
