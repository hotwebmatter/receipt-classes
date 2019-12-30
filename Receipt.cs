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
    }
}
