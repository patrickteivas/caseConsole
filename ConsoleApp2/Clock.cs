using System;

namespace ConsoleApp2
{
    public class Clock : BaseElement, ConsoleElement
    {

        private DateTime time;

        public Clock()
        {
            X = 10;
            Y = 10;
            height = 1;
            width = DateTime.Now.ToLongTimeString().Length;
        }
        
        public void update()
        {
            if (DateTime.Now.TimeOfDay.Seconds > time.TimeOfDay.Seconds)
            {
                time = DateTime.Now;
                isDirty = true;
            }
        }

        public void draw()
        {
            if (isDirty)
            {
                clear();
                Console.WriteLine(time.ToLongTimeString());
                isDirty = false;
            }
        }
    }
}