using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class CalculationLogic
    {
        DisplayParameters dis = new DisplayParameters();
        public int Add(int x, int y)
        {
            dis.DisplayMember(x, y, x + y);
            return x + y;
        }

        public int Subtract(int x,int y)
        {
            dis.DisplayMember(x, y, x - y);
            return x - y;
        }

        
    }
}
