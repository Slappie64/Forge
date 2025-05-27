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

        [Required]
        public string ApplicationUserId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        public double targetValue { get; set; }
        public DateTime TargetDate { get; set; }
        public ICollection<Progress> Progresses { get; set; }
    }
}