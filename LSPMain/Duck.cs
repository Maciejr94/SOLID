using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPMain
{
    internal abstract class Duck
    {
        public abstract void Swim();
        public abstract void Quack();
        public abstract void Fly();
    }

    class CityDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("City duck quack");
        }

        public override void Swim()
        {
            Console.WriteLine("City duck swim");
        }

        public override void Fly()
        {
            Console.WriteLine("City duck flies");
        }
    }

    class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Rubber duck quack");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim duck quack");
        }

        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
