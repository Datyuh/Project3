using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.AppData
{
    public class UserTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string UsersTasks { get; set; }

        public double PlannedExecutionPeriod { get; set; }
        public double ActualExecutionPeriod { get; set; }
        public double PlannedLaborIntensity { get; set; }
        public double ActualLaborIntensity { get; set; }

        public List<User> Users { get; set; } = new();
    }
}