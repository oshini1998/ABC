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
    public partial class AddBuildings : Form
    {
        private ConnectorClass con = new ConnectorClass();
        public AddBuildings()
        {
            InitializeComponent();
        }

        private void AddBuildings_Load(object sender, EventArgs e)
        {
            cmbNumberofRooms.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.OpenConection();
            bool result = con.executequery("insert into building1(building_id, buildng_name, number_room)values('" + textBox2.Text + "', '" + textBox1.Text + "', '" + cmbNumberofRooms.Text + "')");
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.OpenConection();
            bool result = con.executequery("delete from building where building_id = " + textBox2.Text);
            if (result)
            {
                MessageBox.Show("Record Delete successfilly");
            }
            else
            {
                MessageBox.Show("Record Insert Error");
            }
            clearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            cmbNumberofRooms.SelectedIndex = 0;
        }

        private void btnManageBuildings_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageBuildings b = new ManageBuildings();
            b.Show();
        }
    }
}
