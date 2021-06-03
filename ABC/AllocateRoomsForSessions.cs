using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC
{
    public partial class AllocateRoomsForSessions : Form
    {
        private ConnectorClass con = new ConnectorClass();
        public AllocateRoomsForSessions()
        {
            InitializeComponent();
        }

        private void AllocateRoomsForSessions_Load(object sender, EventArgs e)
        {
            clearFields();
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
            cmbGroup.SelectedIndex = 0;
            cmbLecture.SelectedIndex = 0;
            cmbSession.SelectedIndex = 0;
            cmbSubject.SelectedIndex = 0;
            cmbTag.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.OpenConection();
            bool result = con.executequery("insert into sesion(Lecture_No,Subject_No,Tag,Session_No,Group_No,Room_Id)values(" + cmbLecture.Text + "," + cmbSubject.Text + "," + cmbTag.Text + "," + cmbSession.Text + "," + cmbGroup.Text + "," + textBox1.Text + ")");
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
    }
}
