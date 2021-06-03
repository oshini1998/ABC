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
    public partial class Statistics : Form
    {
        private ConnectorClass con = new ConnectorClass();
        private String stdCount;
        private String subCount;
        private String lectCount;
        private String labCount;
        private String roomCount;
        public Statistics()
        {
            InitializeComponent();
        }

        //fillChart method  
        private void fillChart()
        {


            //AddXY value in chart1 in series named as Salary  
            chart1.Series["Series"].Points.AddXY("Student", stdCount);
            chart1.Series["Series"].Points.AddXY("Subject", subCount);
            chart1.Series["Series"].Points.AddXY("Lectures", lectCount);
            chart1.Series["Series"].Points.AddXY("Laboratory", labCount);
            chart1.Series["Series"].Points.AddXY("Rooms", roomCount);
            //chart title  
            chart1.Titles.Add("Staistic Chart");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            con.OpenConection();

            labCount = Convert.ToString((con.DataCount("lab")));
            lectCount = Convert.ToString((con.DataCount("lecturer")));
            roomCount = Convert.ToString((con.DataCount("room")));
            stdCount = Convert.ToString((con.DataCount("student")));
            subCount = Convert.ToString((con.DataCount("subject")));



            fillChart();

            label10.Text = stdCount;
            label11.Text = subCount;
            label12.Text = lectCount;
            label13.Text = labCount;
            label14.Text = roomCount;
        }
    }
}
