using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Creational_Patterns
{
    class AnimalFactory
    {
        private Cat cat = new Cat();
        private Dog dog = new Dog();
        private Horse horse = new Horse();
        
        private static readonly Lazy<AnimalFactory> _getAnimalFactory = new Lazy<AnimalFactory>(() => new AnimalFactory(), true);
        public static AnimalFactory GetAnimalFactory { get; } = _getAnimalFactory.Value;
        private AnimalFactory()
        {

        }
        public Animal GetAnimalInstance(string property)
        {
            if (property.Equals("cat"))
                return cat.GetInstance();
            if (property.Equals("dog"))
                return dog.GetInstance();
            if (property.Equals("horse"))
                return horse.GetInstance();
            return null;
        }
    }
}
