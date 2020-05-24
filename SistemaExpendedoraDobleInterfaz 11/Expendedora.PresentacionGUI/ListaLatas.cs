using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Expendedora.Negocio;
using Expendedora.Entidades;

namespace Expendedora.PresentacionGUI
{
    public partial class ListaLatas : Form
    {
       

        private Expended _expendedora; 


        public ListaLatas(Expended l)
        {
            _expendedora = l;
            InitializeComponent();
        }

        private void ListaLatas_Load(object sender, EventArgs e)
        {

            
            listBoxLatas2.DataSource = _expendedora.Latas;
            lblCantidadLatas.Text = Convert.ToString(_expendedora.Latas.Count);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show(); // no puedo hacer un new, porque creo un objeto_ expendedora de vuelta
            this.Dispose();
        }
    }
}
