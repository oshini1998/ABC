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
    public partial class AddLocations : Form
    {
        SqlConnection con = new SqlConnection(@"Server=tcp:oshini.database.windows.net,1433;Initial Catalog=TimeTableDb;Persist Security Info=False;User ID=oshini;Password=Punsara2005*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public int r_id;
        public AddLocations()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Addlocaltime ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            r_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBoxRoomID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            days.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxStartTime.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboSelectRoom.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxEndTime.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void AddLocations_Load(object sender, EventArgs e)
        {
            GETManageSubjects();
        }

        private void clear()
        {
            days.SelectedIndex = -1;
            r_id = 0;
            textBoxStartTime.Clear();
            textBoxRoomID.Clear();
            textBoxEndTime.Clear();


            //clearing combo box
            comboSelectRoom.SelectedIndex = -1;




        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            
            {
                if (r_id > 0)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Addlocaltime WHERE r_id =@ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.r_id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Lecturer is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GETManageSubjects();
                    clear();
                }
                else
                {
                    MessageBox.Show("Please SESSIONN AND NOT AVAILABLE TIME ALOCATION to Delete his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Addlocaltime VALUES (@textBoxRoomID, @days, @textBoxStartTime,@comboSelectRoom,@textBoxEndTime)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@textBoxRoomID", textBoxRoomID.Text);
            cmd.Parameters.AddWithValue("@days", days.Text);
            cmd.Parameters.AddWithValue("@textBoxStartTime", textBoxStartTime.Text);
            cmd.Parameters.AddWithValue("@comboSelectRoom", comboSelectRoom.Text);
            cmd.Parameters.AddWithValue("@textBoxEndTime", textBoxEndTime.Text);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("SESSIONN AND NOT AVAILABLE TIME ALOCATION is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GETManageSubjects();
            clear();
        }

        private void GETManageSubjects()
        {

            SqlCommand cmd = new SqlCommand("Select * from Addlocaltime ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            dataGridView1.DataSource = dt;



        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            if (r_id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Addlocaltime SET  roomid=@roomids,dates= @datest,StartTime= @StartTimes,selectroom= @selectrooms,endtime= @endtimes WHERE r_id=@r_id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@roomids", textBoxRoomID.Text);
                cmd.Parameters.AddWithValue("@datest", days.Text);
                cmd.Parameters.AddWithValue("@StartTimes", textBoxStartTime.Text);
                cmd.Parameters.AddWithValue("@selectrooms", comboSelectRoom.Text);
                cmd.Parameters.AddWithValue("@endtimes", textBoxEndTime.Text);
                cmd.Parameters.AddWithValue("@r_id", this.r_id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" SESSIONN AND NOT AVAILABLE TIME ALOCATION is Successfully Updated the database", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);


                GETManageSubjects();
                clear();

            }
            else
            {
                MessageBox.Show("Please select an SESSIONN AND NOT AVAILABLE TIME ALOCATION to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8V06R00\SQLEXPRESS;Initial Catalog=timetableDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Addlocaltime where roomid like'" + textsearch.Text + "%' OR dates LIKE '" + textsearch.Text + "%' OR StartTime LIKE '" + textsearch.Text + "%' OR  selectroom LIKE '" + textsearch.Text + "%'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
