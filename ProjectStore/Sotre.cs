using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectStore
{
    public class Sotre
    {
        //This class is the one that will be in charge of calculating the total collection.

        #region Properties

        private float totalcollection;

        public float TotalCollection
        {
            get { return totalcollection; }
            set { totalcollection = value; }
        }

        private List<Sale> sales = new List<Sale>();

        public List<Sale> Sales
        {
            get { return sales; }
            set { sales = value; }
        }

        #endregion

        #region Methods

        public void CalculateTotalCollection()
        {
            /*This method is responsible for calculating the total collection.
             *This "for" is in charge of traversing the sales list.*/

            for (int n = 0; n < sales.Count; n++)
            {
                sales[n].CalculateSubtotal();
                totalcollection += sales[n].Subtotal;
            }
        }

        #endregion

    }
}