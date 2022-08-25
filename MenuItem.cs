using System;
using System.Collections.Generic
namespace MenuStudio
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool MarkedAsNew { get; set; }
        public double Popularity { get; set; }
        public DateTime ItemCreated { get; set; }
        public DateTime ItemUpdated { get; set; }

        public MenuItem (double price, string title, string description, bool markedAsNew)
        {
            Price = price;
            Title = title;
            Description = description;
            MarkedAsNew = markedAsNew;
        }

        public MenuItem ()
    }
}

