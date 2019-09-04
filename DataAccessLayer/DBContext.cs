using core_microservice_backend.Model;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_microservice_backend.DataAccessLayer
{
    public class DBContext
    {
        MongoClient mongoClient;
        IMongoDatabase mongoDatabase;
        public DBContext(IConfiguration configuration)
        {
            mongoClient = new MongoClient(configuration.GetSection("MongoDb:server").Value);
            mongoDatabase = mongoClient.GetDatabase(configuration.GetSection("MongoDB:database").Value);
        }
        public IMongoCollection<Team> Teams => mongoDatabase.GetCollection<Team>("Teams");

        //public IMongoCollection<Board> Boards => mongoDatabase.GetCollection<Board>("Boards");
    }
}
