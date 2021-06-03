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
    public partial class ViewManageSessions : Form
    {
        private ConnectorClass con = new ConnectorClass();

        public ViewManageSessions()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void loadToList()
        {
            con.OpenConection();
            this.dataGridView1.DataSource = con.ShowDataInGridView("Select * from mangesesion");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ViewManageSessions_Load(object sender, EventArgs e)
        {
            loadToList();
        }
    }
}
