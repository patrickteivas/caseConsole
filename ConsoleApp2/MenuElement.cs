using System;

namespace ConsoleApp2
{
    public class MenuElement : BaseElement, ConsoleElement
    {
        private string text;
        private bool isSelected = false;

        public MenuElement(string text, int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            this.text = text;
        }

        public string getMethod()
        {
            return text.ToLower().Replace(" ", "");
        }
        
        public void update()
        {
            
        }

        public void draw()
        {
            if (isDirty)
            {
                if (isSelected)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition(X,Y);
                Console.Write(text);
                Console.ResetColor();
                isDirty = false;
            }
        }

        public void select()
        {
            if (!isSelected)
            {
                isDirty = true;
            }
            isSelected = true;
        }

        public void deSelect()
        {
            if (isSelected)
            {
                isDirty = true;
            }
            isSelected = false;
        }
    }
}