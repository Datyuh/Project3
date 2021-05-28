using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.AppData
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NameUsers { get; set; }
        public double MobilPhoneUsers { get; set; }
        public string RightsUsers { get; set; }

        public int LoggingsId { get; set; }
        public Loggings Logging { get; set; }

        public int ProjectsId { get; set; }
        public Project Projects { get; set; }

        public int UserTaskId { get; set; }
        public UserTask UsersTask { get; set; }
    }
}