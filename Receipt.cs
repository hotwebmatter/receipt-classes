using System;
using System.Collections.Generic;
using System.Text;

namespace receipt_classes
{
    class Receipt
    {
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
        public int ItemNumber { set; get; }
        public int ItemQuantityPurchased { set; get; }
        public double ItemUnitPrice { set; get; }
        public string CustomerName { set; get; }
        public string CustomerAddress { set; get; }
        public string CustomerPhone { set; get; }
        public string ItemDescription { set; get; }
    }
}
