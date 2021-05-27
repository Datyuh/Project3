using System;

namespace Project3.AppData
{
    public class Loggings
    {
        public int Id { get; set; }
        public string Loggin { get; set; }
        public string Password { get; set; }
        public User UsersId { get; set; }
        public DateTime RegisterTime { get; set; }
    }
}