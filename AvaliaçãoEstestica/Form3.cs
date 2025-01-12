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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
                name.Text = reader["NomeModelo"].ToString();
                dt.Text = reader["DtNasc"].ToString();
                tel.Text = reader["Telefone"].ToString();
                em.Text = reader["Email"].ToString();

            }
            else
            {
                MessageBox.Show("ID não encontrado.");
            }
        }

        private void excl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pesqId.Text))
            {
                MessageBox.Show("Coloque o ID para excluir.");
                return;
            }

            SqlConnection connection = new SqlConnection("Data Source=FAC0539674W10-1;Initial Catalog=Estetica;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Modelo WHERE IdModelo = " + pesqId.Text, connection);

            int resultado = cmd.ExecuteNonQuery();

            if (resultado > 0)
            {
                MessageBox.Show("Registro excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado com esse ID.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
