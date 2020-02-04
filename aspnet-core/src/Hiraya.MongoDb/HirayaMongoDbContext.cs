using Abp.Application.Services;
using Hiraya.Domain.MongoDBCollections.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiraya.MongoDb
{
    public class HirayaMongoDbContext : IApplicationService
    {
        private readonly IMongoDatabase _database;

        /// <summary>
        /// Database Context for App Big Data.  If name parameter is null, "Default" database will be selected
        /// </summary>
        /// <param name="name">Specify the name of the database</param>
        public HirayaMongoDbContext(string name = "Hiraya")
        {

            _database = new MongoClient("mongodb://localhost:27017").GetDatabase(name);
            //_database.DropCollection("<CollectionName>"); // Remove Collection
        }

        public IMongoCollection<TaxpayerProfile> TaxpayerProfiles => _database.GetCollection<TaxpayerProfile>("TaxpayerProfiles");
        public IMongoCollection<Notice> Notices => _database.GetCollection<Notice>("Notices");



    }
}
