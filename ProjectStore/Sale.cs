using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectStore
{
    public class Sale
    {
        //This class will be in charge of calculating the subtotal of the sale.

        #region Properties

        private float subtotal;

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        private List<ItemSale> items = new List<ItemSale>();

        public List<ItemSale> Items
        {
            get { return items; }
            set { items = value; }
        }


        #endregion

        #region Methods

        public void CalculateSubtotal()
        {
            /*This method is responsible for calculating the subtotal of the sale.
             * This "for" is in charge of traversing our list of items. */

            for (int n = 0; n < items.Count; n++)
            {
                /*The following line of code calculates the subtotal of the sale. Calls the return value of the CalculateAmount method,
                 * saves it to our Items list, and stores it in our subtotal property.*/
                subtotal += items[n].CalculateAmount();
            }
        }

        #endregion
    }
}