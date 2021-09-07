using System;
using System.Collections.Generic;
using System.Text;

namespace FormationCSharpEzoConsole.TestHeritage
{
    public interface IVehiculeFlotant
    {
        public int VitesseFlottante { get; }
        public bool Flotte { get; }

        void AccelerationSurLEau(int acceleration);
        void DeccelerationSurLEau(int decceleration);
    }
}
