using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABC
{
    public partial class AddSession : Form
    {
        public AddSession()
        {
            InitializeComponent();
        }

        SqlConnection ABC = new SqlConnection(@"Server=tcp:oshini.database.windows.net,1433;Initial Catalog=TimeTableDb;Persist Security Info=False;User ID=oshini;Password=Punsara2005*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        SqlCommand command = new SqlCommand();
        SqlDataReader dataSearch;

        private void AddSession_Load(object sender, EventArgs e)
        {
            command.Connection = ABC;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ABC.Open();
                command.CommandText = "delete from session where seID='" + textBox1.Text + "'";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Session information deleted successfully");

                textBox1.Clear();
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                textBox4.Clear();
                textBox5.Clear();

                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;

                View();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & comboBox4.Text != "" & comboBox5.Text != "" & comboBox1.Text != "" & comboBox2.Text != "" & textBox4.Text != "" & comboBox3.Text != "" & textBox5.Text != "")
            {
                ABC.Open();
                command.CommandText = "insert into session(seID , fLec, sLec, tag, grp, nStu, sub, dur) values('" + textBox1.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + comboBox3.Text + "','" + textBox5.Text + "')";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Session information successfully saved in the database");
                textBox1.Clear();
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                textBox4.Clear();
                textBox5.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;

               // View();
            }
        }
        private void View()
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();


            ABC.Open();

            command.CommandText = "Select * from session";

            dataSearch = command.ExecuteReader();

            if (dataSearch.HasRows)
            {
                while (dataSearch.Read())
                {

                    listBox1.Items.Add(dataSearch["seID"].ToString());
                    listBox2.Items.Add(dataSearch["fLec"].ToString());
                    listBox3.Items.Add(dataSearch["sLec"].ToString());
                    listBox4.Items.Add(dataSearch["tag"].ToString());
                    listBox5.Items.Add(dataSearch["grp"].ToString());
                    listBox6.Items.Add(dataSearch["nStu"].ToString());
                    listBox7.Items.Add(dataSearch["sub"].ToString());
                    listBox8.Items.Add(dataSearch["dur"].ToString());

                }
            }

            ABC.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & comboBox4.Text != "" & comboBox5.Text != "" & comboBox1.Text != "" & comboBox2.Text != "" & textBox4.Text != "" & comboBox3.Text != "" & textBox5.Text != "")
            {
                ABC.Open();


                command.CommandText = "update session set seID='" + textBox1.Text + "' , fLec = '" + comboBox4.Text + "' , sLec = '" + comboBox5.Text + "' , tag='" + comboBox1.Text + "', grp='" + comboBox2.Text + "' , nStu = '" + textBox4.Text + "' , sub = '" + textBox4.Text + "', dur = '" + textBox5.Text + "' where seID='" + listBox1.SelectedItem.ToString() + "' and fLec = '" + listBox2.SelectedItem.ToString() + "' and sLec = '" + listBox3.SelectedItem.ToString() + "' and tag='" + listBox4.SelectedItem.ToString() + "' and grp = '" + listBox5.SelectedItem.ToString() + "' and nStu = '" + listBox6.SelectedItem.ToString() + "' and sub = '" + listBox7.SelectedItem.ToString() + "' and dur = '" + listBox8.SelectedItem.ToString() + "'";
                command.ExecuteNonQuery();
                ABC.Close();

                MessageBox.Show("Data Updated Successfully..!");
                textBox1.Clear();
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                textBox4.Clear();
                textBox5.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;
            if (list.SelectedIndex != -1)
            {

                listBox1.SelectedIndex = list.SelectedIndex;
                listBox2.SelectedIndex = list.SelectedIndex;
                listBox3.SelectedIndex = list.SelectedIndex;
                listBox4.SelectedIndex = list.SelectedIndex;
                listBox5.SelectedIndex = list.SelectedIndex;
                listBox6.SelectedIndex = list.SelectedIndex;
                listBox7.SelectedIndex = list.SelectedIndex;
                listBox8.SelectedIndex = list.SelectedIndex;


                //Retrieve to textBox of allowDrop events

                textBox1.Text = listBox1.SelectedItem.ToString();
                comboBox4.Text = listBox2.SelectedItem.ToString();
                comboBox5.Text = listBox3.SelectedItem.ToString();
                comboBox1.Text = listBox4.SelectedItem.ToString();
                comboBox2.Text = listBox5.SelectedItem.ToString();
                textBox4.Text = listBox6.SelectedItem.ToString();
                comboBox3.Text = listBox7.SelectedItem.ToString();
                textBox5.Text = listBox8.SelectedItem.ToString();
            }
        }

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
            View();
		}
	}
}
