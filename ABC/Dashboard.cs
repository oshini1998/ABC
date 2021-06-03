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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkingDaysHours w = new WorkingDaysHours();
            w.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLecturer add = new AddLecturer();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSubjects sub = new AddSubjects();
            sub.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudentGroups stu= new AddStudentGroups();
            stu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTag tag = new AddTag();
            tag.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Locations location = new Locations();
            location.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics stat = new Statistics();
            stat.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sessions s = new Sessions();
            s.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBuildings bu = new AddBuildings();
           bu.Show();
        }
    }
}
