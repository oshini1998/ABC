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
    public partial class ManageBuildings : Form
    {
        private ConnectorClass con = new ConnectorClass();
        public ManageBuildings()
        {
            InitializeComponent();
        }

        private void ManageBuildings_Load(object sender, EventArgs e)
        {
            loadToList();
        }

        private void loadToList()
        {
            con.OpenConection();
            this.dataGridView1.DataSource = con.ShowDataInGridView("Select * from building1");
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
            bool result = con.executequery("update building set buildng_name = '" + textBox2.Text + "', number_room = '" + cmbNumberofRooms.Text + "' where building_id = '" + textBox1.Text + "'");
            if (result)
            {
                MessageBox.Show("Record Updated successfilly");
            }
            else
            {
                MessageBox.Show(" Error");
            }
            clearFields();

            loadToList();
        }

        private void clearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            cmbNumberofRooms.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.OpenConection();
            bool result = con.executequery("DELETE FROM building where building_id = '" + textBox1.Text + "'");
            if (result)
            {
                MessageBox.Show("Record Deleted successfilly");
            }
            else
            {
                MessageBox.Show(" Error");
            }
            clearFields();
            loadToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
