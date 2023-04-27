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
                TextColor = Colors.Foreground["LIGHTBLUE"]
            });
            services.Add(new Service()
            {
                ServiceName = "Discord",
                TextColor = Colors.Foreground["BLUE"]
            });
            services.Add(new Service()
            {
                ServiceName = "SberJazz",
                TextColor = Colors.Foreground["LIGHTGREEN"]
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
            PrintMenu();
            ConsoleKeyInfo answer = Console.ReadKey(true);

            while (answer.Key != ConsoleKey.Enter && answer.Key != ConsoleKey.Escape)
            {

                switch (answer.KeyChar)
                {
                    case 'A':
                    case 'a':
                        Console.WriteLine(tsystem.AddTeacher(CreateTeacher(services)));
                        Console.WriteLine(tsystem.PrintTeachers());
                        break;

                    case 'T':
                    case 't':
                        Console.WriteLine(tsystem.PrintTeachers());
                        break;

                    case 'S':
                    case 's':
                        tsystem.GetTopServices();
                        Console.WriteLine(tsystem.PrintTopServices());
                        break;

                    default:
                        break;
                }

                PrintMenu();
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
            teacher.PrefferedService = services.Find(s => s.ServiceName == serviceName) ?? CreateService(serviceName, services);
            return teacher;
        }

        private static Service CreateService(string serviceName, List<Service> services)
        {
            Console.WriteLine("\nCreate new sevice {0}", serviceName);
            Console.Write("Enter service color: ");
            string textColor = Console.ReadLine();
            string colorName = textColor;

            if (!Colors.Foreground.TryGetValue(textColor, out textColor))
            {
                string newColor = "\x1b[38;2;";
                Console.WriteLine($"\nCan't find color {colorName}. \nPlease add new color in 256-bit code.");
                Console.Write("Red: ");
                newColor += Console.ReadLine() + ";";
                Console.Write("Green: ");
                newColor += Console.ReadLine() + ";";
                Console.Write("Blue: ");
                newColor += Console.ReadLine() + "m";

                Colors.Foreground.Add(colorName, newColor);
                textColor = newColor;
            }

            Service newService = new Service()
            {
                ServiceName = serviceName,
                TextColor = Console.IsOutputRedirected ? "" : textColor
            };

            services.Add(newService);

            return newService;
        }

        private static void PrintMenu()
        {
            Console.WriteLine("A - Add new teacher");
            Console.WriteLine("T - Print teachers");
            Console.WriteLine("S - Print top services");
            Console.WriteLine("Esc - Exit program\n");
        }
    }
}
