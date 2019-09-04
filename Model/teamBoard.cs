using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_microservice_backend.Model
{
    public class teamBoard
    {
        Board board = new Board();
       
        
        [BsonId]
        public int BId { get; set; }
        [BsonElement("boardname")]
        public string BoardName { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
    }
}
