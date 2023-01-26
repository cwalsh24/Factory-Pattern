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
        GeometricShape getShape(GeometricShape shape)
        {
            
        }
    }

    class Line : GeometricShape
    {
        draw(); 
    }

    class Circle
    {
        draw(); 
    }

    class Rectangle
    {
        draw(); 
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
