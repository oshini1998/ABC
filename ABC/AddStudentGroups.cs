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
    public partial class AddStudentGroups : Form
    {
        public AddStudentGroups()
        {
            InitializeComponent();
        }

        SqlConnection ABC = new SqlConnection(@"Server=tcp:oshini.database.windows.net,1433;Initial Catalog=TimeTableDb;Persist Security Info=False;User ID=oshini;Password=Punsara2005*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        SqlCommand command = new SqlCommand();
        SqlDataReader dataSearch;

        private void AddStudentGroups_Load(object sender, EventArgs e)
        {
            command.Connection = ABC;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = comboBox1.Text;
            String b = comboBox2.Text;
            String c = comboBox3.Text;
            String d = a + b + c;
            textBox5.Text = d;

            String f = comboBox4.Text;
            String g = a + b + c + f;
            textBox6.Text = g;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" & textBox5.Text != "" & textBox6.Text != "" & comboBox1.Text != "" & comboBox2.Text != "" & comboBox3.Text != "")
            {

                ABC.Open();
                command.CommandText = "INSERT INTO Groups(ID, semester, programme, GroupNumber, SubGroup, GroupId, SubId) Values('" + textBox1.Text + "','" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + comboBox3.Text + "', '" + comboBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Data Saved Successfully..!");
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                textBox5.Clear();
                textBox6.Clear();

                Search();

            }

        }

        private void Search()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();

            ABC.Open();

            command.CommandText = "Select * from Groups";

            dataSearch = command.ExecuteReader();
            if (dataSearch.HasRows)
            {
                while (dataSearch.Read())

                {

                    listBox1.Items.Add(dataSearch["ID"].ToString());
                    listBox2.Items.Add(dataSearch["semester"].ToString());
                    listBox3.Items.Add(dataSearch["programme"].ToString());
                    listBox4.Items.Add(dataSearch["GroupNumber"].ToString());
                    listBox5.Items.Add(dataSearch["SubGroup"].ToString());
                    listBox6.Items.Add(dataSearch["GroupId"].ToString());
                    listBox7.Items.Add(dataSearch["SubId"].ToString());
                }
            }

            ABC.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox5.Text != "" & textBox6.Text != "" & comboBox1.Text != "" & comboBox2.Text != "" & comboBox3.Text != "")
            {

                ABC.Open();
                command.CommandText = "Update Groups set semester='" + comboBox1.Text + "', programme='" + comboBox2.Text + "', GroupNumber='" + comboBox3.Text + "', SubGroup='" + comboBox4.Text + "', GroupId='" + textBox5.Text + "', SubId='" + textBox6.Text + "' where ID='" + listBox1.SelectedItem.ToString() + "' and semester='" + listBox2.SelectedItem.ToString() + "' and programme='" + listBox3.SelectedItem.ToString() + "' and GroupNumber='" + listBox4.SelectedItem.ToString() + "' and SubGroup='" + listBox5.SelectedItem.ToString() + "' and GroupId='" + listBox6.SelectedItem.ToString() + "' and SubId='" + listBox7.SelectedItem.ToString() + "' ";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Data Updated Successfully..!");
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                textBox5.Clear();
                textBox6.Clear();

                Search();
            }
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
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

                //Retrieve to textBox of allowDrop events
                textBox1.Text = listBox1.SelectedItem.ToString();
                comboBox1.Text = listBox2.SelectedItem.ToString();
                comboBox2.Text = listBox3.SelectedItem.ToString();
                comboBox3.Text = listBox4.SelectedItem.ToString();
                comboBox4.Text = listBox5.SelectedItem.ToString();
                textBox5.Text = listBox6.SelectedItem.ToString();
                textBox6.Text = listBox7.SelectedItem.ToString();


            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                ABC.Open();
                command.CommandText = "delete from Groups where id='" + textBox1.Text + "'";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Data Deleted Successfully..!");
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                textBox5.Clear();
                textBox6.Clear();

                Search();
            }
        }
    }
}
