using System;

namespace Design_Patterns___Creational_Patterns
{
    sealed class PassangerProfile : Profile
    {
        ////First, Second and Thread Attempt
        //static PassangerProfile _passangerProf = null;
        ////First Attempt       
        //public static PassangerProfile PassangerProf
        //{
        //    get
        //    {
        //        if (_passangerProf == null)
        //            _passangerProf = new PassangerProfile();
        //        return _passangerProf;
        //    }
        //}

        //// Second and Thread Attempt
        //static readonly object threadLock = new object();

        //// Second Attempt
        //public static PassangerProfile PassangerProf
        //{
        //    get
        //    {
        //        lock (threadLock)
        //        {
        //            if (_passangerProf == null)
        //                _passangerProf = new PassangerProfile();
        //            return _passangerProf;
        //        }                
        //    }
        //}

        //// Theard Attempt
        //public static PassangerProfile PassangerProf
        //{
        //    get
        //    {
        //        if (_passangerProf == null)
        //        {
        //            lock (threadLock)
        //            {
        //                if (_passangerProf == null)
        //                    _passangerProf = new PassangerProfile();
        //                return _passangerProf;
        //            }
        //        }
        //        return _passangerProf;
        //    }
        //}      

        //Four Attempt
        static readonly PassangerProfile _passangerProfile = new PassangerProfile();
        static PassangerProfile()
        {

        }
        public static PassangerProfile PassangerProf { get => _passangerProfile; }

        private PassangerProfile()
        {

        }
        public int Seats { get; set; } = 0;
        public int Tickets { get; set; } = 0;
        public new void Rout()
        {
            base.Rout();
            Console.WriteLine("to Tiraspol station");
        }
        public override string ToString()
        {
            return "passanger";
        }
    }
}
