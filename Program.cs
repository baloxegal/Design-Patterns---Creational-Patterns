using System;

namespace Design_Patterns___Creational_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable typeFly = new Fly();
            Profile cargoProfile = CargoProfile.CargoProf;
            Car<Profile, IMoveable> car1 = new Car<Profile, IMoveable>(cargoProfile, typeFly, Fuel.DIESEL, "Big Trailer");
            car1.Registry = "CVB 825";
            car1.TypeMove.MoveRight();
            ((IFlyable)car1.TypeMove).MoveUp();
            var a = car1.Profile as CargoProfile;
            a.CargoCapacity = 5000;
            a.Carry = 4900;
            a.Rout();

            var cargoProf = cargoProfile as CargoProfile;
            Console.WriteLine(cargoProf.CargoCapacity);
            cargoProf.CargoCapacity = 1000;
            Console.WriteLine(cargoProf.CargoCapacity);
            Profile cargoProfile_1 = CargoProfile.CargoProf;
            var cargoProf_1 = cargoProfile_1 as CargoProfile;
            Console.WriteLine(cargoProf_1.CargoCapacity);
            cargoProf_1.CargoCapacity = 2000;
            Console.WriteLine(cargoProf_1.CargoCapacity);
            Console.WriteLine(cargoProf.CargoCapacity);
            Console.WriteLine(cargoProf_1.CargoCapacity);
            if (cargoProf.Equals(cargoProf_1))
            {
                Console.WriteLine("Singleton");
            }

            Profile passangerProfile = PassangerProfile.PassangerProf;
            var pasProf = passangerProfile as PassangerProfile;
            Console.WriteLine(pasProf.Seats);
            pasProf.Seats = 100;
            Console.WriteLine(pasProf.Seats);
            Profile passangerProfile_1 = PassangerProfile.PassangerProf;
            var pasProf_1 = passangerProfile_1 as PassangerProfile;
            Console.WriteLine(pasProf_1.Seats);
            pasProf.Seats = 20;            
            Console.WriteLine(pasProf.Seats);
            Console.WriteLine(pasProf_1.Seats);
            if (pasProf.Equals(pasProf_1))
            {
                Console.WriteLine("Singleton");
            }

            Profile cargoPassangerProfile = CargoPassangerProfile.CargoPassangerProf;
            var cargoPasProf = cargoPassangerProfile as CargoPassangerProfile;
            Console.WriteLine(cargoPasProf.PassangerProfile.Seats);
            pasProf.Seats = 50;
            Console.WriteLine(cargoPasProf.PassangerProfile.Seats);
            Profile cargoPassangerProfile_1 = CargoPassangerProfile.CargoPassangerProf;
            var cargoPasProf_1 = cargoPassangerProfile_1 as CargoPassangerProfile;
            Console.WriteLine(cargoPasProf_1.PassangerProfile.Seats);
            pasProf.Seats = 10;
            Console.WriteLine(cargoPasProf.PassangerProfile.Seats);
            Console.WriteLine(cargoPasProf_1.PassangerProfile.Seats);
            if (cargoPasProf.Equals(cargoPasProf_1))
            {
                Console.WriteLine("Singleton");
            }

            IMoveable typeMove = new Move();
            Car<Profile, IMoveable> car2 = new Car<Profile, IMoveable>(passangerProfile, typeMove, Fuel.PETROL);
            car2.Registry = "CMU 999";

            car2.TypeMove.MoveRight();
            car2.TypeMove.MoveLeft();
            ((PassangerProfile)car2.Profile).Seats = 50;
            ((PassangerProfile)car2.Profile).Tickets = 40;
            ((PassangerProfile)car2.Profile).Rout();

            CarParkService<Car<Profile, IMoveable>, Destination, Driver> carPark = new CarParkService<Car<Profile, IMoveable>, Destination, Driver>(10);

            carPark.park[0] = car1;
            carPark.park[1] = car2;

            for (var i = 2; i < carPark.park.Length; i++)
            {
                if (i % 2 == 0 && (i != 6 && i != 8))
                    carPark.park[i] = new Car<Profile, IMoveable>(cargoProfile, typeFly, Fuel.DIESEL, "Big Trailer");
                else if (i == 6 || i == 8)
                    carPark.park[i] = new Car<Profile, IMoveable>(CargoPassangerProfile.CargoPassangerProf, typeFly, Fuel.GAS, "Small Trailer");
                else
                    carPark.park[i] = new Car<Profile, IMoveable>(passangerProfile, typeMove, Fuel.PETROL);
            }           

            foreach (var c in carPark.park)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("=============================================");

            //AnimalFactory

            var animalFactory = AnimalFactory.GetAnimalFactory;// Singleton for AnimalFactory object

            var catAnimal = animalFactory.GetAnimalInstance("cat");         //Create objects with AnimalFactory
            var dogAnimal = animalFactory.GetAnimalInstance("dog");
            var horseAnimal = animalFactory.GetAnimalInstance("horse");

            //Cat c = new Cat(); // Access don't permitted
            //Cat d;
            //d.GetInstance(); // Use unsigned local - interdicted
                       
            var cat = catAnimal as Cat;
            var dog = dogAnimal as Dog;
            var horse = horseAnimal as Horse;

            //This is a problem.  And problem in unforeseen injection in other classes
            var problemCat = cat.GetInstance();           
        }
    }
}
