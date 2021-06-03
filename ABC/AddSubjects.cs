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
    public partial class AddSubjects : Form
    {
        public AddSubjects()
        {
            InitializeComponent();
        }

        SqlConnection ABC = new SqlConnection(@"Server=tcp:oshini.database.windows.net,1433;Initial Catalog=TimeTableDb;Persist Security Info=False;User ID=oshini;Password=Punsara2005*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        SqlCommand command = new SqlCommand();
        SqlDataReader dataSearch;

        private void AddSubjects_Load(object sender, EventArgs e)
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
            if (comboBox1.Text != "" & comboBox2.Text != "" & textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "")
            {
                ABC.Open();
                command.CommandText = "insert into subject(yr,sem,name,code,leHo,tHo,laHo,eHo) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Subject information successfully saved in the database");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                View();
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

            command.CommandText = "Select * from subject";

            dataSearch = command.ExecuteReader();

            if (dataSearch.HasRows)
            {
                while (dataSearch.Read())
                {

                    listBox1.Items.Add(dataSearch["yr"].ToString());
                    listBox2.Items.Add(dataSearch["sem"].ToString());
                    listBox3.Items.Add(dataSearch["name"].ToString());
                    listBox4.Items.Add(dataSearch["code"].ToString());
                    listBox5.Items.Add(dataSearch["leHo"].ToString());
                    listBox6.Items.Add(dataSearch["tHo"].ToString());
                    listBox7.Items.Add(dataSearch["laHo"].ToString());
                    listBox8.Items.Add(dataSearch["eHo"].ToString());

                }
            }

            ABC.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                ABC.Open();
                command.CommandText = "delete from subject where code='" + textBox2.Text + "'";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Subject information deleted successfully");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;

                View();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" & comboBox2.Text != "" & textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "")
            {
                ABC.Open();                                                                                                                                                                                                                                             //fullName='" + listBox1.Text.ToString() + "' and
                                                                                                                                                                                                                                                                        //yr,sem,name,code,leHo,tHo,laHo,eHo
                command.CommandText = "Update subject set yr = '" + comboBox1.Text + "',sem = '" + comboBox2.Text + "',name='" + textBox1.Text + "',code = '" + textBox2.Text + "',leHo='" + textBox3.Text + "',tHo='" + textBox4.Text + "',laHo='" + textBox5.Text + "',eHo='" + textBox6.Text + "'where yr='" + listBox1.SelectedItem.ToString() + "' sem='" + listBox2.SelectedItem.ToString() + "' and code='" + listBox3.Text.ToString() + "' and name='" + listBox4.Text.ToString() + "' and leHo='" + listBox5.Text.ToString() + "' and tHo='" + listBox6.Text.ToString() + "' and laHo='" + listBox7.Text.ToString() + "' and eHo='" + listBox8.Text.ToString() + "'";

                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("subject information updated successfully");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;

                View();


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

                comboBox1.Text = listBox1.SelectedItem.ToString();
                comboBox2.Text = listBox2.SelectedItem.ToString();
                textBox1.Text = listBox3.SelectedItem.ToString();
                textBox2.Text = listBox4.SelectedItem.ToString();
                textBox3.Text = listBox5.SelectedItem.ToString();
                textBox4.Text = listBox6.SelectedItem.ToString();
                textBox5.Text = listBox7.SelectedItem.ToString();
                textBox6.Text = listBox8.SelectedItem.ToString();


            }
        }
    }
}
