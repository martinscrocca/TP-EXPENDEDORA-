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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            Expended a = new Expended(); 
            Maquina_Expendedora m1 = new Maquina_Expendedora(  a  );
            //m1.Owner = this;
            m1.Show();
            this.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Expended a = new Expended();
            Maquina_Expendedora m1 = new Maquina_Expendedora(a);
            //m1.Owner = this;
            m1.Show();
            this.Hide();
        }
    }
}
