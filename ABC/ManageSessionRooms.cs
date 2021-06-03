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
    public partial class ManageSessionRooms : Form
    {
        private ConnectorClass con = new ConnectorClass();
        public ManageSessionRooms()
        {
            InitializeComponent();
            con.OpenConection();
            try
            {

                SqlDataReader reader = con.DataReader("select room_id from room");
                while (reader.Read())
                {
                    cmbRooms.Items.Add(reader.GetValue(0).ToString());

                }
                reader.Close();

                SqlDataReader reader2 = con.DataReader("select Session_no from sesion");
                while (reader2.Read())
                {
                    cmbSession.Items.Add(reader2.GetValue(0).ToString());

                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message);
            }
        }

        private void ManageSessionRooms_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool result = con.executequery("insert into mangesesion (Session_no,Room_id,Reson)values('" + cmbSession.Text + "','" + cmbRooms.Text + "','" + textBox1.Text + "')");
            if (result)
            {
                MessageBox.Show("Record Updated successfilly");
            }
            else
            {
                MessageBox.Show(" Error");
            }
            clearFields();
        }

        private void clearFields()
        {
            cmbRooms.SelectedIndex = 0;
            cmbSession.SelectedIndex = 0;
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = con.executequery("delete from mangesesion where room_id =" + cmbRooms.Text);
            if (result)
            {
                MessageBox.Show("Record deleted successfilly");
            }
            else
            {
                MessageBox.Show(" Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewManageSessions v= new ViewManageSessions();
            v.Show();
        }
    }
}
