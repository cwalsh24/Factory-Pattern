using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    interface GeometricShape
    {
        void draw(); 
    }
    class ShapeFactory
    {
        GeometricShape getShape(ShapeType shape)
        {
            switch (shape)
            {
                case ShapeType.Line:
                    return new Line();//shape = new Line();
                case ShapeType.Circle:
                    return new Circle();
                   //break; 
                //case 
                //return null; 
            }
        }
    }

    class Line : GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("A Line has been drawn");    
        }
    }

    class Circle
    {
        public void draw()
        {
            Console.WriteLine("A Circle has been drawn");
        } 
    }

    class Rectangle
    {
        public void draw()
        {
            Console.WriteLine("A Rectangle has been drawn");
        }
    }

    enum ShapeType
    {
        Line,
        Circle,
        Rectangle, 
        Triangle,
    }

    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
