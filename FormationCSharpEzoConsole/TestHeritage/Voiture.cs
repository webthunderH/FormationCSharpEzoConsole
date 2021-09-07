using System;
using System.Collections.Generic;
using System.Text;

namespace FormationCSharpEzoConsole.TestHeritage
{
    public class Voiture : Vehicules, IVehiculeARoue
    {
        public Voiture(string marque, int roues):base(marque, 5000)
        {
            Roues = roues;
        }

        public int Roues { get ; private set; }
        public int VitesseSurSol { get ; private set; }

        public virtual void AccelerationSurSol(int acceleration)
        {
            VitesseMaximum = 200;
            VitesseSurSol = Accelerer(acceleration);
        }

        

        public void DeccelerationSurSol(int decceleration)
        {
            VitesseSurSol = Decelerer(decceleration);
        }
    }
}
