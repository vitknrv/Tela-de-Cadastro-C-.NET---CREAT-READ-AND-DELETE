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
    public partial class Form9 : Form
    {
        public Form9()
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


            SqlCommand cmd = new SqlCommand("SELECT NomeEst, DtEst, EmailEst, Genero, Estado FROM Esteticista WHERE IdEst = " + pesqId.Text, connection);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                NomeEst.Text = reader["NomeEst"].ToString();
                DtEst.Text = reader["DtEst"].ToString();
                EmailEst.Text = reader["EmailEst"].ToString();
                Genero.Text = reader["Genero"].ToString();
                Estado.Text = reader["Estado"].ToString();

            }
            else
            {
                MessageBox.Show("ID não encontrado.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
