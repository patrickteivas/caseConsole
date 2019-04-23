using System;
using System.Collections.Generic;
using System.Reflection;

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
            if (key == ConsoleKey.UpArrow)
            {
                if (selectedIndex > 0)
                {
                    selectedIndex--;
                    selectElement();
                    isDirty = true;
                }

                
            }
            if (key == ConsoleKey.DownArrow)
            {
                if (selectedIndex < menuEls.Count-1)
                {
                    selectedIndex++;
                    selectElement();
                    isDirty = true;
                }              
            }

            if (key == ConsoleKey.Enter)
            {
                var methodName = menuEls[selectedIndex].getMethod();
                var method = typeof(MenuActions).GetMethod(methodName);
                method.Invoke(null, null);
            }
        }
        public void addElement(string text)
        {
            menuEls.Add(new MenuElement(text, X, menuEls.Count));
            if (menuEls.Count == 1)
            {
                menuEls[0].select();
            }
        }

        private void selectElement()
        {
            foreach (var el in menuEls)
            {
                el.deSelect();
            }
            menuEls[selectedIndex].select();
        }
    }
}