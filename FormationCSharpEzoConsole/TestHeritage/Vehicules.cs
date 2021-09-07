using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FormationCSharpEzoConsole.TestHeritage
{
    public abstract class Vehicules 
    {
                
        public Vehicules(string Marque, int Poid)
        {
            this.Marque = Marque;
            this.Poid = Poid;
        }
        public int Poid { get; private set; }
        public int VitesseMaximum { get; set; }
        public int VitesseMinimum
        {
            get
            {
                return 0;
            }
        }
        public string Marque { get; private set; }
        public int Vitesse { get; set; }
        public bool Arret { get; private set; }
        public bool EnAction { get; private set; }

        public int Accelerer(int acceleration)
        {
            if (Arret)
            {
                EnAction = !Arret;
                Arret = !EnAction;
            }
            Vitesse = VitesseMaximum >= Vitesse + acceleration ? Vitesse += acceleration : VitesseMaximum;
            
            return Vitesse;
        }
        public int Decelerer(int deceleration)
        {
            if (EnAction && VitesseMinimum <= Vitesse - deceleration)
            {
                EnAction = !Arret;
                Arret = !EnAction;
            }
            Vitesse = VitesseMinimum <= Vitesse - deceleration ? Vitesse -= deceleration : VitesseMinimum;
            return Vitesse;
        }

        public static Vehicules operator +(Vehicules a) => a;
        public static Vehicules operator -(Vehicules a) => throw new NotImplementedException();
        public static Vehicules operator +(Vehicules a, Vehicules b) => new Voiture(a.Marque + b.Marque, a.Poid + b.Poid);
        public static Vehicules operator ==(Vehicules a, Vehicules b) => new Voiture(a.Marque + b.Marque, a.Poid + b.Poid);
        public static Vehicules operator !=(Vehicules a, Vehicules b) => new Voiture(a.Marque + b.Marque, a.Poid + b.Poid);
    }
}
