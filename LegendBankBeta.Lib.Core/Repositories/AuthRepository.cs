using LegendBankBeta.Lib.Commons;
using LegendBankBeta.Lib.Core.Interfaces;
using LegendBankBeta.Lib.Data;
using LegendBankBeta.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendBankBeta.Lib.Core.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly LegendBankContext _context;
        private readonly IUserRepository userRepo;

        public AuthRepository(LegendBankContext context, IUserRepository userRepository)
        {
            _context = context;
            userRepo = userRepository;
        }

        /// <summary>
        /// Logins in the user after validating email and password 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>        
        public bool Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u=> u.Email == email);
            if (Utilities.validateEmail(email) == false)
            {
                throw new ArgumentException("Enter a Valid Email");
                
            }
            else 
            {
                if (!IsValidCred(email, password))
                {
                    throw new ArgumentException("Wrong Email or Password");
                }
                else
                {
                    Datalog.loggedUser.Add(userRepo.GetCustomerById(user.CustomerId));
                    return true;
                }

            }
        }

        /// <summary>
        /// Logs out the user
        /// </summary>
        /// <returns></returns>
        public string Logout()
        {
            Datalog.loggedUser.Clear();
            Datalog.loggedAcct.Clear();
            return "User successfully Logged out";
        }

        /// <summary>
        /// Registers the user 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="passwordhash"></param>
        /// <param name="passwordsalt"></param>
        public string Register(string firstName, string lastName, string email, byte[] passwordhash, byte[] passwordsalt)
        {
            if (EmailExist(email))
            {
                throw new ArgumentException("Email Already Exists");
            }
            else
            {
                var customer = userRepo.CreateCustomer(firstName, lastName);
                userRepo.CreateUser(email, passwordhash, passwordsalt, customer);
                return customer;
            }
        }

        /// <summary>
        /// Checks if email and password are in the database
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        private bool IsValidCred(string email, string password)
        {
            bool passwordMatch = false;
            if (EmailExist(email))
            {
                var user = _context.Users.First(u => u.Email == email);
                if (user.Email == email && Utilities.CompareHash(Convert.FromBase64String(user.PasswordSalt), Convert.FromBase64String(user.PasswordHash), password))
                {
                    passwordMatch = true;
                }
            }
            else
            {
                throw new ArgumentException("Email is not registered with the bank");
            }
            return passwordMatch;
        }

        /// <summary>
        /// checks if email exists in the database
        /// </summary>
        /// <param name="email"></param>
        internal bool EmailExist(string email)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                return true;
            }
            return false;
        }
    }
}
