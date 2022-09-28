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
    public partial class frmConsultaWSCorreios : Form
    {
        public frmConsultaWSCorreios()
        {
            InitializeComponent();
            txtIdContrato.Text = "9992157880";
            txtIdContrato.Enabled = false;
            txtCartaoPostagem.Text = "0067599079";
            txtCartaoPostagem.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var cepDigitado = txtCEP.Text;

                    lblAguarde.Visible = true;
                    rtxtEndereco.Visible = false;

                    if (cepDigitado.Trim() == "")
                    {
                        MessageBox.Show("Digite um CEP");
                        rtxtEndereco.Visible = false;
                        lblAguarde.Visible = false;
                    }
                    else
                    {
                        var resultado = ws.consultaCEP(cepDigitado.Trim());

                        lblAguarde.Visible = false;
                        rtxtEndereco.Text = "";
                        rtxtEndereco.Visible = true;
                        rtxtEndereco.Text += "Logradouro: " + resultado.end + Environment.NewLine;
                        rtxtEndereco.Text += "Bairro: " + resultado.bairro + Environment.NewLine;
                        rtxtEndereco.Text += "Cidade: " + resultado.cidade + Environment.NewLine;
                        rtxtEndereco.Text += "Estado: " + resultado.uf;

                    }
                }
                catch (Exception ex)
                {
                    lblAguarde.Visible = false;
                    rtxtEndereco.Visible = false;
                    MessageBox.Show("Erro ao consultar o CEP: " + ex.Message);
                }
            }
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var idContrato = txtIdContrato.Text;

                    lblAguarde2.Visible = true;
                    rtxtCliente.Visible = false;
                    var result = ws.buscaCliente(idContrato, "0067599079", "sigep", "n5f9t8");

                    lblAguarde2.Visible = false;
                    rtxtCliente.Text = "";
                    rtxtCliente.Visible = true;
                    rtxtCliente.Text += "CNPJ do Cliente: " + result.cnpj + Environment.NewLine;
                    rtxtCliente.Text += "Nome do Cliente: " + result.nome + Environment.NewLine;

                }
                catch (Exception ex)
                {
                    lblAguarde2.Visible = false;
                    rtxtEndereco.Visible = false;
                    MessageBox.Show("Erro ao consultar o cliente: " + ex.Message);
                }
            }
        }

        private void btnConsultar3_Click(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var cartaoPostagem = txtCartaoPostagem.Text;

                    lblAguarde3.Visible = true;
                    rtxtPostagem.Visible = false;
                    var result = ws.getStatusCartaoPostagem(cartaoPostagem, "sigep", "n5f9t8");


                    lblAguarde3.Visible = false;
                    rtxtPostagem.Text = "";
                    rtxtPostagem.Visible = true;
                    rtxtPostagem.Text += "Status da postagem: " + result + Environment.NewLine;

                }
                catch (Exception ex)
                {
                    lblAguarde3.Visible = false;
                    rtxtPostagem.Visible = false;
                    MessageBox.Show("Erro ao consultar o cliente: " + ex.Message);
                }
            }
        }
    }
}
