using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Identity
{
    public class AppUser : IdentityUser
    {
        public string Name {set; get;}
        public Address Address {set; get;}
        
         [NotMapped]
        public string Role { set; get; }
    }
}