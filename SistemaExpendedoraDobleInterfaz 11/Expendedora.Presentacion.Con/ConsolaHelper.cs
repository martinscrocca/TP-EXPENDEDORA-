using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Presentacion.Con
{
    public static class ConsolaHelper
    {

        public static string PedirString(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            string n = Console.ReadLine();


            return n;
        }

        public static int PedirInt(string msg)
        {
            Console.WriteLine("Ingrese " + msg);

            // se puede validar algo o usar tryparse  o dejar que lo haga el framework
            int c = int.Parse(Console.ReadLine());


            return c;
        }

        



        public static double PedirDouble(string msg)
        {
            Console.WriteLine("Ingrese " + msg);


            double c = double.Parse(Console.ReadLine());


            return c;









        }
    }
}
