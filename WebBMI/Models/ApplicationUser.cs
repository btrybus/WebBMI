using Microsoft.AspNetCore.Identity;

namespace WebBMI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public virtual ICollection<Measurement> Measurements { get; set; }
    }
}