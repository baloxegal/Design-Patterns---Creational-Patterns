using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Creational_Patterns
{
    class Dog : Animal
    {        
        private Dog()
        {
            Tail = "Small";
        }
        public override Animal GetInstance()
        {
            return new Dog();
        }
    }
}
