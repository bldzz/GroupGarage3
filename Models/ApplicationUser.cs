using Microsoft.AspNetCore.Identity;

namespace Garage_3._0.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public int SSN { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";

       public ICollection<Vehicle> Vehicles { get; set; } //avkommentera när vi har Vehicle klass (1 användare kan ha många vehicles)
    }
}
