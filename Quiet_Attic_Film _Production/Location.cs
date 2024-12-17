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

namespace Quiet_Attic_Film__Production
{
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True";
            conn.Open();
            SqlCommand cmd = new SqlCommand(" insert into Location values(@Location_Id,@Name,@Address)", conn);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Location_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Address",textBox3.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Is Successfully Inserted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Location where Location _Id='" + textBox1.Text + "'";
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Data Is Successfully Deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True";
            conn.Open();
            SqlCommand cmd = new SqlCommand(" update Location set Location_Id=@Location_Id,Name=@Name,Address=@Address where Location_Id=@Location_Id", conn);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Location_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Is Successfully Updated");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Location_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
