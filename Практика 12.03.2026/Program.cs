using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class Animal
    {
        private int _id;

        // Abstract property
        public abstract string Type { get; }

        public Animal(int id)
        {
            _id = id;
        }

        // Abstract method
        public abstract void Voice();

        public virtual void Print()
        {
            Console.WriteLine("Animal ID " + _id);
        }
    }

    public class Cat : Animal
    {
        public override string Type
        {
            get
            {
                return "Кошка";
            }
        }
        // public override string Type => "Кошка";

        public Cat(int id) : base(id) { }

        public override void Voice()
        {
            Console.WriteLine("Meow");
        }
    }
}
