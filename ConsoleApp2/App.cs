using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class App
    {
        public bool running = true;
        List<ConsoleElement> _elements = new List<ConsoleElement>();

        public App()
        {
            var menu = new Menu();
            menu.addElement("Element 1");
            menu.addElement("Element 2");
            menu.addElement("Element 3");
            _elements.Add(menu);
        }
        
        public void loop()
        {
            while (running)
            {
                input();
                update();
                draw();
            }
        }

        public void update()
        {
            foreach (var el in _elements)
            {
                el.update();
            }
        }

        public void draw()
        {
            foreach (var el in _elements)
            {
                el.draw();
            }
        }

        public void input()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                foreach (var el in _elements)
                {
                    el.input(key);
                }
            }
        }
    }
}