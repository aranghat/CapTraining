using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//Numbers
            sbyte sByte = 0; //8bit signed value
            Console.WriteLine("SBYTE : MIN {0}  - MAX {1}", sbyte.MinValue
                , sbyte.MaxValue);

            Console.WriteLine("BYTE : MIN {0}  - MAX {1}", byte.MinValue
                , byte.MaxValue);

            //short - 16 bit
            Console.WriteLine("SHORT  : MIN {0}  - MAX {1}", short.MinValue
                , short.MaxValue);

            Console.WriteLine("USHORT  : MIN {0}  - MAX {1}", ushort.MinValue
                , ushort.MaxValue);
            //int - 32
            Console.WriteLine("INT  : MIN {0}  - MAX {1}", int.MinValue
                , int.MaxValue);

            Console.WriteLine("UINT  : MIN {0}  - MAX {1}", uint.MinValue
                , uint.MaxValue);

            //long - 64
            Console.WriteLine("LONG  : MIN {0}  - MAX {1}", long.MinValue
                , long.MaxValue);

            Console.WriteLine("ULONG  : MIN {0}  - MAX {1}", ulong.MinValue
                , ulong.MaxValue);

            //Decimal Point Numbers
            float floatType = .0123456789F; //4 byte 6-9 decimal places
            Console.WriteLine("Float Data " + floatType);

            double dobleType = .01234567890123456789;//8 byte 15-17 decimal places
            Console.WriteLine("Float Data " + dobleType);

            decimal decimalType = .012345678901234567890123456789M; // 16byte 28 - 29 decimal palces'
            Console.WriteLine("Decimal Type : " + decimalType);
            //String & Character
            string str = "Hello World";

            char charDataType = 'H';

            //Boolean
            bool isUserActive = true;
            bool isDisabled   = false;
        }
	}
}
