using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.Entities.Identity
{
    public class Address : BaseEntity
    {
        public string LastName { get; set; }
        public string State {set; get;}
        public string Street {set; get;}
        public string City {set; get;}
        public string ZipCode {set; get;}

        [Required]
        public string AppUserId {set; get;}
        [JsonIgnore]
        public AppUser AppUser {set;get;}

    }
}