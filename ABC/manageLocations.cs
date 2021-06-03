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
    public partial class manageLocations : Form
    {

        private string roomtypech;
        private ConnectorClass con = new ConnectorClass();
        public manageLocations()
        {
            InitializeComponent();
        }

        private void manageLocations_Load(object sender, EventArgs e)
        {
            con.OpenConection();

            this.dataGridView1.DataSource = con.ShowDataInGridView("Select * from room");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            cmbCapacity.SelectedIndex = 0;
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
            bool result = con.executequery("update room set room_name='" + textBox1.Text + "',capcity='" + cmbCapacity.Text + "',room_type='" + roomtypech + "' where room_id='" + textBox2.Text + "'");
            if (result)
            {
                MessageBox.Show("Record Delete successfilly");
            }
            else
            {
                MessageBox.Show("Record Insert Error");
            }
            clearFields();


            this.dataGridView1.DataSource = con.ShowDataInGridView("Select * from room");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.OpenConection();
            bool result = con.executequery("DELETE FROM room where room_id = '" + textBox2.Text + "'");
            if (result)
            {
                MessageBox.Show("Record Deleted successfilly");
            }
            else
            {
                MessageBox.Show(" Error");
            }
            clearFields();
            this.dataGridView1.DataSource = con.ShowDataInGridView("Select * from room");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
