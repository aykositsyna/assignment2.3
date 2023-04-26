using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._3
{
    delegate bool IsCanAddTeacher (string name);
    internal class TSystem
    {
        public List<Teacher> Teachers = new List<Teacher>();
        public List<TopServices>  GetTopServices()
        {
            List<TopServices> TopServices = Teachers
                .GroupBy(t => t.PrefferedService.ServiceName)
                .Select(g => new TopServices()
                {
                    ServiceName = g.Key,
                    TextColor = g.First().PrefferedService.TextColor,
                    CountOfUsing = g.Count()
                })
                .OrderByDescending(g => g.CountOfUsing)
                .Take(3)
                .ToList();

            return TopServices;

        }

        public string AddTeacher(Teacher newTeacher)
        {
            IsCanAddTeacher isCanAddTeacher = (name) => Teachers.Find((t) => t.Fio.Equals(name)) == null;
            string result = "This teacher already exists, you can't add them :(";

            if (isCanAddTeacher(newTeacher.Fio))
            {
                Teachers.Add(newTeacher);
                result = "Teacher added";
            }
            return result;

        }

        public string PrintTeachers()
        {
            string result = "";
            int maxLength = 0;

            foreach (Teacher teacher in Teachers)
            {
                string Fio = Extension.FioExtension(teacher.Fio);
                string Institute = teacher.Institute;
                Service service = teacher.PrefferedService;

                string newString =
                    Fio + "\t\t" +
                    Institute + "\t" +
                    service.TextColor + "[" + service.ServiceName + "]" +
                    Colors.RESET + "\n";

                result += newString;
                // maxLength = (newString.Length > maxLength)
                //     ? newString.Length
                //     : maxLength;
                maxLength = Math.Max(newString.Length, maxLength);
            }

            result =
                HeaderCreator(maxLength, "=", "Teachers") +
                result +
                HeaderCreator(maxLength) +
                "\n";
            return result;
        }

        public string PrintTopServices()
        {
            string result = "";
            int maxLength = 0;
            List<TopServices> TopServices = GetTopServices();

            foreach (TopServices service in TopServices)
            {
                string newString = service.TextColor +
                    service.ServiceName +
                    Colors.RESET +
                    "\n";
                result += newString;
                maxLength = Math.Max(newString.Length, maxLength);
            }

            result =
                HeaderCreator(maxLength, "=", "Top services") +
                result +
                HeaderCreator(maxLength) +
                "\n";
            return result;
        }

        private string HeaderCreator(int length, string sChar = "-", string header = "")
        {
            header = header == "" ? "" : " " + header + " ";
            int separatorLength = (length - header.Length) / 2;
            string separator = String.Join("", Enumerable.Repeat(sChar, separatorLength).ToArray());
            return separator + header + separator + "\n";
        }

    }
}
