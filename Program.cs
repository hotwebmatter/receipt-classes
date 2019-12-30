using System;
using static System.Console;

namespace receipt_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Receipt myReceipt = new Receipt();
            WriteLine("{0, 12}{1, 8:C}", "Total Cost:", myReceipt.ItemsTotalCost());
            WriteLine(myReceipt.ToString());
        }
    }
}
