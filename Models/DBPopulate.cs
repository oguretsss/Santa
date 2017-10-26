using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Santa.Models
{
    public class DBPopulate
    {
        public static void EnsurePopulateDB(IApplicationBuilder app)
        {
            IPartyRepository context = app.ApplicationServices.GetRequiredService<IPartyRepository>();
            if (!context.parties.Any())
            {
                List<Party> parties = new List<Party> 
                {
                    new Party { Name = "Test Party 1", Description = @"Description for this party is longer than I thought. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", PartyStatus = "PRIVATE", CreationDate = DateTime.Now, CreatorID = "Santa", DrawDate = DateTime.Now },
                    new Party { Name = "Christmas Party", Description = "Description for Christmas party", PartyStatus = "PRIVATE", CreationDate = DateTime.Parse("2017-09-11"), CreatorID = "Torphik", DrawDate = DateTime.Now },
                    new Party { Name = "New Year's Party", Description = "Description for this party", PartyStatus = "PRIVATE", CreationDate = DateTime.Now, CreatorID = "Torphik", DrawDate = DateTime.Now },
                    new Party { Name = "Tophail's Party", Description = "Description for this party", PartyStatus = "PRIVATE", CreationDate = DateTime.Now, CreatorID = "Torphik", DrawDate = DateTime.Now },
                    new Party { Name = "Martyn Gey party", Description = "Description for this party", PartyStatus = "PRIVATE", CreationDate = DateTime.Now, CreatorID = "Larisa", DrawDate = DateTime.Now },
                    new Party { Name = "Another Martyn Gey party", Description = "Yayca puk p[u kpuk awdfawdwaparty", PartyStatus = "PRIVATE", CreationDate = DateTime.Now, CreatorID = "Larisa", DrawDate = DateTime.Now }
                };
                context.CreateMany(parties);
            }
        }
    }
}