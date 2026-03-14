namespace WinFormsApp1
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
        }

        //gerar lista de numeros
        private string GerarLista(int inicio, int fim)
        {
            List<string> numeros = new List<string>();

            for (int i = inicio; i <= fim; i++)
            {
                numeros.Add(i.ToString());
            }

            return string.Join(", ", numeros);
        }
        //variavel para parar automação 

        bool pararAutomacao = false;


        //adicionar ao log 
        void AddLog(string msg)
        {
            txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {msg}" + Environment.NewLine);
            txtLog.ScrollToCaret();
        }


        private void trackVelocidade_Scroll(object sender, EventArgs e)
        {
            lblVelocidade.Text = "Velocidade: " + trackVelocidade.Value + " ms";
        }

        //executar automação 
        void ExecutarAutomacao(string loja, string caixa, string nfc)
        {



            Thread.Sleep(300);

            // Selecionar tudo no campo

            //SendKeys.SendWait("^(a)");

            // Apagar
            //SendKeys.SendWait("{DELETE}");
            Thread.Sleep(800);



            SendKeys.SendWait("{HOME}");
            Thread.Sleep(300);

            AddLog("Limpando busca");
            for (int i = 0; i < 6; i++)
            {
                SendKeys.SendWait("{DELETE}");
                
            }

            AddLog("Aguardando para digitar proximo item");
            Thread.Sleep(trackVelocidade.Value);





            // Digita NFC
            SendKeys.SendWait(nfc);
            AddLog("Digitando proximo item ");
            AddLog("Aguardando o sistema exibir o item ");
            Thread.Sleep(trackVelocidade.Value);



            // Aperta F2
            SendKeys.SendWait("{F2}");
            AddLog("Clicando em salvar");
            Thread.Sleep(300);

            // Digita descrição
            AddLog("Digitando o nome do arquivo");
            //string texto = $"Loja: {txtLoja.Text} - Caixa: {txtCaixa.Text} - NFC: {nfc}";
            //  SendKeys.SendWait("Loja: ");
            // SendKeys.SendWait(txtLoja.Text);
            // SendKeys.SendWait(" - Caixa: ");
            //  SendKeys.SendWait(txtCaixa.Text);
            //  SendKeys.SendWait(" - NFC: ");
            SendKeys.SendWait(nfc);
            Thread.Sleep(300);



            // Enter
            SendKeys.SendWait("{ENTER}");
            AddLog("Salvando NFCe");
            Thread.Sleep(4000);

            // Enter
            SendKeys.SendWait("{ENTER}");
            AddLog("Salvando NFCe");
            Thread.Sleep(2000);

        }

        //iniciar automação
        private async void button1_Click(object sender, EventArgs e)
        {
            pararAutomacao = false;

            //recebe o nome da loja e caixa
            string loja = txtLoja.Text;
            string caixa = txtCaixa.Text;


            //se loja ou caixa estiverem vazios, mostra mensagem e retorna
            if (string.IsNullOrWhiteSpace(loja) || string.IsNullOrWhiteSpace(caixa))
            {
                MessageBox.Show("Preencha loja e caixa");
                return;
            }

            //deixa só os números do NFC, separando por vírgula ou nova linha
            var lista = txtLista.Text
                .Split(new[] { ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();

            //se a lista estiver vazia, mostra mensagem e retorna
            if (lista.Count == 0)
            {
                MessageBox.Show("Lista de NFC vazia");
                return;
            }

            //configura progress bar
            progressBar1.Maximum = lista.Count;
            progressBar1.Value = 0;

            lblRestante.Text = "Restante: " + lista.Count;


            //altera status dos botões
            btnIniciar.Enabled = false;
            btnParar.Enabled = true;


            //adiciona log de início
            AddLog("Automação iniciando em 3 segundos...");
            AddLog("Deixe o campo 'Número da Nota' selecionado.");
            await Task.Delay(5000);


            //para cada NFC da lista, executa a automação
            foreach (var nfc in lista)
            {

                //se o usuário clicou em parar, interrompe a automação
                if (pararAutomacao)
                {
                    AddLog("Automação interrompida pelo usuário");
                    break;
                }


                //adiciona log do NFC atual
                AddLog($"Processando NFC {nfc}");

                //executa a automação para o NFC atual
                ExecutarAutomacao(loja, caixa, nfc);


                //atualiza a progress bar
                progressBar1.Value++;

                await Task.Delay(500);
            }


            // adiciona log de fim
            AddLog("Processo finalizado");

            //restaura status dos botões
            btnIniciar.Enabled = true;
            btnParar.Enabled = false;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            //parar automação
            pararAutomacao = true;
            AddLog("Solicitação de parada enviada...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGerarLista_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInicial.Text, out int inicio) &&
             int.TryParse(txtFinal.Text, out int fim))
            {
                txtLista.Text = GerarLista(inicio, fim);

                int quantidade = (fim - inicio) + 1;
                lblQuantidade.Text = "Quantidade: " + quantidade;
            }
            else
            {
                MessageBox.Show("Digite números válidos.");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}


