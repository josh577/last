using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person1
    {
        string fname;

        public string Fname
        {
            get
            {
                return fname;
            }

            set
            {
                fname = value;
            }
        }


        public Person1(string _fname)
        {
            Fname = _fname;
        }
    }


}
