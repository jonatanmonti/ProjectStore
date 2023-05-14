using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectStore
{
    public class ItemSale
    {

        #region Properties

        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private List<Product> products = new List<Product>();

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        #endregion

    }
}