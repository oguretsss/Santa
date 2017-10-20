using System.Collections.Generic;
using System;

namespace Santa.Models{
    public class FakePartyRepository : IPartyRepository
    {
        public IEnumerable<Party> parties => new List<Party> {
            new Party { Name = "Test Party 1", Description = "Fake description", CreationDate = DateTime.Now, CreatorID = "Torphik" },
            new Party { Name = "New Years Test Party", Description = "Fake description", CreationDate = DateTime.Parse("2008-05-01 7:34:42Z"), CreatorID = "Tophail" },
            new Party { Name = "Christmas Test Party", Description = "Fake description", CreationDate = DateTime.Parse("2017-12-24 9:34:42Z"), CreatorID = "Doshik" }
        };
    }
}
    