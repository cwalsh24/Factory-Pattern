using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface GeometricShape
    {
        void draw(); 
    }
    public class ShapeFactory
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
                default:
                    return null;
            }
        }
    }

    public class Line : GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("A Line has been drawn");    
        }
    }

    public class Circle : GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("A Circle has been drawn");
        } 
    }

    public class Rectangle : GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("A Rectangle has been drawn");
        }
    }

    public enum ShapeType
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
            foreach (ShapeType shape in Enum.GetValues(typeof(ShapeType)))
            {
                if (factory.getShape(shape) == null)
                {
                    Console.WriteLine("Not a choice");
                }
                else
                {
                    factory.getShape(shape).draw();
                }
            }
            Console.ReadKey();
        }
    }
}
