using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._3
{
    public class Assignment2_3
    {
        public static void Main(string[] args)
        {
            List<Service> services = new List<Service>();
            services.Add(new Service()
            {
                ServiceName = "Skype",
                TextColor = Colors.Foreground.LIGHTBLUE
            });
            services.Add(new Service()
            {
                ServiceName = "Discord",
                TextColor = Colors.Foreground.VIOLET
            });
            services.Add(new Service()
            {
                ServiceName = "SberJazz",
                TextColor = Colors.Foreground.LIGHTGREEN
            });

            TSystem tsystem = new TSystem();
            tsystem.Teachers.Add(new Teacher(){ 
                LastName = "Kositsyn",
                FirstName = "Stanislav",
                MiddleName = "Yurievich",
                Institute = "ISIT",
                PrefferedService = services.Find(s => s.ServiceName == "Skype")
            });
            tsystem.Teachers.Add(new Teacher()
            {
                LastName = "Ivanov",
                FirstName = "Ivan",
                MiddleName = "Ivanovich",
                Institute = "IOG",
                PrefferedService = services.Find(s => s.ServiceName == "Discord")
            });
            tsystem.Teachers.Add(new Teacher()
            {
                LastName = "Kirkorov",
                FirstName = "Filip",
                MiddleName = "Bedrosovich",
                Institute = "HI",
                PrefferedService = services.Find(s => s.ServiceName == "Skype")
            });
            tsystem.Teachers.Add(new Teacher()
            {
                LastName = "Petrov",
                FirstName = "Petr",
                MiddleName = "Petrovich",
                Institute = "IG",
                PrefferedService = services.Find(s => s.ServiceName == "SberJazz")
            });

            Console.WriteLine(tsystem.PrintTeachers());

            tsystem.GetTopServices();

            Console.WriteLine(tsystem.PrintTopServices());
            Console.WriteLine("A - Add new teacher");
            Console.WriteLine("T - Print teachers");
            Console.WriteLine("S - Print top services");
            ConsoleKeyInfo answer = Console.ReadKey(true);

            while (answer.Key != ConsoleKey.Enter && answer.Key != ConsoleKey.Escape)
            {

                switch (answer.KeyChar)
                {
                    case 'A':
                        Console.WriteLine(tsystem.AddTeacher(CreateTeacher(services)));
                        Console.WriteLine(tsystem.PrintTeachers());
                        break;

                    case 'T':
                        Console.WriteLine(tsystem.PrintTeachers());
                        break;

                    case 'S':
                        tsystem.GetTopServices();
                        Console.WriteLine(tsystem.PrintTopServices());
                        break;

                    default:
                        break;
                }
                Console.WriteLine("A - Add new teacher");
                Console.WriteLine("T - Print teachers");
                Console.WriteLine("S - Print top services");
                answer = Console.ReadKey(true);
            }
        }

        private static Teacher CreateTeacher(List<Service> services)
        {
            Teacher teacher = new Teacher();
            Console.Write("Enter last name: ");
            teacher.LastName = Console.ReadLine();
            Console.Write("Enter first name: ");
            teacher.FirstName = Console.ReadLine();
            Console.Write("Enter middle name: ");
            teacher.MiddleName = Console.ReadLine();
            Console.Write("Enter institute: ");
            teacher.Institute = Console.ReadLine();
            Console.Write("Enter preffered service: ");
            string serviceName = Console.ReadLine();
            teacher.PrefferedService = services.Find(s => s.ServiceName == serviceName) ?? CreateService(serviceName);
            return teacher;
        }

        private static Service CreateService(string serviceName)
        {
            Console.WriteLine("Create new sevice {0}", serviceName);
            Console.Write("Enter service color: ");
            string textColor = Console.ReadLine();
            return new Service()
            {
                ServiceName = serviceName,
                TextColor = textColor
            };
        }
    }
}
