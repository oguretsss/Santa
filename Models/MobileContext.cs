using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Santa.Models
{
    public class MobileContext : IPartyRepository
    {
        IMongoDatabase database; // база данных
        IGridFSBucket gridFS;   // файловое хранилище

        public IMongoCollection<Party> Parties 
        {
            get { return database.GetCollection<Party>("Parties"); }
        }

        public MobileContext()
        {
            // строка подключения
            string connectionString = "mongodb://localhost:27017/test";
            var connection = new MongoUrlBuilder(connectionString);
            // получаем клиента для взаимодействия с базой данных
            MongoClient client = new MongoClient(connectionString);
            // получаем доступ к самой базе данных
            database = client.GetDatabase(connection.DatabaseName);
            // получаем доступ к файловому хранилищу
            gridFS = new GridFSBucket(database);
        }

        public void Create(Party p)
        {
            Parties.InsertOne(p);
        }

        public void CreateMany(IEnumerable<Party> ps)
        {
            Parties.InsertMany(ps);
        }

    public Party GetParty(string id)
    {
      return Parties.Find(a => a.Party_id.ToString() == id).First();
    }

    public void Update(Party item)
    {
    }

    public void Delete(string id)
    {
    }

    public IEnumerable<Party> parties => Parties.Find(a => true).ToList();
  }
}