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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void IdPesquisa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pesqId.Text))
            {
                MessageBox.Show("Coloque o ID para pesquisar.");
                return;
            }

            SqlConnection connection = new SqlConnection("Data Source=FAC0539674W10-1;Initial Catalog=Estetica;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();


            SqlCommand cmd = new SqlCommand("SELECT NomeModelo, DtNasc, Telefone, Email FROM Modelo WHERE IdModelo = " + pesqId.Text, connection);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Nome.Text = reader["NomeModelo"].ToString();
                Data.Text = reader["DtNasc"].ToString();
                Tel.Text = reader["Telefone"].ToString();
                Email.Text = reader["Email"].ToString();

            }
            else
            {
                MessageBox.Show("ID não encontrado.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
