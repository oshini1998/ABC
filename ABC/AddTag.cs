using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABC
{
    public partial class AddTag : Form
    {
        public AddTag()
        {
            InitializeComponent();
        }


        SqlConnection ABC = new SqlConnection(@"Server=tcp:oshini.database.windows.net,1433;Initial Catalog=TimeTableDb;Persist Security Info=False;User ID=oshini;Password=Punsara2005*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        SqlCommand command = new SqlCommand();
        SqlDataReader dataSearch;

        private void AddTag_Load(object sender, EventArgs e)
        {
            command.Connection = ABC;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" & comboBox2.Text != "" & comboBox3.Text != "")
            {

                ABC.Open();
                command.CommandText = "INSERT INTO tblTag(TagName,TagCode,RelatedTag) Values('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + comboBox3.Text + "')";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Data Saved Successfully..!");

                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;


                Search();


            }
        }

        private void Search()
        {

            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();


            ABC.Open();

            command.CommandText = "Select * from tblTag";

            dataSearch = command.ExecuteReader();
            if (dataSearch.HasRows)
            {
                while (dataSearch.Read())

                {


                    listBox2.Items.Add(dataSearch["TagName"].ToString());
                    listBox3.Items.Add(dataSearch["TagCode"].ToString());
                    listBox4.Items.Add(dataSearch["RelatedTag"].ToString());

                }
            }

            ABC.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" & comboBox2.Text != "" & comboBox3.Text != "")
            {

                ABC.Open();
                command.CommandText = "Update tblTag set TagName='" + comboBox1.Text + "', TagCode='" + comboBox2.Text + "', RelatedTag='" + comboBox3.Text + "' where TagName='" + listBox2.SelectedItem.ToString() + "' and TagCode='" + listBox3.SelectedItem.ToString() + "' and RelatedTag='" + listBox4.SelectedItem.ToString() + "'";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Data Updated Successfully..!");

                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;


                Search();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;
            if (list.SelectedIndex != -1)
            {

                listBox2.SelectedIndex = list.SelectedIndex;
                listBox3.SelectedIndex = list.SelectedIndex;
                listBox4.SelectedIndex = list.SelectedIndex;


                //Retrieve to textBox of allowDrop events

                comboBox1.Text = listBox2.SelectedItem.ToString();
                comboBox2.Text = listBox3.SelectedItem.ToString();
                comboBox3.Text = listBox4.SelectedItem.ToString();



            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {

                ABC.Open();
                command.CommandText = "delete from Groups where id='" + comboBox1.Text + "'";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Data Deleted Successfully..!");

                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;


                Search();
            }
        }
    }
}
