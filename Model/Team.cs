using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_microservice_backend.Model
{
    public class Team
    {
        [BsonId]
        public int teamID;
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("descriptions")]
        public string Description { get; set; }
        public List<teamBoard> teamBoards { get; set; }
        public List<Member> teamMembers { get; set; }
        public List<invitee> teamInvites { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
