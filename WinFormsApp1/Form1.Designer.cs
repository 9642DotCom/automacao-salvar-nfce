namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLoja = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCaixa = new TextBox();
            label3 = new Label();
            txtLista = new TextBox();
            btnIniciar = new Button();
            btnParar = new Button();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            txtLog = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            txtInicial = new TextBox();
            txtFinal = new TextBox();
            label7 = new Label();
            buttonGerarLista = new Button();
            lblQuantidade = new Label();
            lblRestante = new Label();
            trackVelocidade = new TrackBar();
            label8 = new Label();
            lblVelocidade = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackVelocidade).BeginInit();
            SuspendLayout();
            // 
            // txtLoja
            // 
            txtLoja.Location = new Point(109, 20);
            txtLoja.Name = "txtLoja";
            txtLoja.Size = new Size(414, 23);
            txtLoja.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome da loja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Caixa:";
            // 
            // txtCaixa
            // 
            txtCaixa.Location = new Point(109, 58);
            txtCaixa.Name = "txtCaixa";
            txtCaixa.Size = new Size(414, 23);
            txtCaixa.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "NFCs:";
            // 
            // txtLista
            // 
            txtLista.Location = new Point(109, 174);
            txtLista.Multiline = true;
            txtLista.Name = "txtLista";
            txtLista.Size = new Size(414, 81);
            txtLista.TabIndex = 4;
            txtLista.WordWrap = false;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(109, 353);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(147, 23);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar automação ";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += button1_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(459, 353);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(64, 23);
            btnParar.TabIndex = 7;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(109, 394);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(414, 23);
            progressBar1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 402);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Progresso:";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(109, 449);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(414, 114);
            txtLog.TabIndex = 10;
            txtLog.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 449);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 11;
            label5.Text = "Log:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 99);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 12;
            label6.Text = "Numero inicial:";
            // 
            // txtInicial
            // 
            txtInicial.Location = new Point(109, 127);
            txtInicial.Name = "txtInicial";
            txtInicial.Size = new Size(88, 23);
            txtInicial.TabIndex = 13;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(230, 127);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(88, 23);
            txtFinal.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 99);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 14;
            label7.Text = "Numero final:";
            // 
            // buttonGerarLista
            // 
            buttonGerarLista.Location = new Point(376, 126);
            buttonGerarLista.Name = "buttonGerarLista";
            buttonGerarLista.Size = new Size(147, 23);
            buttonGerarLista.TabIndex = 16;
            buttonGerarLista.Text = "Gerar lista de NFCe's";
            buttonGerarLista.UseVisualStyleBackColor = true;
            buttonGerarLista.Click += buttonGerarLista_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(12, 240);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(0, 15);
            lblQuantidade.TabIndex = 17;
            // 
            // lblRestante
            // 
            lblRestante.AutoSize = true;
            lblRestante.Location = new Point(12, 472);
            lblRestante.Name = "lblRestante";
            lblRestante.Size = new Size(0, 15);
            lblRestante.TabIndex = 18;
            // 
            // trackVelocidade
            // 
            trackVelocidade.Location = new Point(190, 276);
            trackVelocidade.Maximum = 180000;
            trackVelocidade.Minimum = 900;
            trackVelocidade.Name = "trackVelocidade";
            trackVelocidade.Size = new Size(214, 45);
            trackVelocidade.TabIndex = 19;
            trackVelocidade.Value = 900;
            trackVelocidade.Scroll += trackVelocidade_Scroll;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(137, 258);
            label8.Name = "label8";
            label8.Size = new Size(368, 15);
            label8.TabIndex = 20;
            label8.Text = "Velocidade da automação (Depende do processamento da maquina)";
            // 
            // lblVelocidade
            // 
            lblVelocidade.AutoSize = true;
            lblVelocidade.Location = new Point(109, 317);
            lblVelocidade.Name = "lblVelocidade";
            lblVelocidade.Size = new Size(67, 15);
            lblVelocidade.TabIndex = 21;
            lblVelocidade.Text = "Velocidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(153, 286);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 22;
            label9.Text = "Rapido";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(399, 286);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 23;
            label10.Text = "Lento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 569);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lblVelocidade);
            Controls.Add(label8);
            Controls.Add(trackVelocidade);
            Controls.Add(lblRestante);
            Controls.Add(lblQuantidade);
            Controls.Add(buttonGerarLista);
            Controls.Add(txtFinal);
            Controls.Add(label7);
            Controls.Add(txtInicial);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLog);
            Controls.Add(label4);
            Controls.Add(progressBar1);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Controls.Add(label3);
            Controls.Add(txtLista);
            Controls.Add(label2);
            Controls.Add(txtCaixa);
            Controls.Add(label1);
            Controls.Add(txtLoja);
            Name = "Form1";
            Text = "Download automatico de NFCs";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)trackVelocidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoja;
        private Label label1;
        private Label label2;
        private TextBox txtCaixa;
        private Label label3;
        private TextBox txtLista;
        private Button btnIniciar;
        private Button btnParar;
        private ProgressBar progressBar1;
        private Label label4;
        private RichTextBox txtLog;
        private Label label5;
        private Label label6;
        private TextBox txtInicial;
        private TextBox txtFinal;
        private Label label7;
        private Button buttonGerarLista;
        private Label lblQuantidade;
        private Label lblRestante;
        private TrackBar trackVelocidade;
        private Label label8;
        private Label lblVelocidade;
        private Label label9;
        private Label label10;
    }
}
