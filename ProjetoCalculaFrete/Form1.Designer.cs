namespace ProjetoCalculaFrete
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.lblValTotal = new System.Windows.Forms.Label();
            this.lblValProf = new System.Windows.Forms.Label();
            this.lblValTransp = new System.Windows.Forms.Label();
            this.lblValUF = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbProfissional = new System.Windows.Forms.ComboBox();
            this.cbTransporte = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbCredito = new System.Windows.Forms.ComboBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtAvista = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUF);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtOrigem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(627, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CADASTRO";
            // 
            // cbUF
            // 
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "GO",
            "ES",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SP",
            "SC",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(444, 108);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(121, 29);
            this.cbUF.TabIndex = 8;
            this.cbUF.SelectedIndexChanged += new System.EventHandler(this.cbUF_SelectedIndexChanged);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(166, 108);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(199, 29);
            this.txtDestino.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(166, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 29);
            this.txtNome.TabIndex = 6;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(166, 73);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(199, 29);
            this.txtOrigem.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "UF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "CIDADE DESTINO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "CIDADE DE ORIGEM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "NOME DO CLIENTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATA:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(392, 20);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(59, 21);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "lblData";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 29);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDesconto);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnConcluir);
            this.groupBox2.Controls.Add(this.lblValTotal);
            this.groupBox2.Controls.Add(this.lblValProf);
            this.groupBox2.Controls.Add(this.lblValTransp);
            this.groupBox2.Controls.Add(this.lblValUF);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbProfissional);
            this.groupBox2.Controls.Add(this.cbTransporte);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 332);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DADOS DO FRETE";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(103, 280);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(52, 21);
            this.lblDesconto.TabIndex = 5;
            this.lblDesconto.Text = "label2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 21);
            this.label13.TabIndex = 6;
            this.label13.Text = "15% DESC:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(400, 229);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(221, 31);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(400, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(400, 192);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(221, 31);
            this.btnConcluir.TabIndex = 6;
            this.btnConcluir.Text = "CONCLUIR";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // lblValTotal
            // 
            this.lblValTotal.AutoSize = true;
            this.lblValTotal.Location = new System.Drawing.Point(121, 239);
            this.lblValTotal.Name = "lblValTotal";
            this.lblValTotal.Size = new System.Drawing.Size(61, 21);
            this.lblValTotal.TabIndex = 11;
            this.lblValTotal.Text = "label16";
            // 
            // lblValProf
            // 
            this.lblValProf.AutoSize = true;
            this.lblValProf.Location = new System.Drawing.Point(190, 205);
            this.lblValProf.Name = "lblValProf";
            this.lblValProf.Size = new System.Drawing.Size(61, 21);
            this.lblValProf.TabIndex = 10;
            this.lblValProf.Text = "label15";
            // 
            // lblValTransp
            // 
            this.lblValTransp.AutoSize = true;
            this.lblValTransp.Location = new System.Drawing.Point(173, 170);
            this.lblValTransp.Name = "lblValTransp";
            this.lblValTransp.Size = new System.Drawing.Size(61, 21);
            this.lblValTransp.TabIndex = 9;
            this.lblValTransp.Text = "label14";
            // 
            // lblValUF
            // 
            this.lblValUF.AutoSize = true;
            this.lblValUF.Location = new System.Drawing.Point(94, 137);
            this.lblValUF.Name = "lblValUF";
            this.lblValUF.Size = new System.Drawing.Size(61, 21);
            this.lblValUF.TabIndex = 8;
            this.lblValUF.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "VALOR TOTAL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "VALOR PROFISSIONAIS:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "VALOR TRANSPORTE:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbProfissional
            // 
            this.cbProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfissional.FormattingEnabled = true;
            this.cbProfissional.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.cbProfissional.Location = new System.Drawing.Point(228, 64);
            this.cbProfissional.Name = "cbProfissional";
            this.cbProfissional.Size = new System.Drawing.Size(83, 29);
            this.cbProfissional.TabIndex = 4;
            this.cbProfissional.SelectedIndexChanged += new System.EventHandler(this.cbProfissional_SelectedIndexChanged);
            // 
            // cbTransporte
            // 
            this.cbTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransporte.FormattingEnabled = true;
            this.cbTransporte.Items.AddRange(new object[] {
            "P",
            "M",
            "G"});
            this.cbTransporte.Location = new System.Drawing.Point(228, 26);
            this.cbTransporte.Name = "cbTransporte";
            this.cbTransporte.Size = new System.Drawing.Size(83, 29);
            this.cbTransporte.TabIndex = 3;
            this.cbTransporte.SelectedIndexChanged += new System.EventHandler(this.cbTransporte_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "VALOR UF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "QTD DE PROFISSIONAIS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "TAMANHO DO TRANSPORTE:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbCredito);
            this.groupBox3.Controls.Add(this.txtCredito);
            this.groupBox3.Controls.Add(this.txtAvista);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(12, 564);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 112);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIPO DE PAGAMENTO:";
            // 
            // cbCredito
            // 
            this.cbCredito.FormattingEnabled = true;
            this.cbCredito.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbCredito.Location = new System.Drawing.Point(349, 27);
            this.cbCredito.Name = "cbCredito";
            this.cbCredito.Size = new System.Drawing.Size(121, 29);
            this.cbCredito.TabIndex = 4;
            this.cbCredito.SelectedIndexChanged += new System.EventHandler(this.cbCredito_SelectedIndexChanged);
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(349, 62);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(121, 29);
            this.txtCredito.TabIndex = 3;
            this.txtCredito.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtAvista
            // 
            this.txtAvista.Location = new System.Drawing.Point(94, 24);
            this.txtAvista.Name = "txtAvista";
            this.txtAvista.Size = new System.Drawing.Size(121, 29);
            this.txtAvista.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(253, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CRÉDITO";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "À VISTA";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 696);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcula Frete";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lblData;
        private ComboBox cbUF;
        private TextBox txtDestino;
        private TextBox txtNome;
        private TextBox txtOrigem;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private Label label11;
        private Label label10;
        private ComboBox cbProfissional;
        private ComboBox cbTransporte;
        private Label label9;
        private Label label8;
        private Label label5;
        private PictureBox pictureBox1;
        private Label lblValTotal;
        private Label lblValProf;
        private Label lblValTransp;
        private Label lblValUF;
        private Label label12;
        private GroupBox groupBox3;
        private ComboBox cbCredito;
        private TextBox txtCredito;
        private TextBox txtAvista;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnConcluir;
        private Button btnLimpar;
        private Label label13;
        private Label lblDesconto;
    }
}