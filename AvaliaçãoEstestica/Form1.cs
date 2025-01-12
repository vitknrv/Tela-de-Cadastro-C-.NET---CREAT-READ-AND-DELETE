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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Telefones.Text.All(char.IsDigit))
            {
                MessageBox.Show("O campo deve conter apenas números.");

                return;
            }

            if (string.IsNullOrWhiteSpace(NomeModelo.Text) || string.IsNullOrWhiteSpace(datanasc.Text) || string.IsNullOrWhiteSpace(emaail.Text)) 
            {
                MessageBox.Show("É necessário preencher todos os campos.");
            }

            else
            {
                SqlConnection connection = new SqlConnection("Data Source=FAC0539674W10-1;Initial Catalog=Estetica;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                connection.Open();

                SqlCommand cmd = new SqlCommand("insert into Modelo values('" + NomeModelo.Text + "','" + datanasc.Text + " ', '" + emaail.Text + "', '" + Telefones.Text + "')", connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados cadastrados com sucesso.");

                
            }





        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}