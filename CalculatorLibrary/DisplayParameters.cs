using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class DisplayParameters
    {
        internal void DisplayMember(int x,int y,int result)
        {
            Console.WriteLine($"{x}  {y} {result}");
        }
    }
}
