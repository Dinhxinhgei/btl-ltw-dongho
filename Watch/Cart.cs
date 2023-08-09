using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Watch
{
    public class Cart
    {
        private string username;
        private int productId;
        private int quantity;

        public Cart()
        {
        }

        public Cart(string username, int productId, int quantity)
        {
            this.Username = username;
            this.ProductId = productId;
            this.Quantity = quantity;
        }

        public string Username { get => username; set => username = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}