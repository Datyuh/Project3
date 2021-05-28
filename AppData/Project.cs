using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.AppData
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NameProject { get; set; }
        public DateTime StartProject { get; set; }
        public DateTime EndProject { get; set; }

        public List<User> Users { get; set; } = new();
    }
}