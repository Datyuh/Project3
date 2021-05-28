using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Project3.AppData;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext application = new())
            {
                var checkForNull = application.Loggings.Select(p => p.Loggin).FirstOrDefault();
                if (checkForNull == null)
                {
                    Loggings loggings1 = new Loggings {Loggin = "123", Password = "123"};
                    Loggings loggings2 = new Loggings {Loggin = "456", Password = "456"};
                    application.Loggings.AddRange(loggings1, loggings2);

                    Project project1 = new Project
                    {
                        NameProject = "Какой-то проект1", StartProject = new DateTime(2020, 03, 22),
                        EndProject = new DateTime(2021, 03, 08)
                    };
                    Project project2 = new Project
                    {
                        NameProject = "Какой-то проект2",
                        StartProject = new DateTime(2019, 04, 22),
                        EndProject = new DateTime(2020, 08, 08)
                    };
                    application.Projects.AddRange(project1, project2);

                    UserTask userTask1 = new UserTask
                    {
                        PlannedExecutionPeriod = 20, 
                        ActualExecutionPeriod = 30,
                        PlannedLaborIntensity = 50,
                        ActualLaborIntensity = 40, 
                        UsersTasks = "Сделать в проекте что-то1"
                    };
                    UserTask userTask2 = new UserTask
                    {
                        PlannedExecutionPeriod = 30,
                        ActualExecutionPeriod = 20,
                        PlannedLaborIntensity = 40,
                        ActualLaborIntensity = 60,
                        UsersTasks = "Сделать в проекте что-то2"
                    };
                    application.UsersTask.AddRange(userTask1, userTask2);

                    User user1 = new User
                    {
                        NameUsers = "Иванов Василий Васильевич", MobilPhoneUsers = 86596546264, RightsUsers = "User", Logging = loggings1,
                        Projects = project2, UsersTask = userTask1
                    };
                    User user2 = new User
                    {
                        NameUsers = "Петров Петр Петрович", MobilPhoneUsers = 89536546264, RightsUsers = "Supervisor", Logging = loggings2,
                        Projects = project1, UsersTask = userTask2
                    };
                    application.Users.AddRange(user1, user2);
                    application.SaveChanges();
                }

                var users = application.Users.Include(u => u.Projects).Include(t => t.UsersTask).ToList();
                foreach (User user in users)
                {
                    Console.WriteLine(
                        $"Имя или ФИО = {user.NameUsers} \n Название проекта = {user.Projects?.NameProject}\n Задачи пользователя = {user.UsersTask?.UsersTasks} \n " +
                        $"Планируемый срок исполнения = {user.UsersTask?.PlannedExecutionPeriod} дней\n Фактический срок исполнения = {user.UsersTask?.ActualExecutionPeriod} дней \n " +
                        $"Планируемая трудоемкость = {user.UsersTask?.PlannedLaborIntensity} дней\n Фактическая трудоемкость = {user.UsersTask?.ActualLaborIntensity} дней");
                    Console.WriteLine("===========================================================================");
                }


            }
            Console.ReadKey();
        }
    }
}
