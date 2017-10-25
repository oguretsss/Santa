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
            database.GetCollection<Party>("Parties").InsertOne(p);
        }

        public void CreateMany(IEnumerable<Party> ps)
        {
            database.GetCollection<Party>("Parties").InsertMany(ps);
        }

        public IEnumerable<Party> parties => database.GetCollection<Party>("Parties").Find(a => true).ToList();
  }
}