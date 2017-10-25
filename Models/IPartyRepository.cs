using System;
using System.Collections.Generic;

namespace Santa.Models
{
  public interface IPartyRepository
  {
    IEnumerable<Party> parties { get; }
    void Create(Party p);
    void CreateMany(IEnumerable<Party> ps);
    Party GetParty(string id);
    void Update(Party item);
    void Delete(string id);
  }
}