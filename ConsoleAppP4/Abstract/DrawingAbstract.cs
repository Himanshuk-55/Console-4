using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP4.Abstract
{
    public abstract class DrawingAbstract
    {
        public abstract double Area();

        public abstract void TakeInput();

        public void Display()
        {
            Console.WriteLine("Display called from Drawing abstract class");
        }
    }

    public class CircleAbs : DrawingAbstract
    {
        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override void TakeInput()
        {
            throw new NotImplementedException();
        }
    }
}
