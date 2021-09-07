using System;
using System.Collections.Generic;
using System.Text;

namespace FormationCSharpEzoConsole.TestHeritage
{
    public class Hydravion : Vehicules, IVehiculeARoue, IVehiculeFlotant, IVehiculeVolant
    {
        public Hydravion(string marque):base(marque,5000)
        {

        }
        public int Roues { get; private set; }

        public int VitesseFlottante { get; private set; }

        public bool Flotte { get; private set; }

        public int VitesseEnVol { get; private set; }

        public int VitesseMaximalEnVol { get; private set; }

        public int VitesseSurSol { get; private set; }

        public void AccelerationEnVol(int acceleration)
        {
            VitesseMaximum = 20000;
            VitesseEnVol = Accelerer(acceleration);
        }

        public void AccelerationSurLEau(int acceleration)
        {
            VitesseMaximum = 300;
            VitesseFlottante = Accelerer(acceleration);
        }

        public void AccelerationSurSol(int acceleration)
        {
            VitesseMaximum = 150;
            VitesseSurSol = Accelerer(acceleration);
        }

        public void DeccelerationSurLEau(int decceleration)
        {
            VitesseFlottante = Decelerer(decceleration);
        }

        public void DeccelerationSurSol(int decceleration)
        {
            VitesseSurSol = Decelerer(decceleration);
        }

        public void DecelerationEnVol(int deceleration)
        {
            VitesseEnVol = Decelerer(deceleration);
        }
        
    }
}
