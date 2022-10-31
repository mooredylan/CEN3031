using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Budgetting.Models;
using Budgetting.ViewModels;
using Microsoft.EntityFrameworkCore;
using BC = BCrypt.Net.BCrypt;

namespace Budgetting.Data
{
    public class DatabaseRepository
    {
        private readonly DatabaseContext context;

        public DatabaseRepository()
        {
            this.context = new DatabaseContext();
        }

        /// <summary>
        /// Gets 1 profile based on username and password
        /// </summary>
        public Profile GetProfile(string username, string password)
        {
            return this.context.Profiles
                .Include(x => x.Budget)
                .ToList()
                .SingleOrDefault(x => 
                    x.Username.ToLower() == username.ToLower() 
                    && BC.Verify(password, x.Password, false, BCrypt.Net.HashType.SHA384)
                );
        }

        
        /// <summary>
        /// Gets 1 profile based on username and password
        /// Returns the created profile on success
        /// </summary>
        public Profile CreateProfile(NewProfile newProfile)
        {
            Profile existing = this.context.Profiles.SingleOrDefault(x => x.Username.ToLower() == newProfile.Username.ToLower());

            if(existing != null)
            {
                return null;
            }
            
            Profile profile = new Profile()
            {
                Username = newProfile.Username,
                Password = BC.HashPassword(newProfile.Password)
            };

            this.context.Profiles.Add(profile);
            this.context.SaveChanges();

            return profile;
        }

    }
}
