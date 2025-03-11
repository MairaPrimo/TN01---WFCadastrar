using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01___WFCadastrar
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            cbxEscolaridade.SelectedIndex = 0;
        }
        private void LimpaFormulario()
        {
            txtNomeCompleto.Clear();
            mkdtelefone.Clear();
            dtpDatadenascimento.Value = DateTime.Now;
            cbxEscolaridade.SelectedIndex = 0;
            RdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
            RdbNaoinformado.Checked = false;
            nudRendaMensal.Value = 0;
            chkPossuiFilhos.CheckState =
                CheckState.Indeterminate;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
     

                Pessoa p1 = new Pessoa();

                p1.NomeCompleto = txtNomeCompleto.Text;

                p1.DddTelefone = mkdtelefone.Text;

                p1.DataNascimento = dtpDatadenascimento.Value;

                p1.Escolaridade = cbxEscolaridade.SelectedText;

                if (rdbMasculino.Checked)

                {

                    p1.sexo = 'M';

                }

                else if (RdbFeminino.Checked)

                {

                    p1.sexo = 'F';

                }

                else if (RdbNaoinformado.Checked)

                {

                    p1.sexo = 'N';

                }

                else

                {

                    MessageBox.Show("O Sexo não definido! ");

                    return;

                }

                if (chkPossuiFilhos.CheckState == CheckState.Checked)

                {

                    p1.PossuiFilhos = true;

                }

                else if (chkPossuiFilhos.CheckState == CheckState.Unchecked)

                {

                    p1.PossuiFilhos = false;

                }

                else

                {

                    MessageBox.Show("Faltou marcar se tem Filhos!");

                    return;

                }

            Pessoa.ListaPessoas.Add(p1);

            MessageBox.Show("Cadastro realizado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        }

    }



