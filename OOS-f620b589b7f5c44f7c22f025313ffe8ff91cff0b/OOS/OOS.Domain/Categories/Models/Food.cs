using MongoDB.Bson.Serialization.Attributes;
using OOS.Infrastructure.Mongodb;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOS.Domain.Categories.Models
{
    [BsonIgnoreExtraElements]
    public class Food : IAggregateRoot
    {
        public string Id { get; set; }

        public int Name { get; set; }

        public string IdCategoryFood { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
    }
}
