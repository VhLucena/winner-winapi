using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace Winap.Models
{
    public class Person
    {
        [BsonId]
        [BsonRepresentation((BsonType.ObjectId))]        
        public int Id { get; set; }
        
        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string Name { get; set; }
        
        public int Age { get; set; }
    }
}