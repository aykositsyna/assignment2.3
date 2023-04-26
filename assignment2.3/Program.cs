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
            TSystem tsystem = new TSystem();
            tsystem.Teachers.Add(new Teacher(){ 
                LastName = "Kositsyn",
                FirstName = "Stanislav",
                MiddleName = "Yurievich",
                Institute = "ISIT",
                PrefferedService = new Service()
                {
                    ServiceName = "Skype",
                    TextColor = Colors.Foreground.LIGHTBLUE,
                }    
            });
            tsystem.Teachers.Add(new Teacher()
            {
                LastName = "Ivanov",
                FirstName = "Ivan",
                MiddleName = "Ivanovich",
                Institute = "IOG",
                PrefferedService = new Service()
                {
                    ServiceName = "Discord",
                    TextColor = Colors.Foreground.VIOLET,
                }
            });
            tsystem.Teachers.Add(new Teacher()
            {
                LastName = "Kirkorov",
                FirstName = "Filip",
                MiddleName = "Bedrosovich",
                Institute = "HI",
                PrefferedService = new Service()
                {
                    ServiceName = "Skype",
                    TextColor = Colors.Foreground.LIGHTBLUE,
                }
            });
            tsystem.Teachers.Add(new Teacher()
            {
                LastName = "Petrov",
                FirstName = "Petr",
                MiddleName = "Petrovich",
                Institute = "IG",
                PrefferedService = new Service()
                {
                    ServiceName = "SberJazz",
                    TextColor = Colors.Foreground.LIGHTGREEN,
                }
            });

            Console.WriteLine(tsystem.PrintTeachers());

            tsystem.GetTopServices();

            Console.WriteLine(tsystem.PrintTopServices());
        }
    }
}
