using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expendedora.Entidades;


namespace Expendedora.Negocio
{
    public  class Expended
    {
        List<Lata> _latas;
        string proveedor;
        int _capacidad;
        double _dinero;
        bool _encendida;

        public List<Lata> Latas { get => _latas; set => _latas = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public int Capacidad { get => _capacidad; set => _capacidad = value; }
        public double Dinero { get => _dinero; set => _dinero = value; }
        public bool Encendida { get => _encendida; set => _encendida = value; }
        

        
        

        public Expended()
        {
            this._latas = new List<Lata>();


        }

        

        public void AgregarLata(Lata lat)
        {
            if (lat.Precio >= 0 && lat.Volumen >= 0)
            {

                if (_latas.Count <= 10)
                {
                    _latas.Add(lat);

                }
                else
                {
                    throw new Exception("Capacidad Insificiente de Latas");
                }
            }
            else
            {
                throw new Exception("Insertar valores positivos");
            }
        }

        public void ListarLatas()
        {
            foreach (Lata l in Latas)
            {
                Console.WriteLine(l);

            }
           
        }

             
        public Lata ExtaerLata(double dinero, string cod)
        {
          
                Lata lata = null;

           

            foreach (Lata lat in _latas)
            {
               
                if (lat.Codigo == cod)
                {
                    lata = lat;
                }


            }
            
                if (lata != null)
                {
                    //try
                    //{
                    if (lata.Precio > dinero)
                    {
                        throw new Exception(
                                string.Format(
                                    "La lata indicada cuesta $ {1}, $ {0} ingresado es insuficiente", dinero.ToString(), lata.Precio.ToString())); ;
                    }
                    //}catch(StockInsuficienteExcep e1)
                    //{
                    //    e1.ToString();
                    //}
                    else
                    {

                        _dinero += lata.Precio;

                        _latas.Remove(lata);

                        return lata;
                    }
                }
                else
                {

                    throw new Exception("No hay más stock de la lata solicitada.");




                }
            
            
        }

        public bool EstaVacia()
        {
            _capacidad = _latas.Count;
            if (_capacidad == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string MostrarBalance()
        {



            string cantLatas = Convert.ToString(this._latas.Count);
            string cantDinero = Convert.ToString(this._dinero);
            return "La cantidad de latas disponibles es " + cantLatas + " y hay $ " + cantDinero + " pesos";


        }
    }
}
