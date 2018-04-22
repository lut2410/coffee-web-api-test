using MongoDB.Bson.Serialization.Attributes;
using OOS.Infrastructure.Mongodb;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOS.Domain.Tables.Models
{
    [BsonIgnoreExtraElements]
    public class Table : IAggregateRoot
    {
        public string Id { get; set; }

        public int Status { get; set; }

        public ItemOfBill[] ItemsOfBill { get; set; }
    }
}
