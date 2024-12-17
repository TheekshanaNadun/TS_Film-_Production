using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiet_Attic_Film__Production
{
    public partial class Production : Form
    {
        public Production()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Production where Production_Id='" + textBox1.Text + "'";
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Data Is Successfully Deleted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True";
            conn.Open();
            SqlCommand cmd = new SqlCommand(" insert into Production values(@Production_Id,@Name,@Type,@Client_Id)", conn);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Production_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Type", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Client_Id",int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Is Successfully Inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True";
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Production set Production_Id=@Production_Id,Name=@Name,Type=@Type,Client_Id=@Client_Id where Production_Id=@Production_Id", conn);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Production_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Type", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Client_Id", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Is Successfully Updated"); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Production_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            MainMenu M1 = new MainMenu();
            M1.Show();
            this.Hide();
        }
    }
}
