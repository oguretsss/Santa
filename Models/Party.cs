using System;

namespace Santa.Models
{
  public class Party
  {
    public int PartyID { get; set; }
    public string CreatorID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string PartyStatus { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime DrawDate { get; set; }
  }
}