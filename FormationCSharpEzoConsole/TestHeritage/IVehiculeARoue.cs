using System;
using System.Collections.Generic;
using System.Text;

namespace FormationCSharpEzoConsole.TestHeritage
{
    public interface IVehiculeARoue
    {
        public int Roues { get; }
        public int VitesseSurSol { get; }
        

        void AccelerationSurSol(int acceleration);
        void DeccelerationSurSol(int decceleration);

    }
}
