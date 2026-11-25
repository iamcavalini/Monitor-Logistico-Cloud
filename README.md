🚚 Monitor Logístico Cloud

Aplicação desktop desenvolvida em C# (Windows Forms) integrada ao Firebase Realtime Database para monitoramento e cálculo dinâmico de previsão de entrega logística, considerando regras reais de horário comercial e diferentes categorias de materiais.

📋 Sobre o Projeto

O Monitor Logístico Cloud foi projetado para resolver um problema prático de operação logística e atendimento comercial: informar com precisão e em tempo real a previsão estimada de entrega para o cliente, respeitando a janela de expediente da empresa.

Em vez de apenas somar horas corridas ao horário atual, o sistema realiza o cálculo inteligente considerando apenas horas úteis dentro do horário de funcionamento, transbordando automaticamente o tempo restante para o próximo dia útil ou próximo turno de expediente.

Categorias Monitoradas

O painel acompanha simultaneamente três frentes operacionais distintas:

Básico / Diversos (Tempomedioentrega)

Pisos / Porcelanatos (Tempomedioentrega2)

Areia / Pedra (Tempomedioentrega3)

⚙️ Funcionalidades Principais

Sincronização em Nuvem (Firebase Realtime Database): Leitura e atualização centralizada dos tempos médios de entrega, permitindo que diferentes estações de trabalho visualizem os mesmos prazos atualizados.

Cálculo Inteligente de Horário Útil:

Segunda a Sexta-feira: 07:00 às 16:30

Sábado: 07:00 às 12:00

Domingo e fora de expediente: Pausa a contagem e projeta a entrega automaticamente para o próximo horário útil disponível.

Formatação Amigável para Operação: Exibe a previsão de forma clara e imediata para o operador (ex.: "Hoje às 15:40", "Amanhã às 08:30" ou o dia da semana correspondente).

Atualização Automática e Manual:

Verificação periódica automática via Timer durante o horário de expediente.

Botão dedicado (Atualizar) para sincronização sob demanda.

Painel de Configuração Rápida (Form2): Interface secundária para ajuste rápido dos tempos médios (HH:mm) de cada categoria diretamente no Firebase, com atualização imediata na tela principal.

🛠️ Tecnologias Utilizadas

Linguagem: C# (.NET Framework / Windows Forms)

Banco de Dados em Nuvem: Firebase Realtime Database

Biblioteca de Integração: FireSharp (FireSharp.Config, FireSharp.Interfaces, FireSharp.Response)

Interface Gráfica: Windows Forms (System.Windows.Forms)

🏗️ Estrutura do Projeto

Monitor_Logistico_Cloud/
├── Form1.cs             # Tela principal (painel de exibição, timer e motor de cálculo de expediente)
├── Form1.Designer.cs    # Definição visual dos componentes da interface principal
├── Form2.cs             # Modal de edição e persistência dos tempos médios no Firebase
└── README.md            # Documentação do projeto


Estrutura de Dados no Firebase

Os parâmetros são armazenados no nó Dadosdousuario no formato JSON:

{
  "Dadosdousuario": {
    "Tempomedioentrega": {
      "Tempomedioentrega": "02:30"
    },
    "Tempomedioentrega2": {
      "Tempomedioentrega2": "04:00"
    },
    "Tempomedioentrega3": {
      "Tempomedioentrega3": "01:45"
    }
  }
}


🚀 Como Executar o Projeto

Pré-requisitos

Visual Studio (2019 ou superior) com suporte a Desenvolvimento para Desktop com .NET

Pacote NuGet FireSharp instalado no projeto

Uma instância ativa do Firebase Realtime Database

Passo a Passo

Clone este repositório:

git clone https://github.com/seu-usuario/Monitor_Logistico_Cloud.git


Abra a solução (.sln) no Visual Studio.

Restaure os pacotes NuGet (certifique-se de que o pacote FireSharp esteja instalado).

Configure a URL do seu banco Firebase nos arquivos Form1.cs e Form2.cs:

IFirebaseConfig config = new FirebaseConfig
{
    BasePath = "https://sua-instancia-firebase.firebaseio.com/"
};


Compile e execute a aplicação (F5).

🔒 Boas Práticas e Melhorias Futuras

Para evoluir a arquitetura e a manutenibilidade do projeto em versões futuras, recomenda-se:

Externalização de Configuração: Mover a BasePath e credenciais do Firebase para um arquivo App.config ou variáveis de ambiente.

Chamadas Assíncronas (async/await): Utilizar GetAsync e SetAsync do FireSharp com tratamento de exceções (try/catch) para evitar bloqueio da thread principal da interface em caso de oscilações de rede.

Separação de Camadas: Extrair a regra de negócio de cálculo de expediente (SomarComHorarioDeExpediente) e o acesso ao Firebase para classes de serviço dedicadas, facilitando a escrita de testes unitários.

Cadastro de Feriados: Incluir uma lista configurável de feriados nacionais/municipais no cálculo de dias úteis.

👨‍💻 Autor

Desenvolvido por Marcos Cavalini

Analista e Desenvolvedor de Sistemas
