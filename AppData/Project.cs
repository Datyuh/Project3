using System;
using System.Collections.Generic;

namespace Project3.AppData
{
    public class Project
    {
        public int Id { get; set; }
        public string NameProject { get; set; }
        public DateTime StartProject { get; set; }
        public DateTime EndProject { get; set; }

        public ICollection<User> Users { get; set; }
    }
}