using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_microservice_backend.Model
{
    public class Member
    {
        [BsonId]
        public int Mid { get; set; }
        [BsonElement("membername")]
        public string memberName { get; set; }
        [BsonElement("status")]
        public string status { get; set; }
        [DataType(DataType.Date)]
        public DateTime assignedDate { get; set; }
        
    }
}
