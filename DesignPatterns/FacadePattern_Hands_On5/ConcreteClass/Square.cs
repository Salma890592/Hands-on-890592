using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern_Hands_On4.ConcreteClass
{
    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Draw a square");
        }
    }
}
