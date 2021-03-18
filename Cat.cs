using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Creational_Patterns
{
    class Cat : Animal
    {        
        private Cat()
        {
            Tail = "long";
        }        
        public override Animal GetInstance()
        {
            return new Cat();
        }
    }
}
