using FormationCSharpEzoConsole.TestHeritage;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormationCSharpEzoConsole.Generics
{
    public class Stationnement<T> where T : IVehiculeARoue
    {
        public List<T> PlacesDisponible { get; set; }
    }
}
