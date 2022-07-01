namespace ManagmentSystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class ApplicationUser : IdentityUser
    {
        // To do.. This is class who inheritance IdentityUser and make custome role
        [Display(Name = "Username")]
        public string FullName { get; set; }
    }
}
