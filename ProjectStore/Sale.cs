using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectStore
{
    public class Sale
    {
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

        public double CalculateSubtotal()
        {
            
        }

        #endregion
    }
}