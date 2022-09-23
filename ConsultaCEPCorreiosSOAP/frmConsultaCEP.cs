using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEPCorreiosSOAP
{
    public partial class frmConsultaCEP : Form
    {
        public frmConsultaCEP()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using(var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var cepDigitado = txtCEP.Text;
                    
                    lblAguarde.Visible = true;
                    richTextBox1.Visible = false;

                    if (cepDigitado.Trim() == "")
                    {
                        MessageBox.Show("Digite um CEP");
                        richTextBox1.Visible = false;
                        lblAguarde.Visible = false;
                    }
                    else
                    {
                        var resultado = ws.consultaCEP(cepDigitado.Trim());

                        lblAguarde.Visible = false;
                        richTextBox1.Text = "";
                        richTextBox1.Visible = true;
                        richTextBox1.Text += "Logradouro: " + resultado.end + Environment.NewLine;
                        richTextBox1.Text += "Bairro: " + resultado.bairro + Environment.NewLine;
                        richTextBox1.Text += "Cidade: " + resultado.cidade + Environment.NewLine;
                        richTextBox1.Text += "Estado: " + resultado.uf;

                    }
                }
                catch(Exception ex)
                {
                    lblAguarde.Visible = false;
                    richTextBox1.Visible = false;
                    MessageBox.Show("Erro ao consultar o CEP: " + ex.Message);
                }
                

            }
            

        }
    }
}
