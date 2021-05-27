using System.Collections.Generic;

namespace Project3.AppData
{
    public class UserTask
    {
        public int Id { get; set; }

        public double PlannedExecutionPeriod { get; set; }
        public double ActualExecutionPeriod { get; set; }
        public double PlannedLaborIntensity { get; set; }
        public double ActualLaborIntensity { get; set; }

        public ICollection<User> Users { get; set; }
    }
}