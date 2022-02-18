using ColorConsole;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.UPCA
                , "038000356216", Color.Black
                , Color.White, 290, 120);

            img.Save(@"D:\CapTraining\MyBarCode.jpg", ImageFormat.Jpeg);

            ConsoleWriter console = new ConsoleWriter();
            console.SetBackGroundColor(ConsoleColor.Green);
            console.WriteLine("Bar code is generated"
                , ConsoleColor.Yellow);
        }
    }
}
