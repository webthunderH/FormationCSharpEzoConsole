using FormationCSharpEzoConsole.TestHeritage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormationCSharpEzoConsole.Generics
{
    public class Aeroport<T>
        where T : Vehicules, IVehiculeVolant        
    {
        private List<T> placeDisponible;
        public Aeroport()
        {
            
        }
        public Aeroport(string nom) : this()
        {

        }
        public List<T> PlaceDisponible { 
            get {
                return placeDisponible ?? new List<T>();
            } 
        }

        public T GetAvionDispnible(string marque)
        {
            return PlaceDisponible.FirstOrDefault(f=>f.Marque == marque);
        }

        public bool GetPLaceDisponible(T avion)
        {
            var retour =PlaceDisponible.Count <= 500 ? PlaceDisponible.Count <= 500-1 ? true : false :false;
            return retour;

        }
    }
}
