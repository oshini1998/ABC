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
    public partial class Sessions : Form
    {
        public Sessions()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSession add = new AddSession();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSessionRooms m= new ManageSessionRooms();
            m.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSessiosAndNotAvailable s= new ManageSessiosAndNotAvailable();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotAvailable session = new NotAvailable();
           session.Show();
        }
    }
}
 