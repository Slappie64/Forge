using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forge.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string WorkoutType { get; set; }

        public string Description { get; set; }
        public int DurationInMinutes { get; set; }
        public int CaloriesBurned { get; set; }
    }
}