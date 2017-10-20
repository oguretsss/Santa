using System;
using System.Collections.Generic;

namespace Santa.Models
{
  public interface IPartyRepository
  {
    IEnumerable<Party> parties { get; }
  }
}