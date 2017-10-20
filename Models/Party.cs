using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Santa.Models
{
  public class Party
  {
    [BsonId]
    public ObjectId Party_id { get; set; }
    public string CreatorID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string PartyStatus { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime DrawDate { get; set; }
  }
}