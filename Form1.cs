using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pombinhos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string link = "https://apisenac.estevaorada.repl.co/api/amor/" + txbNome1.Text + "/" + txbNome2.Text;
            // Instanciar o "navegador" para acessar a internet
            WebClient navegador = new WebClient();

            try
            {
                // Acessar o link
                string r = navegador.DownloadString(link);

                // Corrigir as letrinhas feias bugadas horrorosas // co
                r = Encoding.UTF8.GetString(Encoding.Default.GetBytes(r));


                // Documemtação do site JSON, tranformar em objeto
                Romance romance = JsonConvert.DeserializeObject<Romance>(r);


                // Exibir no forms
                lblcomb.Text = romance.Combinacao;
                lblPorcent.Text = romance.PorcentagemAmor.ToString() + "%";
                lblSugest.Text = romance.Sugestao;
            }
            catch 
            {
                MessageBox.Show("Falha de conexão!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
