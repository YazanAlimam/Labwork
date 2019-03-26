using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessing_v0._2_
{
    class Data
    {
        List<Student> s = new List<Student>();
        public void add(Student a)
        {
            s.Add(a);
        }
        public void display()
        {
            Compar hy = new Compar();
            s.Sort(hy);
            Console.WriteLine("SurName".PadRight(25) + "Name".PadRight(25) + "Final Point Avg".PadLeft(20) + "Final Point Med".PadLeft(20));
            for (int i = 0; i < 90; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
            foreach (var sd in s)
            {
                double num = 0.0;
                double count = 0.0;
                foreach (var g in sd.work)
                {
                    num = num + g;
                    count++;
                }
                num = num / count;
                Math.Round(num, 1);
                sd.final = (sd.final + num) / 2;
                Math.Round(sd.final, 1);
                Console.WriteLine(sd.SurName.PadRight(25) + sd.Name.PadRight(25) + num.ToString().PadLeft(20) + sd.final.ToString().PadLeft(20));
            }


        }







    }
}
