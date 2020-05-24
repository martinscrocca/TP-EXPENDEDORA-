using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expendedora.Negocio;
using Expendedora.Entidades;

namespace Expendedora.Presentacion.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pActivo = true;
            double dinero = 0;


            string entrada= string.Empty;

            string respuesta= string.Empty;
            Expended _expend = new Expended();
            Lata Coca = new Lata("CO1", "Regular", "Coca Cola", 45, 500);
            Lata CocaZ = new Lata("CO2", "Zero", "Coca Cola", 55, 500);
          

            _expend.AgregarLata(Coca);
            _expend.AgregarLata(CocaZ);
            

           string res= ConsolaHelper.PedirString("Deseas encender la maquina? SI/NO");

            if (res.ToUpper() == "NO")
            {
                Console.WriteLine("Muchas gracias. Adios");
            }
            else if(res.ToUpper() == "SI")
            {
                Console.WriteLine("Seleccione: \n 1) Ingresar Lata \n 2) Extraer Lata \n 3) Mostrar stock \n 4) Mostrar Balance \n Salir");



                do
                {
                    try
                    {

                        entrada = ConsolaHelper.PedirString("Seleccion: ");
                        

                        if (entrada.ToUpper() == "SALIR")
                        {
                            pActivo = false;
                            Environment.Exit(0);
                        }

                        switch (entrada.ToUpper())
                        {
                            case "1":

                              
                                respuesta = ConsolaHelper.PedirString("Seleccion:\n CO1) Ingresar Coca Común \n CO2) Ingresar Coca Zero \n SP1) Ingresar Sprite\n SP2) Ingresar Sprite ZERO\n FA1) Ingresar Fanta Regular\n FA2) Ingresar Fanta ZERO\n ");
                                if (respuesta.ToUpper() == "CO1")
                                {
                                    string n = "Coca Cola ";
                                    string s = "Regular";

                                    double v = ConsolaHelper.PedirDouble("Volumen");
                                    double p = ConsolaHelper.PedirDouble("Precio");

                                    Lata lat1 = new Lata("CO1", s, n, p, v);
                                    _expend.AgregarLata(lat1);


                                }
                                else if (respuesta.ToUpper() == "CO2")
                                {

                                    string n = "Coca Cola ";
                                    string s = "Zero";

                                    double v = ConsolaHelper.PedirDouble("Volumen");
                                    double p = ConsolaHelper.PedirDouble("Precio");


                                    Lata lat1 = new Lata("CO2", s, n, p, v);
                                    _expend.AgregarLata(lat1);


                                }
                                else if (respuesta.ToUpper() == "SP1")
                                {
                                    string n = "Sprite ";
                                    string s = "Regular";

                                    double v = ConsolaHelper.PedirDouble("Volumen");
                                    double p = ConsolaHelper.PedirDouble("Precio");


                                    Lata lat1 = new Lata("SP1", s, n, p, v);
                                    _expend.AgregarLata(lat1);
                                }
                                else if (respuesta.ToUpper() == "SP2")
                                {
                                    string n = "Sprite";
                                    string s = "Zero";

                                    double v = ConsolaHelper.PedirDouble("Volumen");
                                    double p = ConsolaHelper.PedirDouble("Precio");

                                    Lata lat1 = new Lata("SP2", s, n, p, v);
                                    _expend.AgregarLata(lat1);
                                }
                                else if (respuesta.ToUpper() == "FA1")
                                {
                                    string n = "Fanta";
                                    string s = "Regular";

                                    double v = ConsolaHelper.PedirDouble("Volumen");
                                    double p = ConsolaHelper.PedirDouble("Precio");

                                    Lata lat1 = new Lata("FA1", s, n, p, v);
                                    _expend.AgregarLata(lat1);
                                }
                                else if (respuesta.ToUpper() == "FA2")
                                {
                                    string n = "Fanta";
                                    string s = "Zero";

                                    double v = ConsolaHelper.PedirDouble("Volumen");
                                    double p = ConsolaHelper.PedirDouble("Precio");

                                    Lata lat1 = new Lata("FA2", s, n, p, v);
                                    _expend.AgregarLata(lat1);
                                }
                                else
                                {
                                    throw new Exception("Codigo Invalido");
                                    
                                }

                                break;

                            case "2":
                                Console.Write("Ingrese el dinero:  ");
                                dinero = double.Parse(Console.ReadLine());

                                //Console.WriteLine("Seleccion :\n CO1) Extraer Coca Regular \n CO2) Extraer Coca Zero \n SP1) Extraer Sprite\n SP2) Extraer Sprite ZERO\n  FA1) Extraer Fanta Regular\n FA2) Extrear Fanta ZERO\n ");
                                //respuesta = Console.ReadLine();
                                respuesta = ConsolaHelper.PedirString("Seleccion :\n CO1) Extraer Coca Regular \n CO2) Extraer Coca Zero \n SP1) Extraer Sprite\n SP2) Extraer Sprite ZERO\n  FA1) Extraer Fanta Regular\n FA2) Extrear Fanta ZERO\n ");


                                if (respuesta.ToUpper() == "CO1")
                                {
                                    _expend.ExtaerLata(dinero, "CO1");

                                }

                                else if (respuesta.ToUpper() == "CO2")
                                {
                                    _expend.ExtaerLata(dinero, "CO2");
                                }

                                else if (respuesta.ToUpper() == "SP1")
                                {
                                    _expend.ExtaerLata(dinero, "SP1");
                                }

                                else if (respuesta.ToUpper() == "SP2")
                                {
                                    _expend.ExtaerLata(dinero, "SP2");
                                }

                                else if (respuesta.ToUpper() == "FA1")
                                {
                                    _expend.ExtaerLata(dinero, "FA1");
                                }

                                else if (respuesta.ToUpper() == "FA2")
                                {
                                    _expend.ExtaerLata(dinero, "FA2");
                                }
                                else
                                {
                                    throw new Exception("Codigo Invalido");
                                }
                                break;

                            case "3":

                                Console.WriteLine("Latas en Stock: ");
                                _expend.ListarLatas();

                                break;

                            case "4":
                                Console.WriteLine(_expend.MostrarBalance());

                                break;
                            default:
                                throw new Exception("Opción inválida");

                        }
                        Console.WriteLine("Operación realizada. ");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                while (pActivo);


            }
        }
    }
}
