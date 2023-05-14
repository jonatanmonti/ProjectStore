using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectStore
{
    public class Product
    {

        #region Properties

        private string barcode;

		public string Barcode
		{
			get { return barcode; }
			set { barcode = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string description;

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

        #endregion
    }
}