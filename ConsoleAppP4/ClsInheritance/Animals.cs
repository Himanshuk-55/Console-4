using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP4.ClsInheritance
{
    public class Animals
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Animals()
        {
            Name = "Default Name";
        }

        public Animals(string name)
        {
            Name = name;
        }

        public void Walk()
        {
            Console.WriteLine("Walking");
        }

        protected void ProtectedFunction()
        {

        }

        public static Animals operator +(Animals a1, Animals a2)
        {
            var _sumName = a1.Name + " " + a2.Name;
            var _sumLastName = a1.LastName + " " + a2.LastName;
            return new Animals { Name = _sumName, LastName = _sumLastName };
        }
    }

    public class Mammals : Animals
    {
        public Mammals():base("Mammals Name")
        {

        }

        public Mammals(string name):base(name)
        {

        }

        private void MammalsFunction()
        {
            Name = "";
            Walk();
            ProtectedFunction();
        }
    }
}
