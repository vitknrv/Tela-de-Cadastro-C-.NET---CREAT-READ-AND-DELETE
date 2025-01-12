using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace AvaliaçãoEstestica
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            Estados();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string retorno = ValidarCampos();
            string genero = ValidarGenero();

            if (retorno == "OK" && genero != "")
            {
                BancoDeDados(NomeEst.Text, DtEst.Text, EmailEst.Text, estado.SelectedItem.ToString(), genero);
                MessageBox.Show("Cadastro realizado com sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show(retorno + " " + genero);
            }
        }

        public void Estados()
        {
            estado.Items.Add("Acre (AC)");
            estado.Items.Add("Alagoas (AL)");
            estado.Items.Add("Amapá (AP)");
            estado.Items.Add("Amazonas (AM)");
            estado.Items.Add("Bahia (BA)");
            estado.Items.Add("Ceará (CE)");
            estado.Items.Add("Distrito Federal (DF)");
            estado.Items.Add("Espírito Santo (ES)");
            estado.Items.Add("Goiás (GO)");
            estado.Items.Add("Maranhão (MA)");
            estado.Items.Add("Mato Grosso (MT)");
            estado.Items.Add("Mato Grosso do Sul (MS)");
            estado.Items.Add("Minas Gerais (MG)");
            estado.Items.Add("Pará (PA)");
            estado.Items.Add("Paraíba (PB)");
            estado.Items.Add("Paraná (PR)");
            estado.Items.Add("Pernambuco (PE)");
            estado.Items.Add("Piauí (PI)");
            estado.Items.Add("Rio de Janeiro (RJ)");
            estado.Items.Add("Rio Grande do Norte (RN)");
            estado.Items.Add("Rio Grande do Sul (RS)");
            estado.Items.Add("Rondônia (RO)");
            estado.Items.Add("Roraima (RR)");
            estado.Items.Add("Santa Catarina (SC)");
            estado.Items.Add("São Paulo (SP)");
            estado.Items.Add("Sergipe (SE)");
            estado.Items.Add("Tocantins (TO)");
        }

        public string ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(NomeEst.Text))
            {
                return "Necessário preencher o nome.";
            }
            if (string.IsNullOrWhiteSpace(DtEst.Text))
            {
                return "Necessário preencher a Data de Nascimento.";
            }
            if (string.IsNullOrWhiteSpace(EmailEst.Text))
            {
                return "Necessário informar seu e-mail";
            }
            if (estado.SelectedIndex == -1)
            {
                return "Selecione um Estado.";
            }
            if (!termos.Checked)
            {
                return "Você deve aceitar os termos para continuar.";
            }

            return "OK";
        }
        public string ValidarGenero()
        {
            string genero = "";
            if (masc.Checked)
            {
                genero = "Masculino";
            }
            else if (fem.Checked)
            {
                genero = "Feminino";
            }
            else if (outro.Checked)
            {
                genero = "Outro";
            }
            else
            {
                return "Para cadastrar é necessário informar seu gênero.";
            }

            return genero;
        }
        public void LimparCampos()
        {
            NomeEst.Clear();
            DtEst.Clear();
            EmailEst.Clear();
            masc.Checked = false;
            fem.Checked = false;
            outro.Checked = false;
            estado.SelectedIndex = -1;
            termos.Checked = false;
        }
        private void BancoDeDados(string nome, string dt, string email, string estado, string genero)
        {
            SqlConnection connection = new SqlConnection("Data Source=FAC0539674W10-1;Initial Catalog=Estetica;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                connection.Open();
                string query = "INSERT INTO Esteticista (NomeEst, DtEst, EmailEst, Estado, Genero) VALUES (@Nome, @Dt, @Email, @Estado, @Genero)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Dt", dt);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@Genero", genero);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
