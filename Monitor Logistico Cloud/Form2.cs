using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor_Logistico_Cloud
{
    public partial class Form2 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://monitor-cloud-4408e-default-rtdb.firebaseio.com/" // Coloque sua URL aqui
        };

        IFirebaseClient client;
        private Form1 form1;
        public Form2(Form1 mainForm)
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            form1 = mainForm;
        }

        private void atulizarbasicobtn_Click(object sender, EventArgs e)
        {
            string horaInserida = basicotxt.Text.Trim();

            if (TimeSpan.TryParse(horaInserida, out TimeSpan tempomedioentrega))
            {
                var dados = new
                {
                    Tempomedioentrega = tempomedioentrega.ToString(@"hh\:mm")
                };

                SetResponse response = client.Set("Dadosdousuario/Tempomedioentrega", dados);

                form1.AtualizarHora();

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string horaInseridaIntermediario = pisostxt.Text.Trim();

            if (TimeSpan.TryParse(horaInseridaIntermediario, out TimeSpan tempoIntermediario))
            {
                var dados = new
                {
                    Tempomedioentrega2 = tempoIntermediario.ToString(@"hh\:mm")
                };

                SetResponse response = client.Set("Dadosdousuario/Tempomedioentrega2", dados);

                form1.AtualizarHora();

                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string horaInseridaAvancado = areiatxt.Text.Trim();

            if (TimeSpan.TryParse(horaInseridaAvancado, out TimeSpan tempoAvancado))
            {
                var dados = new
                {
                    Tempomedioentrega3 = tempoAvancado.ToString(@"hh\:mm")
                };

                SetResponse response = client.Set("Dadosdousuario/Tempomedioentrega3", dados);

                form1.AtualizarHora();

                this.Close();
            }
        }
    }
}
