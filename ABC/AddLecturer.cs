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
    public partial class AddLecturer : Form
    {
        public AddLecturer()
        {
            InitializeComponent();
        }


        SqlConnection ABC = new SqlConnection(@"Server=tcp:oshini.database.windows.net,1433;Initial Catalog=TimeTableDb;Persist Security Info=False;User ID=oshini;Password=Punsara2005*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlCommand command = new SqlCommand();
        SqlDataReader dataSearch;

        private void AddLecturer_Load(object sender, EventArgs e)
        {
            command.Connection = ABC;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & comboBox1.Text != "" & comboBox3.Text != "" & comboBox2.Text != "" & comboBox4.Text != "" & comboBox5.Text != "" & textBox3.Text != "" & comboBox6.Text!= "" & comboBox7.Text != "")
            {
                ABC.Open();
                command.CommandText = "insert into dbo.lecturer(fullName,eID,campus,faculty,department,building,level,rank,availableDays,availableTime) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "','" + comboBox2.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + textBox3.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "')";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Lecturer information successfully saved in the database");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;
                comboBox7.SelectedIndex = -1;

                View();
            }
        }

        public void View()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();

            ABC.Open();

            command.CommandText = "Select * from lecturer";

            dataSearch = command.ExecuteReader();

            if (dataSearch.HasRows)
            {
                while (dataSearch.Read())
                {

                    listBox1.Items.Add(dataSearch["fullName"].ToString());
                    listBox2.Items.Add(dataSearch["eID"].ToString());
                    listBox3.Items.Add(dataSearch["campus"].ToString());
                    listBox4.Items.Add(dataSearch["faculty"].ToString());
                    listBox5.Items.Add(dataSearch["department"].ToString());
                    listBox6.Items.Add(dataSearch["building"].ToString());
                    listBox7.Items.Add(dataSearch["level"].ToString());
                    listBox8.Items.Add(dataSearch["rank"].ToString());
                    listBox9.Items.Add(dataSearch["availableDays"].ToString());
                    listBox10.Items.Add(dataSearch["availableTime"].ToString());
                }
            }

            ABC.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                ABC.Open();
                command.CommandText = "delete from lecturer where eID='" + textBox2.Text + "'";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Lecturer information deleted successfully");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;
                comboBox7.SelectedIndex = -1;

                View();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & comboBox1.Text != "" & comboBox3.Text != "" & comboBox2.Text != "" & comboBox4.Text != "" & comboBox4.Text != "" & textBox3.Text != "" & comboBox6.Text != "" & comboBox7.Text != "")
            {

                ABC.Open();
                command.CommandText = "Update lecturer set fullname='"
                    + textBox1.Text + "',campus = '" + comboBox1.Text + "',faculty='"
                    + comboBox3.Text + "',department='" + comboBox2.Text + "',building='"
                    + comboBox4.Text + "',level='" + comboBox5.Text + "',rank='" + textBox3.Text
                    + "',availableDays='" + comboBox6.Text + "', availabletime='" + comboBox7.Text + "' " +



                    "where fullName='" + listBox1.Text.ToString() + "' and eID='" + listBox2.Text.ToString()
                    + "'and campus='" + listBox3.SelectedItem.ToString() + "'and faculty='" + listBox4.SelectedItem.ToString()
                    + "' and department='" + listBox5.SelectedItem.ToString() + "' and building='" + listBox6.SelectedItem.ToString() +
                    "'and level='" + listBox7.SelectedItem.ToString() + "' and rank='" + listBox8.Text.ToString() +
                    "' and availableDays='" + listBox9.SelectedItem.ToString() + "' and availableTime = '" + listBox10.SelectedItem.ToString() + "'";

                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("lecturer information updated successfully");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;
                comboBox7.SelectedIndex = -1;

                View();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    listBox9.SelectedIndex = list.SelectedIndex;
                    listBox10.SelectedIndex = list.SelectedIndex;

                    //Retrieve to textBox of allowDrop events



                    textBox1.Text = listBox1.SelectedItem.ToString();
                    textBox2.Text = listBox2.SelectedItem.ToString();
                    comboBox1.Text = listBox4.SelectedItem.ToString();
                    comboBox3.Text = listBox5.SelectedItem.ToString();
                    comboBox2.Text = listBox6.SelectedItem.ToString();
                    comboBox4.Text = listBox7.SelectedItem.ToString();
                    comboBox5.Text = listBox8.SelectedItem.ToString();
                    textBox3.Text = listBox3.SelectedItem.ToString();
                    comboBox6.Text = listBox9.SelectedItem.ToString();
                    comboBox7.Text = listBox10.SelectedItem.ToString();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View();
        }

		private void button1_Click_1(object sender, EventArgs e)
        {
            String b = textBox2.Text;
            String a = comboBox5.Text;
            String c = a + b;
            textBox3.Text = c;

        }
	}
}
