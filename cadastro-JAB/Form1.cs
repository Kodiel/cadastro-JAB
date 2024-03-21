using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace cadastro_JAB
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }



        SqlConnection sqlCon = null;
        string strCon = $"Data Source= GABRIEL\\SQLGABRIEL;Initial Catalog= banco;Integrated Security=True; TrustServerCertificate= true";
        private string querry = null;


        private void confirma_cad_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string endereco = txtEndereco.Text;
            string telefone = txtTel.Text;
            string email = txtEmail.Text;
            DateTime nascimento = pickerNascimento.Value;
            char sexo = ' ';
            if (boxF.Checked)
            {
                sexo = 'F';
            }
            else if (boxM.Checked)
            {
                sexo = 'M';
            }

            if (VerificaNome(nome) && VerificaCpf(cpf) && VerificaTel(telefone) && VerificaSexo())
            {

                sqlCon = new SqlConnection(strCon);


                using (sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    querry = "insert into usuarios (nome, cpf, endereco, telefone, email, data_nascimento, sexo) values (@nome, @cpf, @endereco, @telefone, @email, @data_nascimento, @sexo)";
                    using (SqlCommand cmd = new SqlCommand(querry, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@CPF", cpf);
                        cmd.Parameters.AddWithValue("@Endereco", endereco);
                        cmd.Parameters.AddWithValue("@Telefone", telefone);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Data_Nascimento", nascimento);
                        cmd.Parameters.AddWithValue("@Sexo", sexo);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dados inseridos com sucesso!");
                            limpar();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao inserir os dados.");
                        }
                    }
                }
            }
            
        }

        private void limpar()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            boxM.Checked = false;
            boxF.Checked = false;
        }
        private void limpa_cad_Click(object sender, EventArgs e)
        {
            limpar();
            MessageBox.Show("Formulário limpo.");
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        public bool VerificaNome(string nome)
        {
            Regex regex = new Regex("^[a-zA-Z ]+$");

            if (regex.IsMatch(nome))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Nome inválido");
                txtNome.Clear();
                return false;
            }
        }

        public bool VerificaCpf(string cpf)
        {
            
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            
            if (cpf.Length != 11)
            {
                MessageBox.Show("CPF inválido");
                txtCpf.Clear();
                return false;
            }

          
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }
            int primeiroDigitoVerificador = 11 - (soma % 11);
            if (primeiroDigitoVerificador >= 10)
            {
                primeiroDigitoVerificador = 0;
            }

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }
            int segundoDigitoVerificador = 11 - (soma % 11);
            if (segundoDigitoVerificador >= 10)
            {
                segundoDigitoVerificador = 0;
            }

            
            if (int.Parse(cpf[9].ToString()) != primeiroDigitoVerificador || int.Parse(cpf[10].ToString()) != segundoDigitoVerificador)
            {
                MessageBox.Show("CPF inválido");
                txtCpf.Clear();
                return false;
            }

            return true;
        }

        public bool VerificaTel(string tel)
        {
            if (tel.Length == 10)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Telefone inválido. Deve conter 10 dígitos.");
                return false;
            }
        }


        private void boxM_CheckedChanged(object sender, EventArgs e)
        {
            if(boxM.Checked)
            {
                boxF.Checked = false;
            }
        }

        private void boxF_CheckedChanged(object sender, EventArgs e)
        {
            if(boxF.Checked)
            {
                boxM.Checked = false;
            }
        }

        private bool VerificaSexo()
        {
            if(!boxF.Checked && !boxM.Checked)
            {
                MessageBox.Show("A opção de escolha de sexo é obrigatória! Por favor marcar uma!");
                return false;
            }
            else { return true; }
        }
    }
}
