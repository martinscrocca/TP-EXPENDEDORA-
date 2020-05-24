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

using Expendedora.Entidades;// 

namespace Expendedora.PresentacionGUI
{
    public partial class FrmAgregarLatacs : Form
    {



        private Expended _expendedora;

       

        public FrmAgregarLatacs(Expended exp)
        {
            _expendedora = exp ;
            InitializeComponent();
        }

        private void btnGuardarLata_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtNombre.Text == string.Empty || txtSabor.Text == string.Empty || comboBoxCod.Text == string.Empty || txtPrecio.Text == string.Empty || txtSabor.Text == string.Empty)
                //{
                //    MessageBox.Show("Datos obligatorios no ingresados, por favor complete todos los campos");

                //}
                //else if (Convert.ToDouble(txtPrecio.Text) <= 0 || Convert.ToDouble(txtVolumen.Text) <= 0)
                //{
                //    MessageBox.Show("Ingrese valores positivos");
                //}
                //else


                //{
                    if (_expendedora.Latas.Count > 8)
                    {
                        throw new Exception(Convert.ToString(MessageBox.Show("Capacidad de la maquina insuficiente")));
                    }
                    else
                    {



                        try
                        {
                            Lata l1 = new Lata(comboBoxCod.Text, txtSabor.Text, txtNombre.Text, double.Parse(txtPrecio.Text), double.Parse(txtVolumen.Text));// agregar los txt

                            _expendedora.AgregarLata(l1);

                            MessageBox.Show("Lata " + l1 + " fue agregada Correctamente");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        Limpiar(this);
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

            public static void Limpiar(Form ofrm)
            {
            
            foreach (Control oControls in ofrm.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; 
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show(); // no puedo hacer un new, porque creo un objeto_ expendedora de vuelta
            this.Dispose();
        }

        private void FrmAgregarLatacs_Load(object sender, EventArgs e)
        {

        }

        private void ComboBoxCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcCb = Convert.ToString(comboBoxCod.Text);
            if(opcCb == "CO1")
            {
                txtNombre.Text = "Coca Cola";
                txtSabor.Text = "Regular";
                
            }
            if (opcCb == "CO2")
            {
                txtNombre.Text = "Coca Cola";
                txtSabor.Text = "Zero";

            }
            if (opcCb == "SP1")
            {
                txtNombre.Text = "Sprite";
                txtSabor.Text = "Regular";

            }
            if (opcCb == "SP2")
            {
                txtNombre.Text = "Sprite";
                txtSabor.Text = "Zero";

            }
            if (opcCb == "FA1")
            {
                txtNombre.Text = "Fanta";
                txtSabor.Text = "Regular";

            }
            if (opcCb == "FA2")
            {
                txtNombre.Text = "Fanta";
                txtSabor.Text = "Zero";

            }

            //int indice = comboBoxCod.SelectedIndex;
            //txtNombre.Text = "coca";
        }
    }
}
