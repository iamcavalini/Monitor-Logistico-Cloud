using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Monitor_Logistico_Cloud
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://monitor-cloud-4408e-default-rtdb.firebaseio.com/" // Sua URL do Firebase
        };

        // Instância do cliente Firebase
        IFirebaseClient client;

        private TimeSpan horaSalvaTS;
        private TimeSpan horaSalvaTS2;
        private TimeSpan horaSalvaTS3;

        // Timer para controle de atualização da hora
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config); // Cria a conexão com o Firebase
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Atualiza a cada 1 segundo
            timer.Tick += (s, e) => AtualizarHorarioSeDentroExpediente();
            timer.Start();
        }

        // Método para recuperar e atualizar a hora
        public async void AtualizarHora()
        {
            // Pega a hora salva no Firebase
            FirebaseResponse response = client.Get("Dadosdousuario/Tempomedioentrega");
            dynamic dados = response.ResultAs<dynamic>();
            string horaSalva = dados["Tempomedioentrega"];
            if (TimeSpan.TryParse(horaSalva, out horaSalvaTS))
            {
                DateTime horarioFinal = SomarComHorarioDeExpediente(DateTime.Now, horaSalvaTS);
                label2.Text = ObterDescricaoHorarioComExpediente(horarioFinal);
            }

            response = client.Get("Dadosdousuario/Tempomedioentrega2");
            dados = response.ResultAs<dynamic>();
            horaSalva = dados["Tempomedioentrega2"];
            if (TimeSpan.TryParse(horaSalva, out horaSalvaTS2))
            {
                DateTime horarioFinal = SomarComHorarioDeExpediente(DateTime.Now, horaSalvaTS2);
                label4.Text = ObterDescricaoHorarioComExpediente(horarioFinal);
            }

            response = client.Get("Dadosdousuario/Tempomedioentrega3");
            dados = response.ResultAs<dynamic>();
            horaSalva = dados["Tempomedioentrega3"];
            if (TimeSpan.TryParse(horaSalva, out horaSalvaTS3))
            {
                DateTime horarioFinal = SomarComHorarioDeExpediente(DateTime.Now, horaSalvaTS3);
                label6.Text = ObterDescricaoHorarioComExpediente(horarioFinal);
            }
        }

        // Método chamado no Timer, para verificar o expediente e atualizar as horas
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                AtualizarHorarioSeDentroExpediente();
            });
        }

        // Método que verifica o expediente e atualiza as horas conforme necessário
        private void AtualizarHorarioSeDentroExpediente()
        {
            if (DentroDoExpediente())
            {
                AtualizarHora();
            }
        }

        // Método que verifica se estamos dentro do horário de expediente
        private bool DentroDoExpediente()
        {
            DateTime agora = DateTime.Now;
            TimeSpan inicioSemana = new TimeSpan(7, 0, 0);
            TimeSpan fimSemana = new TimeSpan(16, 30, 0);
            TimeSpan fimSabado = new TimeSpan(12, 0, 0);

            DayOfWeek dia = agora.DayOfWeek;
            TimeSpan horaAtual = agora.TimeOfDay;

            if (dia >= DayOfWeek.Monday && dia <= DayOfWeek.Friday)
            {
                return horaAtual >= inicioSemana && horaAtual <= fimSemana;
            }
            else if (dia == DayOfWeek.Saturday)
            {
                return horaAtual >= inicioSemana && horaAtual <= fimSabado;
            }
            return false;
        }

        // Método para obter a descrição do horário de acordo com o expediente
        private string ObterDescricaoHorarioComExpediente(DateTime horarioFinal)
        {
            DateTime agora = DateTime.Now;
            TimeSpan inicioSemana = new TimeSpan(7, 0, 0);
            TimeSpan fimSemana = new TimeSpan(16, 30, 0);
            TimeSpan fimSabado = new TimeSpan(12, 0, 0);

            DayOfWeek dia = horarioFinal.DayOfWeek;
            TimeSpan horaDoDia = horarioFinal.TimeOfDay;

            bool dentroExpediente = false;

            if (dia >= DayOfWeek.Monday && dia <= DayOfWeek.Friday)
            {
                dentroExpediente = horaDoDia >= inicioSemana && horaDoDia <= fimSemana;
            }
            else if (dia == DayOfWeek.Saturday)
            {
                dentroExpediente = horaDoDia >= inicioSemana && horaDoDia <= fimSabado;
            }

            if (dentroExpediente)
            {
                if (horarioFinal.Date == agora.Date)
                    return $"Hoje às {horarioFinal:HH:mm:ss}";
                else if (horarioFinal.Date == agora.AddDays(1).Date)
                    return $"Amanhã às {horarioFinal:HH:mm:ss}";
                else
                    return $"{horarioFinal:dddd} às {horarioFinal:HH:mm:ss}";
            }
            else
            {
                DateTime proximoExpediente = horarioFinal;

                while (true)
                {
                    proximoExpediente = proximoExpediente.AddMinutes(1);

                    DayOfWeek novoDia = proximoExpediente.DayOfWeek;
                    TimeSpan novaHora = proximoExpediente.TimeOfDay;

                    bool podeContinuar = false;

                    if (novoDia >= DayOfWeek.Monday && novoDia <= DayOfWeek.Friday)
                        podeContinuar = novaHora >= inicioSemana && novaHora <= fimSemana;
                    else if (novoDia == DayOfWeek.Saturday)
                        podeContinuar = novaHora >= inicioSemana && novaHora <= fimSabado;

                    if (podeContinuar)
                        break;
                }

                if (proximoExpediente.Date == agora.Date)
                    return $"Hoje às {proximoExpediente:HH:mm}";
                else if (proximoExpediente.Date == agora.AddDays(1).Date)
                    return $"Amanhã às {proximoExpediente:HH:mm}";
                else
                    return $"{proximoExpediente:dddd} às {proximoExpediente:HH:mm}";
            }
        }

        // Método para somar o tempo com o horário de expediente
        private DateTime SomarComHorarioDeExpediente(DateTime inicio, TimeSpan tempoParaSomar)
        {
            DateTime atual = inicio;
            TimeSpan restante = tempoParaSomar;

            TimeSpan inicioSemana = new TimeSpan(7, 0, 0);
            TimeSpan fimSemana = new TimeSpan(16, 30, 0);
            TimeSpan fimSabado = new TimeSpan(12, 0, 0);

            while (restante > TimeSpan.Zero)
            {
                DayOfWeek dia = atual.DayOfWeek;
                TimeSpan horaAtual = atual.TimeOfDay;

                TimeSpan inicioExpediente, fimExpediente;

                if (dia >= DayOfWeek.Monday && dia <= DayOfWeek.Friday)
                {
                    inicioExpediente = inicioSemana;
                    fimExpediente = fimSemana;
                }
                else if (dia == DayOfWeek.Saturday)
                {
                    inicioExpediente = inicioSemana;
                    fimExpediente = fimSabado;
                }
                else
                {
                    atual = atual.Date.AddDays(1).Add(inicioSemana);
                    continue;
                }

                if (horaAtual < inicioExpediente)
                {
                    atual = atual.Date.Add(inicioExpediente);
                    horaAtual = atual.TimeOfDay;
                }

                if (horaAtual >= fimExpediente)
                {
                    atual = atual.Date.AddDays(1).Add(inicioSemana);
                    continue;
                }

                TimeSpan tempoDisponivel = fimExpediente - horaAtual;

                if (restante <= tempoDisponivel)
                {
                    atual = atual.Add(restante);
                    restante = TimeSpan.Zero;
                }
                else
                {
                    atual = atual.Add(tempoDisponivel);
                    restante -= tempoDisponivel;
                    atual = atual.Date.AddDays(1).Add(inicioSemana);
                }
            }

            return atual;
        }

        private void atualizarbtn_Click(object sender, EventArgs e)
        {
            AtualizarHora();  // Chama o método
        }
        private void editarbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this); // Cria uma instância do Form2
            form2.Show();                  // Exibe o Form2
        }
    }
}
