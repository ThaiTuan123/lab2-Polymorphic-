﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animals
    {
        private string name;
        private string favouriteFood;

        public Animals (String name,string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }
        public virtual string ExplainSelf()
        {
            return "I am " + this.name + "and my favourite food is" + this.favouriteFood;
        }

    }
}
