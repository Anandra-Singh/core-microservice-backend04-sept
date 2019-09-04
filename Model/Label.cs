using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_microservice_backend.Model
{
    public class Label
    {
        [BsonId]
        public int labId { get; set; }
        [BsonElement("labelname")]
        public string labelName { get; set; }
        public byte labelColor { get; set; }
    }
}
