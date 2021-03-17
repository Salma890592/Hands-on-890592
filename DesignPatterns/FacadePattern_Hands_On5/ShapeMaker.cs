using System;
using System.Collections.Generic;
using System.Text;
using FacadePattern_Hands_On4.ConcreteClass;

namespace FacadePattern_Hands_On4
{
    public class ShapeMaker
    {
        private IShape circle;
        private IShape rectangle;
             private IShape square;
        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }
        public void drawCircle()
        {
            circle.draw();
        }
        public void drawRectangle()
        {
            rectangle.draw();
        }
            public void drawSquare()
            {
                square.draw();
            }
        }
    }

