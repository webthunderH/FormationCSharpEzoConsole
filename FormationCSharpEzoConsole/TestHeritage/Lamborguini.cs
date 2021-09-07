using System;
using System.Collections.Generic;
using System.Text;

namespace FormationCSharpEzoConsole.TestHeritage
{
    public class Lamborguini : Voiture
    {
        public Lamborguini() : base("Lamborgini",4)
        {
        }

        public override void AccelerationSurSol(int acceleration)
        {
            Vitesse = Accelerer(acceleration) * 2;
        }
    }
}
