using System;
using System.Collections.Generic;
using System.Text;

namespace FormationCSharpEzoConsole.TestHeritage
{
    public class Moto : Vehicules, IVehiculeARoue
    {
        public Moto(string marque, int roues):base(marque,1500)
        {
            Roues = roues;
        }

        public int Roues { get; private set; }

        public int VitesseSurSol { get; private set; }

        public void AccelerationSurSol(int acceleration)
        {
            VitesseMaximum = 250;
            VitesseSurSol = Accelerer(acceleration);
        }

      

        public void DeccelerationSurSol(int decceleration)
        {
            VitesseMaximum = 250;
            VitesseSurSol = Decelerer(decceleration);
        }

        
    }
}
