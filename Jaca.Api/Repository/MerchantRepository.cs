﻿using Jaca.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jaca.Api.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Jaca.Api.Repository
{
    public class MerchantRepository : BaseRepository<Merchant>, IMerchantRepository
    {
        public MerchantRepository() : base(COLLECTION_NAME) { }

        private const string COLLECTION_NAME = nameof(Merchant);

        public void CreateOrUpdate(Merchant merchant)
        {
            this.Collection.ReplaceOne(
                 new BsonDocument("_id", merchant.Id),
                 merchant,
                 new UpdateOptions { IsUpsert = true });
        }

        public Merchant GetById(string id)
        {
            var result = this.Collection.Find(x => x.Id == id).FirstOrDefault();
            return result;
        }

        public List<Merchant> GetAllMerhants()
        {
            var result = this.Collection.Find(x => true);
            return result.ToList();
        } 
    }
}
