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

namespace ABC
{
    public partial class AddRooms : Form
    {

        private String roomtypech;
        private String roomId;
        private ConnectorClass con = new ConnectorClass();
        public AddRooms()
        {
            InitializeComponent();
        }

        private void AddLocations_Load(object sender, EventArgs e)
        {
            cmbCapacity.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                roomtypech = "Labortary";

            }
            else
            {
                roomtypech = "Lecture Hall";
            }

            con.OpenConection();

            bool result = con.executequery("insert into room(room_name,building_id,capcity,room_type)values('" + textBox1.Text + "','" + roomId + "','" + cmbCapacity.Text + "','" + roomtypech + "')");
            if (result)
            {
                MessageBox.Show("Record Inserted successfilly");
            }
            else
            {
                MessageBox.Show("Record Insert Error");
            }
            clearFields();
        }

        private void clearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            cmbCapacity.SelectedIndex = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "")
                {
                    con.OpenConection();
                    SqlDataReader reader = con.DataReader("select building_id from building where buildng_name=@building_name", textBox2.Text);
                    while (reader.Read())
                    {
                        roomId = reader.GetValue(0).ToString();

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.OpenConection();
            bool result = con.executequery("delete from room where room_name =" + textBox1.Text);

            if (result)
            {
                MessageBox.Show("Record delete successfilly");
            }
            else
            {
                MessageBox.Show(" Error");
            }
            clearFields();
        }

        private void btnViewAllRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageLocations loc = new manageLocations();
            loc.Show();
        }
    }
}
