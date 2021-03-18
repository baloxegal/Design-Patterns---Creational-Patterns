using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Creational_Patterns
{
    abstract class Animal
    {
        public string Tail;
        public abstract Animal GetInstance();
    }
}
