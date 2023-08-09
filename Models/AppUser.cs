using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace YellowBook.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]//Label
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and a max {1} characters long.", MinimumLength = 2)] //{0} is the column itself
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]//Label
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and a max {1} characters long.", MinimumLength = 2)] //{0} is the column itself
        public string? LastName { get; set; }

        [NotMapped]
        public string? FullName { get { return $"{FirstName} {LastName}"; } }

        public virtual ICollection<Contact?> Contacts { get; set; } = new HashSet<Contact?>();
        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    }

}
