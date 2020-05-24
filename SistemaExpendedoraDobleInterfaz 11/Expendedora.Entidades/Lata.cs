using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Entidades
{
    public class Lata
    {
        private string _codigo;
        private string _sabor;
        private string _nombre;
        private double _precio;
        private double _volumen;

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Sabor { get => _sabor; set => _sabor = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public double Volumen { get => _volumen; set => _volumen = value; }


        public Lata(string cod, double din)
        {
            this._precio = din;
            this._codigo = cod;

        }

        public Lata(string cod, string sab, string nom, double prec, double vol)
        {
            _codigo = cod;
            _sabor = sab;
            _nombre = nom;
            _precio = prec;
            _volumen = vol;

        }

        public double PrecioxLitro()
        {
            double p = this._precio;
            double v = this.Volumen;

            return p / v;

        }
        

        public string InfoLata()
        {
            

            string ficha = string.Format(" Cod {0}) -- Nombre {1},-- {2}, -- {4}  -- Precio {3} -- Precio Por Litro {5} ", this.Codigo, this.Nombre, this.Sabor, this.Precio, this.Volumen, this.PrecioxLitro());

            return ficha;
        }

        public override string ToString()
        {
            return InfoLata();
        }



    }
}
