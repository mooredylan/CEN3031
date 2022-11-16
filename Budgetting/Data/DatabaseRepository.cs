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
            if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) return null;
            
            return this.context.Profiles
                .Include(x => x.Budgets)
                .AsNoTracking()
                .ToList()
                .SingleOrDefault(x => 
                    x.Username.ToLower() == username.ToLower() 
                    && BC.Verify(password, x.Password, false, BCrypt.Net.HashType.SHA384)
                );
        }

        /// <summary>
        /// Gets 1 profile based on username and password
        /// </summary>
        public Profile GetProfile(int id)
        {
            return this.context.Profiles
                .Include(x => x.Budgets)
                .AsNoTracking()
                .ToList()
                .SingleOrDefault(x => 
                    x.Id == id
                );
        }
        
        /// <summary>
        /// Creates a new profile
        /// Returns the created profile on success
        /// </summary>
        public Profile CreateProfile(NewProfile newProfile)
        {
            if(newProfile == null) return null;

            Profile existing = this.context.Profiles.AsNoTracking().SingleOrDefault(x => x.Username.ToLower() == newProfile.Username.ToLower());

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

        /// <summary>
        /// Creates a new budget on a profile
        /// Returns the profile on success
        /// </summary>
        public Profile SaveBudget(Profile profile, Budget budget)
        {
            if(profile == null || budget == null) return null;

            Profile curProfile = this.GetProfile(profile.Id);

            Budget curBudget = this.context.Budgets.AsNoTracking().SingleOrDefault(x => x.Id == budget.Id);

            if(curProfile != null)
            {
                if (curBudget == null)
                {
                    this.context.Add(budget);
                }
                else
                {
                    curBudget = budget;
                    this.context.Update(curBudget);
                }
                
                this.context.SaveChanges();

                return this.GetProfile(curProfile.Id);
            }

            return null;
        }

    }
}
