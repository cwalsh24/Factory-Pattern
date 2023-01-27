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
        public GeometricShape getShape(ShapeType shape)
        {
            switch (shape)
            {
                case ShapeType.Line:
                    return new Line();
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Rectangle:
                    return new Rectangle();
                //case ShapeType.Triangle : 
                //    return null;
                default:
                    Console.WriteLine("Not a choice"); 
                    return null;
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

    class Circle : GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("A Circle has been drawn");
        } 
    }

    class Rectangle : GeometricShape
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
            ShapeFactory factory = new ShapeFactory();
            GeometricShape line = factory.getShape(ShapeType.Line);
            line.draw();

            factory.getShape(ShapeType.Triangle);
            Console.ReadKey();
        }
    }
}
