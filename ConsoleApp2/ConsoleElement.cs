using System;

namespace ConsoleApp2
{
    public interface ConsoleElement
    {
        void update();
        void draw();

        void input(ConsoleKey key);
    }
}