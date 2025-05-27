using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forge.Models
{
    public class Progress
    {
        [Key]
        public int Id { get; set; }
        
        // Foreign key linking progress to a goal.
        [Required]
        public int GoalId { get; set; }
        
        [ForeignKey("GoalId")]
        public Goal Goal { get; set; }
        
        // The date when the progress was recorded.
        [Required]
        public DateTime DateRecorded { get; set; }
        
        // The metric tracked (e.g., "Weight" or "Distance").
        [Required]
        public string Metric { get; set; }
        
        // The recorded value of that metric.
        public double Value { get; set; }
    }
}
