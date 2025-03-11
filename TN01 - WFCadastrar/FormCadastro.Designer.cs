namespace TN01___WFCadastrar
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
            label1 = new Label();
            mkdtelefone = new MaskedTextBox();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dtpDatadenascimento = new DateTimePicker();
            txtNomeCompleto = new TextBox();
            lblEscolaridade = new Label();
            cbxEscolaridade = new ComboBox();
            groupBox1 = new GroupBox();
            RdbNaoinformado = new RadioButton();
            RdbFeminino = new RadioButton();
            rdbMasculino = new RadioButton();
            bntRendaMensal = new Label();
            nudRendaMensal = new NumericUpDown();
            chkPossuiFilhos = new CheckBox();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRendaMensal).BeginInit();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(34, 21);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 106);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Telefone";
            // 
            // mkdtelefone
            // 
            mkdtelefone.Location = new Point(30, 146);
            mkdtelefone.Mask = "(99) 00000-0000";
            mkdtelefone.Name = "mkdtelefone";
            mkdtelefone.Size = new Size(100, 23);
            mkdtelefone.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(517, 54);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 4;
            label2.Text = "Data de nascimento";
            // 
            // dtpDatadenascimento
            // 
            dtpDatadenascimento.Format = DateTimePickerFormat.Short;
            dtpDatadenascimento.Location = new Point(492, 98);
            dtpDatadenascimento.Name = "dtpDatadenascimento";
            dtpDatadenascimento.Size = new Size(200, 23);
            dtpDatadenascimento.TabIndex = 3;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(24, 51);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(250, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // lblEscolaridade
            // 
            lblEscolaridade.AutoSize = true;
            lblEscolaridade.Location = new Point(241, 106);
            lblEscolaridade.Name = "lblEscolaridade";
            lblEscolaridade.Size = new Size(73, 15);
            lblEscolaridade.TabIndex = 7;
            lblEscolaridade.Text = "Escolaridade";
            // 
            // cbxEscolaridade
            // 
            cbxEscolaridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEscolaridade.FormattingEnabled = true;
            cbxEscolaridade.Items.AddRange(new object[] { "Anafalbeto", "Ensino Fundamental Incompleto", "Ensino Fundamental Completo", "Ensino Médio Incompleto", "Ensino Médio Completo", "Ensino Técnico Incompleto", "Ensino Técnico Completo", "Ensino Superior Incompleto", "Ensino Superior Completo", "Pós - Graduação Incompleto", "Pós - Graduação Completo" });
            cbxEscolaridade.Location = new Point(229, 146);
            cbxEscolaridade.Name = "cbxEscolaridade";
            cbxEscolaridade.Size = new Size(121, 23);
            cbxEscolaridade.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RdbNaoinformado);
            groupBox1.Controls.Add(RdbFeminino);
            groupBox1.Controls.Add(rdbMasculino);
            groupBox1.Location = new Point(30, 230);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo";
            // 
            // RdbNaoinformado
            // 
            RdbNaoinformado.AutoSize = true;
            RdbNaoinformado.Location = new Point(75, 79);
            RdbNaoinformado.Name = "RdbNaoinformado";
            RdbNaoinformado.Size = new Size(106, 19);
            RdbNaoinformado.TabIndex = 3;
            RdbNaoinformado.TabStop = true;
            RdbNaoinformado.Text = "Não informado";
            RdbNaoinformado.UseVisualStyleBackColor = true;
            // 
            // RdbFeminino
            // 
            RdbFeminino.AutoSize = true;
            RdbFeminino.Location = new Point(37, 49);
            RdbFeminino.Name = "RdbFeminino";
            RdbFeminino.Size = new Size(75, 19);
            RdbFeminino.TabIndex = 2;
            RdbFeminino.TabStop = true;
            RdbFeminino.Text = "Feminino";
            RdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(15, 20);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 1;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // bntRendaMensal
            // 
            bntRendaMensal.AutoSize = true;
            bntRendaMensal.Location = new Point(390, 230);
            bntRendaMensal.Name = "bntRendaMensal";
            bntRendaMensal.Size = new Size(81, 15);
            bntRendaMensal.TabIndex = 10;
            bntRendaMensal.Text = "Renda Mensal";
            // 
            // nudRendaMensal
            // 
            nudRendaMensal.DecimalPlaces = 2;
            nudRendaMensal.Location = new Point(390, 262);
            nudRendaMensal.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudRendaMensal.Name = "nudRendaMensal";
            nudRendaMensal.Size = new Size(120, 23);
            nudRendaMensal.TabIndex = 6;
            // 
            // chkPossuiFilhos
            // 
            chkPossuiFilhos.AutoSize = true;
            chkPossuiFilhos.Checked = true;
            chkPossuiFilhos.CheckState = CheckState.Indeterminate;
            chkPossuiFilhos.Location = new Point(578, 311);
            chkPossuiFilhos.Name = "chkPossuiFilhos";
            chkPossuiFilhos.Size = new Size(94, 19);
            chkPossuiFilhos.TabIndex = 12;
            chkPossuiFilhos.Text = "Possui Filhos";
            chkPossuiFilhos.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(414, 334);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 67);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkPossuiFilhos);
            Controls.Add(nudRendaMensal);
            Controls.Add(bntRendaMensal);
            Controls.Add(groupBox1);
            Controls.Add(cbxEscolaridade);
            Controls.Add(lblEscolaridade);
            Controls.Add(txtNomeCompleto);
            Controls.Add(dtpDatadenascimento);
            Controls.Add(label2);
            Controls.Add(mkdtelefone);
            Controls.Add(label1);
            Controls.Add(lblNomeCompleto);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pessoas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRendaMensal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private Label label1;
        private MaskedTextBox mkdtelefone;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker dtpDatadenascimento;
        private TextBox txtNomeCompleto;
        private Label lblEscolaridade;
        private ComboBox cbxEscolaridade;
        private GroupBox groupBox1;
        private RadioButton RdbNaoinformado;
        private RadioButton RdbFeminino;
        private RadioButton rdbMasculino;
        private Label bntRendaMensal;
        private NumericUpDown nudRendaMensal;
        private CheckBox chkPossuiFilhos;
        private Button btnSalvar;
    }
}