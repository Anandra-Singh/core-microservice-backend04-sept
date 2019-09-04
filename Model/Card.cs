using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_microservice_backend.Model
{
    public class Card
    {
        [BsonId]
        public int CId { get; set; }

        [BsonElement("cardname")]
        public string cardName { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        public List<Member> cardMembers { get; set; }
        public List<Label> Labels { get; set; }
        public List<Attachment> Attachements { get; set; }
        public List<Comment> Comments { get; set; }

        
    }
}
