using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Creational_Patterns
{
    class Horse : Animal
    {        
        public Horse()
        {
            Tail = "Luxurious";
        }
        public override Animal GetInstance()
        {
            return new Horse();
        }
    }
}
