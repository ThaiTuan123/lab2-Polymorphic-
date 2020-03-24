using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog:Animals
    {
        public Dog(string name,string favouriteFood) : base(name, favouriteFood)
        {

        }
        public override string ExplainSelf()
        {
            Console.WriteLine("DJAAF");
            return base.ExplainSelf(); ;
        }
    }
}
