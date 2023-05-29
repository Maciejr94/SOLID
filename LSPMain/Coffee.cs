using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPMain
{
    internal class Coffee
    {
        public virtual void Brew()
        {
            Console.WriteLine("Add coffee to the cup");
            Console.WriteLine("Pour water to the cup");
        }
    }

    class CoffeeLatte : Coffee
    {
        public override void Brew()
        {
            base.Brew();
            Console.WriteLine("Pour milk to the cup");
        }
    }
}
