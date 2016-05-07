using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICCTest
{
    //Another test
    public class Multiples
    {
        
        public string multiplesThree()
        {
            string numbers = "";
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    numbers = numbers + i + " ";
                }
            }
            return numbers;
        }

        public string multiplesFive()
        {
            string numbers = "";
            for (int i = 0; i <= 100; i++)
            {
               if (i % 5 == 0)
                {
                    numbers = numbers + i + " ";
                }
            }
            return numbers;
        }

        public string multiplesFiveAndThree()
        {
            string numbers = "";

            for (int i = 0; i <= 100; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    numbers = numbers + i + " ";
                }

            }
            return numbers;
        }
    }
}
