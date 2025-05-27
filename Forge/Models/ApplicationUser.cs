using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Forge.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }

        // Navigation properties: A user can have many workouts and goals.
        public ICollection<Workout> Workouts { get; set; }
        public ICollection<Goal> Goals { get; set; }
    }
}
