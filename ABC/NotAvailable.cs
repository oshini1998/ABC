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
    public partial class NotAvailable : Form
    {

        SqlConnection con = new SqlConnection(@"Server=tcp:oshini.database.windows.net,1433;Initial Catalog=TimeTableDb;Persist Security Info=False;User ID=oshini;Password=Punsara2005*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public int sesion_id;

        private void dgvlocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select * from SessionNotAva ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            sesion_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            lecSession.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            selecgro.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            selec_sub.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            selectid.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            timeDuration.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }
        public NotAvailable()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void SessionsAndNotAvailable_Load(object sender, EventArgs e)
        {
            GETManageSubject();
        }

        private void GETManageSubject()
        {

            SqlCommand cmd = new SqlCommand("Select * from SessionNotAva ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr1 = cmd.ExecuteReader();
            dt.Load(sdr1);
            con.Close();

            dataGridView1.DataSource = dt;



        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO SessionNotAva VALUES (@Lecturname, @selectgr, @selectsub, @selectid, @time)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Lecturname", lecSession.Text);
            cmd.Parameters.AddWithValue("@selectgr", selecgro.Text);
            cmd.Parameters.AddWithValue("@selectsub", selec_sub.Text);
            cmd.Parameters.AddWithValue("@selectid", selectid.Text);
            cmd.Parameters.AddWithValue("@time", timeDuration.Text);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("SESSIONN AND NOT AVAILABLE TIME ALOCATION is Successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GETManageSubject();
            SESSIONN();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (sesion_id > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM SessionNotAva WHERE sesion_id =@ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", this.sesion_id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Lecturer is Deleted from this System", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GETManageSubject();
                SESSIONN();
            }
            else
            {
                MessageBox.Show("Please SESSIONN AND NOT AVAILABLE TIME ALOCATION to Delete his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnedite_Click(object sender, EventArgs e)
        {
            if (sesion_id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE SessionNotAva SET  select_lec=@Lecturname,select_group= @selectgr,select_sub= @selectsub,sekect_ID= @selectid,time_id= @time WHERE sesion_id=@sesion_id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Lecturname", lecSession.Text);
                cmd.Parameters.AddWithValue("@selectgr", selecgro.Text);
                cmd.Parameters.AddWithValue("@selectsub", selec_sub.Text);
                cmd.Parameters.AddWithValue("@selectid", selectid.Text);
                cmd.Parameters.AddWithValue("@time", timeDuration.Text);
                cmd.Parameters.AddWithValue("@sesion_id", this.sesion_id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" SESSIONN AND NOT AVAILABLE TIME ALOCATION is Successfully Updated the database", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);


                GETManageSubject();
                SESSIONN();


            }
            else
            {
                MessageBox.Show("Please select an SESSIONN AND NOT AVAILABLE TIME ALOCATION to update his information", "Select ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SESSIONN()
        {
            selectid.SelectedIndex = -1;
            sesion_id = 0;
            timeDuration.Clear();
            selectid.SelectedIndex = -1;

            //clearing combo box
            lecSession.SelectedIndex = -1;
            selecgro.SelectedIndex = -1;
            selec_sub.SelectedIndex = -1;
            selectid.SelectedIndex = -1;



        }

        private void btnSearch12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=tcp:oshini.database.windows.net,1433;Initial Catalog=TimeTableDb;Persist Security Info=False;User ID=oshini;Password=Punsara2005*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SessionNotAva where select_lec like'" + textsearch.Text + "%' OR select_group LIKE '" + textsearch.Text + "%' OR select_sub LIKE '" + textsearch.Text + "%' OR  sekect_ID LIKE '" + textsearch.Text + "%'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
