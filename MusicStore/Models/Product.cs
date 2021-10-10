using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Product
    {
        private string title;
        public string Title
        {
            set { title = value; }
            get { return title; }


        }

        private decimal price; // field
        public decimal Price // property
        {
            // 
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }

        public string ImageUrl { get; set; }


        private string manufacturer;
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public Product(string title, decimal price, string imageUrl)
        {
            this.title = title;
            this.price = price;
            ImageUrl = imageUrl;
        }

        public Product(string title, decimal price)
        {
            this.title = title;
            this.price = price;
        }
    }

}