using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP4.Interface
{
    public interface IArea
    {
        double Area();
    }

    public interface IPerimeter
    {
        double Perimeter();
    }

    public interface IDrawing : IArea, IPerimeter
    {
        void TakeInput();
    }

    public class Circle : IDrawing
    {
        private double _radius;

        public double Area()
        {
            return 3.14 * _radius * _radius;
        }

        public double Perimeter()
        {
            return 2 * 3.14 * _radius;
        }

        public void TakeInput()
        {
            Console.WriteLine("Enter Radius");
            _radius = Convert.ToDouble(Console.ReadLine());
        }
    }
}
