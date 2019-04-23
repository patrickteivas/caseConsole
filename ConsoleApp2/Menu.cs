using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Menu : BaseElement, ConsoleElement
    {
        private List<MenuElement> menuEls = new List<MenuElement>();
        private int selectedIndex = 0;

        public Menu()
        {
            
        }
        
        public void update()
        {
            
        }

        public void draw()
        {
            if (isDirty)
            {
                foreach (var el in menuEls)
                {
                    el.draw();
                }
                isDirty = false;
            }
        }

        public void input(ConsoleKey key)
        {
            if (key == ConsoleKey.PageUp)
            {
                selectedIndex--;
                selectElement();
            }
            if (key == ConsoleKey.PageDown)
            {
                selectedIndex++;
                selectElement();
            }
        }
        
        public void addElement(string text)
        {
            menuEls.Add(new MenuElement(text, X, menuEls.Count));
            if (menuEls.Count == 1)
            {
                menuEls[0].setSelected();
            }
        }
    }
}