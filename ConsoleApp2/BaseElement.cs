using System;

namespace ConsoleApp2
{
    public class BaseElement : ConsoleElement
    {
        protected int X;
        protected int Y;
        protected int height;
        protected int width;
        protected bool isDirty = true;
        public BaseElement()
        {
            
        }

        public void update()
        {
            
        }
        
        public void draw()
        {
            
        }

        public void input(ConsoleKey key)
        {
            
        }
        protected void clear()
        {
            Console.ResetColor();
            for (int i = X; i < X + width; i++)
            {
                for (int j = Y; j < Y + height; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(" ");
                }
            }
            Console.SetCursorPosition(X, Y);
        }
        
        protected void fill()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = X; i < X + width; i++)
            {
                for (int j = Y; j < Y + height; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(" ");
                }
            }
        }
    }
}