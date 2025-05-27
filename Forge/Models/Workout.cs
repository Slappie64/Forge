using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forge.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }

        // Foreign key referencing the ApplicationUser.
        [Required]
        public string ApplicationUserId { get; set; }
        
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser User { get; set; }
        
        // The date of the workout.
        [Required]
        public DateTime Date { get; set; }
        
        // Type of workout (e.g., Cardio, Strength).
        [Required]
        public string WorkoutType { get; set; }
        
        // Optional workout details/notes.
        public string Description { get; set; }
        
        // Example metrics.
        public int DurationInMinutes { get; set; }
        public double CaloriesBurned { get; set; }
    }
}
