using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcu123lator
{
     internal class Calculator
     {
          static void Main(string[] args)
          {
               Console.WriteLine("10 to decimal {0}.", Convert.ToString(10, 2));  //от двуична в десетична бройна система, 10 става 2
               Console.WriteLine("2 to binary {0}.", Convert.ToString(2, 10));    //от десетична в двуична бройна система, 2 става 10
          }

     }
}

