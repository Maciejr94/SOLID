using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPMain
{
    internal abstract class Animal
    {
        public abstract void Run();
    }

    class Dog : Animal 
    {
        public override void Run()
        {
            Console.WriteLine("Dogs run");
        }
    }

    class Fish : Animal
    {
        public override void Run()
        {
            throw new NotImplementedException();
        }
    }
}
