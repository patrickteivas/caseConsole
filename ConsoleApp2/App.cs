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
            _elements.Add(new Text("Hello World"));
        }
        
        public void loop()
        {
            while (running)
            {
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
    }
}