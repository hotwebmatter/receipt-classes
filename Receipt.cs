using System;
using System.Collections.Generic;
using System.Text;

namespace receipt_classes
{
    class Receipt
    {
        // receipt counter
        private static int receiptCounter;
        // data members
        private DateTime dateOfPurchase = new DateTime();
        private int receiptNumber,
                    customerNumber,
                    itemNumber,
                    itemQuantityPurchased;
        private double itemUnitPrice;
        private string customerName,
                       customerAddress,
                       customerPhone,
                       itemDescription;
        // auto-implement properties
        public DateTime DateOfPurchase { set; get; }
        public int ReceiptNumber { set; get; }
        public int CustomerNumber { set; get; }
        public string CustomerName { set; get; }
        public string CustomerAddress { set; get; }
        public string CustomerPhone { set; get; }
        public int ItemNumber { set; get; }
        public int ItemQuantityPurchased { set; get; }
        public double ItemUnitPrice { set; get; }
        public string ItemDescription { set; get; }
        // constructor
        public Receipt()
        {
            dateOfPurchase = DateTime.Now;
            receiptNumber = receiptCounter++;
            customerNumber = 531420;
            customerName = "Joe Doe";
            customerAddress = "123 Shady Lane";
            customerPhone = "+1 (401) 555-1212"
            itemNumber = 9753108642;
            itemQuantityPurchased = 3;
            itemUnitPrice = 1.25;
            itemDescription = "granola bar";
        }
        public double ItemsTotalCost()
        {
            return itemUnitPrice * itemQuantityPurchased;
        }
    }
}
