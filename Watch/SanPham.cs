using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Watch
{
    public class SanPham
    {
        string name, color, images, detail,type;
        int id;
        double price;

        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public string Images { get => images; set => images = value; }
        public string Detail { get => detail; set => detail = value; }
        public string Type { get => type; set => type = value; }
        public int Id { get => id; set => id = value; }
        public double Price { get => price; set => price = value; }
    }
}