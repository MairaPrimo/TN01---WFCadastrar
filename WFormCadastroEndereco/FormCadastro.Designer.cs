namespace WFormCadastroEndereco
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblNomeCompleto = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtNomeCompleto = new TextBox();
            btnSalvar = new Button();
            txtLogradouro = new TextBox();
            lblCep = new Label();
            label1 = new Label();
            mtbCep = new MaskedTextBox();
            lblLogradouro = new Label();
            lblNumero = new Label();
            lblbairro = new Label();
            lblUF = new Label();
            lblCidade = new Label();
            lblComplemento = new Label();
            txtNumero = new TextBox();
            chkSemNumero = new CheckBox();
            txtComplemento = new TextBox();
            txtCidade = new TextBox();
            cbxUf = new ComboBox();
            txtBairro = new TextBox();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(21, 40);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(21, 80);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(376, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(446, 429);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(106, 67);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(21, 278);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(257, 23);
            txtLogradouro.TabIndex = 10;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(21, 169);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 11;
            lblCep.Text = "CEP";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(21, 141);
            label1.Name = "label1";
            label1.Size = new Size(376, 1);
            label1.TabIndex = 11;
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(21, 191);
            mtbCep.Mask = "00000-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(228, 23);
            mtbCep.TabIndex = 12;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(21, 241);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 13;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(346, 241);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 14;
            lblNumero.Text = "Número";
            lblNumero.TextAlign = ContentAlignment.TopRight;
            // 
            // lblbairro
            // 
            lblbairro.AutoSize = true;
            lblbairro.Location = new Point(317, 368);
            lblbairro.Name = "lblbairro";
            lblbairro.Size = new Size(38, 15);
            lblbairro.TabIndex = 15;
            lblbairro.Text = "Bairro";
            lblbairro.TextAlign = ContentAlignment.TopRight;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Location = new Point(228, 418);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(21, 15);
            lblUF.TabIndex = 16;
            lblUF.Text = "UF";
            lblUF.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(21, 397);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 17;
            lblCidade.Text = "Cidade";
            lblCidade.TextAlign = ContentAlignment.TopRight;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(21, 328);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 19;
            lblComplemento.Text = "Complemento";
            lblComplemento.TextAlign = ContentAlignment.TopRight;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(335, 276);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 23;
            // 
            // chkSemNumero
            // 
            chkSemNumero.AutoSize = true;
            chkSemNumero.Location = new Point(466, 280);
            chkSemNumero.Name = "chkSemNumero";
            chkSemNumero.Size = new Size(96, 19);
            chkSemNumero.TabIndex = 24;
            chkSemNumero.Text = "Sem Número";
            chkSemNumero.UseVisualStyleBackColor = true;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(21, 360);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(214, 23);
            txtComplemento.TabIndex = 25;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(21, 415);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(135, 23);
            txtCidade.TabIndex = 26;
            // 
            // cbxUf
            // 
            cbxUf.FormattingEnabled = true;
            cbxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUf.Location = new Point(266, 415);
            cbxUf.Name = "cbxUf";
            cbxUf.Size = new Size(66, 23);
            cbxUf.TabIndex = 27;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(372, 365);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(180, 23);
            txtBairro.TabIndex = 28;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 551);
            Controls.Add(txtBairro);
            Controls.Add(cbxUf);
            Controls.Add(txtCidade);
            Controls.Add(txtComplemento);
            Controls.Add(chkSemNumero);
            Controls.Add(txtNumero);
            Controls.Add(lblComplemento);
            Controls.Add(lblCidade);
            Controls.Add(lblUF);
            Controls.Add(lblbairro);
            Controls.Add(lblNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(mtbCep);
            Controls.Add(label1);
            Controls.Add(lblCep);
            Controls.Add(txtLogradouro);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pessoas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtNomeCompleto;
        private Button btnSalvar;
        private TextBox txtLogradouro;
        private Label lblCep;
        private Label label1;
        private MaskedTextBox mtbCep;
        private Label lblLogradouro;
        private Label lblNumero;
        private Label lblbairro;
        private Label lblUF;
        private Label lblCidade;
        private Label lblComplemento;
        private TextBox txtNumero;
        private CheckBox chkSemNumero;
        private TextBox txtComplemento;
        private TextBox txtCidade;
        private ComboBox cbxUf;
        private TextBox txtBairro;
    }
}