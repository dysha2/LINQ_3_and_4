﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace miheev2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> s = File.ReadAllLines("file.txt").Select(x => x.Split(' ')).ToList();
            try
            {
                string[] groups = s.Where(x => float.Parse(x[4]) > 4).Select(x => x[3]).Distinct().ToArray();
                foreach (string group in groups)
                {
                    int count = s.Where(x => float.Parse(x[4]) > 4 && x[3] == group).Count();
                    Console.WriteLine(group + $": {count}");
                    s.Where(x => float.Parse(x[4]) > 4 && x[3] == group).ToList().ForEach(x => Console.WriteLine($"{x[0]} {x[1]} {x[2]}"));
                }
            }catch { Console.WriteLine("Одна из строк в файле содержит некорректные данные"); }
                           Console.ReadKey();
        }
    }
}
