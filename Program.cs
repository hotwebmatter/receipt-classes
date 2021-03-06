﻿using System;
using static System.Console;

namespace receipt_classes
{
    class Program
    {
        // receipt counter
        private static int receiptCounter = 9999;
        static void Main(string[] args)
        {
            Receipt aReceipt = new Receipt(receiptCounter++);
            Receipt bReceipt = new Receipt(receiptCounter++, 642753, "Jean Bleu", "42 Old Road", "401-555-2424", 86427531, 7, 1.33, "candy bar");
            WriteLine("{0, 12}{1, 8:C}", "Total Cost:", aReceipt.ItemsTotalCost());
            WriteLine("{0}\n", aReceipt.ToString());
            WriteLine("{0, 12}{1, 8:C}", "Total Cost:", bReceipt.ItemsTotalCost());
            WriteLine("{0}\n", bReceipt.ToString());
        }
    }
}
