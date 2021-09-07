using System;
using System.Collections.Generic;
using System.Text;

namespace FormationCSharpEzoConsole
{
    public class GestionErreur
    {
        public int? Diviser(int a, int b)
        {
            int? retour= null;
           
            try
            {
                retour = a / b;
            }
           
            catch(NullReferenceException e)
            {
                throw e;
            }
            catch(TestException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                throw;
            }
            return retour;
        }



        public int Diviser(int a, int b, int c)
        {
            int retour = default;
            try
            {
                retour = a / b / c;
            }
            catch (Exception e)
            {
                // gestion de l'erreur.
                
            }
            finally
            {

            }
            return retour;
        }
    }
}
