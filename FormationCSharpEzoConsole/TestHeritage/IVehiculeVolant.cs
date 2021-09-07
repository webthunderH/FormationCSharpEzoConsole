using System;
using System.Collections.Generic;
using System.Text;

namespace FormationCSharpEzoConsole.TestHeritage
{
    public interface IVehiculeVolant
    {
        public int VitesseEnVol { get; }
        public int VitesseMaximalEnVol { get; }

        void AccelerationEnVol(int acceleration);
        void DecelerationEnVol(int deceleration);
    }
}
