using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppP4;
using ConsoleAppP4.ClsInheritance;
using Interfaces = ConsoleAppP4.Interface;

namespace ConsoleAppP4
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = "y";

            do
            {
                Console.WriteLine("Hello!!!\n-----------------------------------------");

                //InheritanceExample();

                //Console.WriteLine("\nOperator Overloading\n------------------------------");
                //OperatorOverloadingExample();

                //Console.WriteLine("\nFactory Interface Example\n------------------------------");
                //FactoryInterfaceExample();

                //Console.WriteLine("\nMissing Number is:\n-----------------------------------");
                //FindMissingNumber();

                Console.WriteLine("\nDisplay Queue :\n-----------------------------------");
                DisplayQueue();

                Console.WriteLine("Want to try more...(y/n)?");
                result = Console.ReadLine();

            } while (result == "y" || result == "Y");

            Console.ReadLine();
        }

        private static void FindMissingNumber()
        {
            int[] a = { 1, 3, 4, 5, 6, 7 };
            int missNum = getMissingNumber(a, 5);
            Console.WriteLine(missNum);
        }

        private static int getMissingNumber(int[] a, int n)
        {
            int total = (n + 1) * (n + 2) / 2;
            for (int i = 0; i < n; i++)
            {
                total -= a[i];
            }
            return total;
        }
        
        static void InheritanceExample()
        {
            Animals animal = new Animals();
            var name = animal.Name;
            Console.WriteLine(name);

            var AnimalTwo = new Animals("Homo Sapiens");
            Console.WriteLine(AnimalTwo.Name);

            Mammals mammals = new Mammals();
            Console.WriteLine(mammals.Name);
        }

        private static void OperatorOverloadingExample()
        {
            var a1 = new Animals();
            a1.Name = "Dog";
            a1.LastName = "Gates";

            var a2 = new Animals();
            a2.Name = "Cat";
            a2.LastName = "Gates";

            var str = a1 + a2;

            Console.WriteLine("Final firstname => " + str.Name);
            Console.WriteLine("Final lastname => " + str.LastName);
        }

        public static void FactoryInterfaceExample()
        {
            Console.WriteLine("1. Circle\n2. Square\n3. Rectangle");

            var choice = Convert.ToInt32(Console.ReadLine());
            Interfaces.IDrawing drawingObj = null;

            switch(choice)
            {
                case 1:
                    drawingObj = new Interfaces.Circle();
                    break;
                case 2:
                    Console.WriteLine("Not found");
                    break;
                case 3:
                    Console.WriteLine("Not found");
                    break;
                default:
                    return;
                    break;
            }

            drawingObj.TakeInput();
            Console.WriteLine("Area = >" + drawingObj.Area());
            Console.WriteLine("Perimeter =>" + drawingObj.Perimeter());
        }

        public static void DisplayQueue()
        {
            StackAndQueue.ObjQueue Q = new StackAndQueue.ObjQueue(6);
            Q.Enqueue(0);
            Q.Enqueue(1);
            Q.Enqueue(2);
            Q.Enqueue(3);
            Q.Enqueue(4);
            Q.Enqueue(5);
            Q.PrintQueue();
            Q.Dequeue();
        }

        public static void AbstractExample()
        {
            //Abstract.DrawingAbstract
        }

        //static void ArrayExample()
        //{
        //    int[] arryInt = new int[2];
        //}
    }
}
