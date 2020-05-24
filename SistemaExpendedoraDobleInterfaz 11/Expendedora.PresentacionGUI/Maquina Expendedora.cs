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
    public partial class Maquina_Expendedora : Form
    {

        Lata Coca = new Lata("CO1", "Regular", "Coca Cola", 45, 500);
        Lata CocaZ = new Lata("CO2", "Zero", "Coca Cola", 55, 500);
        Lata SpriteR = new Lata("SP1", "Regular", "Sprite", 40, 500);
        Lata SpriteZ = new Lata("SP2", "Zero", "Sprite", 50, 500);
        Lata Fanta = new Lata("FA1", "Regular", "Fanta", 30, 500);
        Lata FantaZ = new Lata("FA2", "Zero", "Fanta", 40, 500);



        private Expended _expendedora;

        

        public Maquina_Expendedora(Expended f)
        {
            _expendedora = f;
            InitializeComponent();
        }

        private void btnAgregarLata_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregarLatacs FrAgr = new FrmAgregarLatacs(_expendedora);
                FrAgr.Owner = this;
                FrAgr.Show();
                this.Hide();
            } catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

       

        private void Maquina_Expendedora_Load(object sender, EventArgs e)
        {
            _expendedora.Latas.Add(Coca);
            _expendedora.Latas.Add(CocaZ);
            _expendedora.Latas.Add(SpriteR);
            _expendedora.Latas.Add(SpriteZ);
            _expendedora.Latas.Add(Fanta);
            _expendedora.Latas.Add(FantaZ);







            

        }

        private void btnMostrarLtas_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
           
            ListaLatas ll = new ListaLatas(_expendedora);
            ll.Owner = this;
            ll.Show();
            this.Hide();
        }

        private void BtnExtraerLata_Click(object sender, EventArgs e)
        {
            try
            { 
                            if (this.rbCocaReg.Checked == true)
                            {
                                double dinero = Convert.ToDouble(txtPlata.Text);
                                string cod = "CO1";
                                _expendedora.ExtaerLata(dinero, cod);

                                MessageBox.Show("Venta Existosa");
                                txtPlata.Clear();


                            }



                            if (this.rbCocaZero.Checked == true)
                            {
                                double dinero = Convert.ToDouble(txtPlata.Text);
                                string cod = "CO2";
                                _expendedora.ExtaerLata(dinero, cod);

                                MessageBox.Show("Venta Existosa");
                                txtPlata.Clear();

                            }
                            if (this.rbSpriteReg.Checked == true)
                            {
                                double dinero = Convert.ToDouble(txtPlata.Text);
                                string cod = "SP1";
                                _expendedora.ExtaerLata(dinero, cod);
                                MessageBox.Show("Venta Existosa");
                                txtPlata.Clear();

                            }

                            if (this.rbSpriteZero.Checked == true)
                            {
                                double dinero = Convert.ToDouble(txtPlata.Text);
                                string cod = "SP2";
                                _expendedora.ExtaerLata(dinero, cod);
                                MessageBox.Show("Venta Existosa");
                                txtPlata.Clear();

                            }
                            if (this.rbFanta.Checked == true)
                            {
                                double dinero = Convert.ToDouble(txtPlata.Text);
                                string cod = "FA1";
                                _expendedora.ExtaerLata(dinero, cod);
                                MessageBox.Show("Venta Existosa");
                                txtPlata.Clear();

                            }
                            if (this.rbFantaZero.Checked == true)
                            {
                                double dinero = Convert.ToDouble(txtPlata.Text);
                                string cod = "FA2";
                                _expendedora.ExtaerLata(dinero, cod);
                                MessageBox.Show("Venta Existosa");
                                txtPlata.Clear();

                            }
                } catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }     
            
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtPlata_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnBalance_Click(object sender, EventArgs e)
        {
            lblBalance.Show();
            lblBalance.Text = _expendedora.MostrarBalance();
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }
    }



}
