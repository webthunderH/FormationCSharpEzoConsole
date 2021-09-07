using FormationCSharpEzoConsole.TestHeritage;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormationCSharpEzoConsole.Generics
{
    public class Marina<T> 
        where T : IVehiculeFlotant
    {
        public List<T> PlaceDisponible { get; set; }
    }
}
