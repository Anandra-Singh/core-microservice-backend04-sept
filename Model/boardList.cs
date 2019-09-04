using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_microservice_backend.Model
{
    public class boardList
    {
        public int LId { get; set; }
        [BsonElement("listname")]
        public string ListName { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
    }
}
