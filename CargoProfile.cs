using System;

namespace Design_Patterns___Creational_Patterns
{
    sealed class CargoProfile : Profile
    {
        //Sixth Attempt 
        private static readonly Lazy<CargoProfile> cargoProf = new Lazy<CargoProfile>(() => new CargoProfile(), true);
        public static CargoProfile CargoProf { get => cargoProf.Value; }
        private CargoProfile()
        {
        }
        public int CargoCapacity { get; set; }
        public int Carry { get; set; }
        public new void Rout()
        {
            base.Rout();
            Console.WriteLine("to Covoare Ungheni");
        }
        public override string ToString()
        {
            return "cargo";
        }
    }
}
