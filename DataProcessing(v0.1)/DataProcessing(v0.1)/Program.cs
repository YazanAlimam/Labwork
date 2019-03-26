using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessing_v0._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d=new Data();
            
            string input2;
            double r;
            bool IsValid = false;
            string ch = "";
            do
            {
                Student s = new Student();

                Console.WriteLine("Enter Sur Name");
                s.SurName = Console.ReadLine();
                Console.WriteLine("Enter Name");
                s.Name = Console.ReadLine();
                bool lo = true;
                while (lo)
                {
                    
                    do
                    {
                        
                        Console.Write("Enter the Home Work Number: ");
                        input2 = Console.ReadLine();
                        IsValid = double.TryParse(input2, out r);
                    } while (!IsValid || r < 0);
                    s.work.Add(r);
                    Console.WriteLine("Enter 'Y' For More Else 'N' ");
                    String sds = Console.ReadLine();
                    if(sds.ToUpper().CompareTo("N")==0)
                    { lo = false; }
                }
                do
                {
                    Console.Write("Enter the Final Number: ");
                    input2 = Console.ReadLine();
                    IsValid = double.TryParse(input2, out r);

                } while (!IsValid && r < 0);
                s.final=r;
                Console.WriteLine("Do You Want to Enter More Students [Y/N]");
                ch = Console.ReadLine();
                d.add(s);
            } while (ch.ToUpper().CompareTo("N") != 0);

            d.display();


            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("%%%%%%%%%%%%%%%%%% Random Data %%%%%%%%%%%%%%%%%%%");
            Data dd = new Data();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Random ran = new Random();
            for(int i=1;i<=5;i++)
            {
                Student s = new Student();
                s.SurName = "Surname" + i;
                s.Name = "Name" + i;
                for (int j = 0; j < 5; j++)
                {
                    s.work.Add(Math.Round(ran.NextDouble() * (30 - 0) + 0, 1));
                }
                s.final = Math.Round(ran.NextDouble() * (30 - 0) + 0,1);
                dd.add(s);
            }
            dd.display();

        }

        

      
    }
}
