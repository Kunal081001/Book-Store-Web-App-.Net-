using Microsoft.AspNetCore.Identity;

namespace BookStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set;  }
        public long Mobile { get; set; }
        public string Address {  get; set; }    
        public int Pincode { get; set; }
        public string City { get; set; }    
        public string State { get; set; }

    }
}
