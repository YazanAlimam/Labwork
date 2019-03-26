using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace DataProcessing_v0._3_
{
    class Program
    {

        static void Main(string[] args)
        {

            Data d = new Data();

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
                    if (sds.ToUpper().CompareTo("N") == 0)
                    { lo = false; }
                }
                do
                {
                    Console.Write("Enter the Final Number: ");
                    input2 = Console.ReadLine();
                    IsValid = double.TryParse(input2, out r);

                } while (!IsValid && r < 0);
                s.final = r;
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
            for (int i = 1; i <= 5; i++)
            {
                Student s = new Student();
                s.SurName = "Surname" + i;
                s.Name = "Name" + i;
                for (int j = 0; j < 5; j++)
                {
                    s.work.Add(Math.Round(ran.NextDouble() * (30 - 0) + 0, 1));
                }
                s.final = Math.Round(ran.NextDouble() * (30 - 0) + 0, 1);
                dd.add(s);
            }
            dd.display();



            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("%%%%%%%%%%%%%%%%%% Read From File %%%%%%%%%%%%%%%%%%%");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Data rff = new Data();
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("Data.txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {

                    String[] studentData = line.Split(' ');

                    Student sd = new Student();
                    sd.SurName = studentData[0];
                    sd.Name = studentData[1];

                    for (int i = 2; i < 7; i++)
                    {
                        double rr;
                        bool ijg = double.TryParse(studentData[i], out rr);
                        if (!ijg)
                        {
                            rr = 0.0;

                        }
                        sd.work.Add(rr);
                    }
                   
                    bool ij = double.TryParse(studentData[7], out r);
                    if (!ij)
                    {
                        r = 0.0;

                    }
                    sd.final = r;
                    rff.add(sd);
                    //write the lie to console window
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }



            rff.display();


        }


    }
}