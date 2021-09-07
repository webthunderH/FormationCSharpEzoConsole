using FormationCSharpEzoConsole.Generics;
using FormationCSharpEzoConsole.Partial;
using FormationCSharpEzoConsole.TestHeritage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FormationCSharpEzoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var testClass = new TestReference() { a = 0,b=1 };
           
            int age = 0;
          
            const string cegep = "Cegep Garnaux";

            int.TryParse("zsdfsdgsdgfasdbfgvds", out age);
            Console.WriteLine($@"Hello {testClass.a + testClass.b} ! Vous avez {age}! Nous somme le {DateTime.Now.ToString("dd-MM-yyyy")}
                Vous êtes en train de créer un test simple pour {cegep}");
            
            var test2 = testClass;
            test2.a = 5;
           
            var testStatic = 6.Add(4);
            var z = new List<List<int>>();
            var @partial = new TestPartial();
            @partial.ABCD = 6;
            @partial.ViaTestPartialB = 14;
            Aeroport<Hydravion> aeroport = new Aeroport<Hydravion>();
            var erreur = new GestionErreur();
            var ax = aeroport ?? new Aeroport<Hydravion>();
            ax.PlaceDisponible.Add(new Hydravion("Henry"));
            var test004 = new Test0004();

            foreach (var item in z)
            {

            }

            int i = 0;
            ++i;
            i++;
            i += 1;

            try
            {
                erreur.Diviser(1, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(erreur.Diviser(1,1));
            }
            Console.ReadLine();
            int? abc = null;
            Struct? @struct = null;

            Console.WriteLine("Deux manière de faire un travail avec un string ");
           // Console.WriteLine(string.Format("Hello {0} ! Vous avez {1}! Nous somme le {2} Vous êtes en train de créer un test simple pour {3}",test, age, DateTime.Now.ToString("dd-MM-yyyy"), cegep));
        }

    }
}
