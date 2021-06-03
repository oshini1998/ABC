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
    public partial class Locations : Form
    {
        public Locations()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRooms r = new AddRooms();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLocations l= new AddLocations();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllocateRoomsForSessions a = new AllocateRoomsForSessions();
            a.Show();
        }
    }
}
