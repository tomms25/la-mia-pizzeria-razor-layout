﻿namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public Pizza(string img, string name, string description, double price)
        {
            Img = img;
            Name = name;
            Description = description;
            Price = price;
        }

        public string Img { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}