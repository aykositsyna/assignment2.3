﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._3
{
    delegate bool IsCanAddTeacher (string name);
    internal class TSystem
    {
        List<Teacher> Teachers = new List<Teacher>();
        public List<TopServices> GetTopServices(List<Teacher> Teachers)
        {
            List<TopServices> TopServices = Teachers
                .GroupBy(t => t.PrefferedService)
                .Select(g => new TopServices { service = g.Key, CountOfUsing = g.Count() })
                .OrderByDescending(g => g.CountOfUsing)
                .Take(3)
                .ToList();

            return TopServices;
        }


    }
}