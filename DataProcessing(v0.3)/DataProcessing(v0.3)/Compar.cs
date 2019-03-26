using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessing_v0._3_
{
    class Compar : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.SurName == null || y.SurName == null)
            {
                return 0;
            }

            // "CompareTo()" method 
            return x.SurName.CompareTo(y.SurName);

        }
    }
}
