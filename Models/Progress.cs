using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Forge.Models
{
    public class Progress
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int GoalId { get; set; }

        [ForeignKey("GoalId")]
        public Goal Goal { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Metric { get; set; }

        public double Value { get; set; }
    }
}