using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forge.Models
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        
        // Link this goal to a specific user.
        [Required]
        public string ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser User { get; set; }
        
        // A short title for the goal.
        [Required]
        public string Title { get; set; }
        
        // Detailed information about the goal.
        public string Description { get; set; }
        
        // The target value (could be a weight, distance, duration, etc.).
        public double TargetValue { get; set; }
        
        // Optional due date.
        public DateTime? DueDate { get; set; }
        
        // Navigation property for progress updates.
        public ICollection<Progress> Progresses { get; set; }
    }
}
