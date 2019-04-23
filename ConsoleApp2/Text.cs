using System;

namespace ConsoleApp2
{
    public class Text : BaseElement, ConsoleElement
    {
        private string content;

        public Text(string content)
        {
            this.content = content;
        }
        
        public void update()
        {
            
        }

        public void draw()
        {
            if (isDirty)
            {
                Console.WriteLine(content);
                isDirty = false;
            }
        }
    }
}