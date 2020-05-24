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

namespace Expendedora.PresentacionGUI
{
    public partial class FrmBebidas : Form
    {
        public FrmBebidas()
        {
            InitializeComponent();
        }

        private void lblCocaComun_Click(object sender, EventArgs e)
        {
         

        }

        private void Bebidas_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show(); // no puedo hacer un new, porque creo un objeto_ expendedora de vuelta
            this.Dispose();
            
        }
        

        private  void ExtraerLata(Expended exp)
        {
            
            if (string.IsNullOrEmpty(this.txtIngPrecioCC.Text) )
            {
                MessageBox.Show("El precio debe completarse");
            }
            //else
            //{
            //    exp.ExtaerLata()
            //}


        }

        private void btnCocaComun_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
