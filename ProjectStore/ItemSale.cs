using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectStore
{
    public class ItemSale
    {

        //This class is the one that allows to use several products of the same type at the same time.

        #region Properties

        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private Product item;

        public Product Item
        {
            get { return item; }
            set { item = value; }
        }

        public string Desc
        {

            //This property is responsible for concatenating the name plus the price in the items listbox.

            get
            {
                return item.Name + "$" + (amount * item.Price).ToString();
            }

        }


        #endregion

        #region Methods

        public float CalculateAmount()
        {

            //This method is responsible for calculating the quantity of products for the price of the product.

            return amount * item.Price;

        }

        #endregion

    }
}