/**
 * @file Program.cs
 * @author Connor Walsh
 * @date 2023-1-31
 * @brief factory pattern driver
 * 
 * This is the driver for the FactoryPattern program. It contains a loop that tests the functionality 
 * of the shape classes.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
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
