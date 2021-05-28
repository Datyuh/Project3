using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.AppData
{
    public class Loggings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Loggin { get; set; }
        public string Password { get; set; }
        public User UsersId { get; set; }
        public DateTime RegisterTime { get; set; }

        public Loggings()
        {
            RegisterTime = DateTime.Now.Date;
        }
    }
}