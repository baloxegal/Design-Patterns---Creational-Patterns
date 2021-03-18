using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Creational_Patterns
{
    class Dog : Animal
    {        
        public Dog()
        {
            Tail = "Small";
        }
        public override Animal GetInstance()
        {
            return new Dog();
        }
    }
}
