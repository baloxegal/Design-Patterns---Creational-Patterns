using System;

namespace Design_Patterns___Creational_Patterns
{
    sealed class CargoPassangerProfile : Profile
    {
        public CargoProfile CargoProfile { get; } = CargoProfile.CargoProf;
        public PassangerProfile PassangerProfile { get; } = PassangerProfile.PassangerProf;

        //Fifth Attempt
        private CargoPassangerProfile()
        {

        }
        public static CargoPassangerProfile CargoPassangerProf { get => Nested.cargoPassangerProfile; }       
        private class Nested
        {
            internal static readonly CargoPassangerProfile cargoPassangerProfile = new CargoPassangerProfile();
            static Nested()
            {
            }           
        }
        public new void Rout()
        {
            base.Rout();
            Console.WriteLine("to Bucuresti airport with Cargo");
        }
        public override string ToString()
        {
            return "cargo - passanger";
        }
    }
}
