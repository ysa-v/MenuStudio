using System;
using System.Collections.Generic;

namespace MenuStudio
{
    public class Menu
    {
        Dictionary<double,string> ItemsPriceList { get; set; }
        List<MenuItem> FullMenu { get; set; }
        List<string> CategoryOrder { get; set; }
        DateTime MenuLastUpdated { get; set; }
        int NumberOfNewItems { get; set; }

        public Menu(List<MenuItem> fullMenu)
        {
            FullMenu = fullMenu;
        }

        public void AddMenuItem(MenuItem item)
        {
            if (FullMenu.Contains(item))
            {
                return;
            } else
            {
                FullMenu.Add(item);
            }
        }

        public void RemoveMenuItem(MenuItem item)
        {
            FullMenu.Remove(item);
        }

        public void IsNew (List<MenuItem> FullMenu)
        {
            List<MenuItem> newItems = FullMenu.Where(x => x.MarkedAsNew == true).ToList();
        }

        public void MenuLastUpdatedMethod ()
        {
            Console.WriteLine("Menu Last Updated: " + MenuLastUpdated);
        }
    }
}

