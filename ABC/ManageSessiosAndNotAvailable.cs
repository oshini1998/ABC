using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ABC
{
    public partial class ManageSessiosAndNotAvailable : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;

        public ManageSessiosAndNotAvailable()
        {

            InitializeComponent();
            See();
            BindData();
            Search1();
            BindData1();
            Search2();
           // BindData2();



            Show();
            SqlConnection ABC = new SqlConnection(@"Server=tcp:oshini.database.windows.net,1433;Initial Catalog=TimeTableDb;Persist Security Info=False;User ID=oshini;Password=Punsara2005*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");




        }


        SqlConnection ABC = new SqlConnection(@"Server=tcp:oshini.database.windows.net,1433;Initial Catalog=TimeTableDb;Persist Security Info=False;User ID=oshini;Password=Punsara2005*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        SqlCommand command = new SqlCommand();
        SqlDataReader dataSearch;

        private void button4_Click(object sender, EventArgs e)
        {

        }


        /* private void DisplayData()
         {
             SqlCommand command = new SqlCommand("select*from[dbo].[lecturer] ", ABC);

             ABC.Open();
             SqlDataAdapter sda = new SqlDataAdapter(command);

             DataSet ds = new DataSet();
             sda.Fill(ds);
             ABC.Close();
             for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
             {
                 comboBox17.Items.Add(ds.Tables[0].Rows[i][0]);
             }
         }*/

        /*private void Show()
        {
            SqlCommand command = new SqlCommand("select code from[dbo].[subject] ", ABC);

            ABC.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ABC.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0]);
               
            }
           
        }*/

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SessiosAndNotAvailable_Load(object sender, EventArgs e)
        {
            command.Connection = ABC;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void See()
        {
            SqlCommand sqlComm = new SqlCommand("select fLec,tag,tag from [dbo].[session]", ABC);
            ABC.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ABC.Close();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1] + " |" + ds.Tables[0].Rows[i][2]);
                comboBox3.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1] + " |" + ds.Tables[0].Rows[i][2]);
            }

        }




        private void button3_Click_1(object sender, EventArgs e)
        {

            if ((comboBox1.Text != string.Empty) && (comboBox3.Text != string.Empty))
            {



                cmd = new SqlCommand("insert into Consecutive(Session01,Session02) values(@session01,@session02)", ABC);
                ABC.Open();
                cmd.Parameters.AddWithValue("@session01", comboBox1.Text);
                cmd.Parameters.AddWithValue("@session02", comboBox3.Text);
                cmd.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Consecutive Session Record Successfully");
                BindData();


            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void Search()

       {
           listBox1.Items.Clear();
           listBox2.Items.Clear();
           listBox3.Items.Clear();
           listBox4.Items.Clear();
           listBox5.Items.Clear();


           ABC.Open();

           command.CommandText = "Select * from Consecutive";

           dataSearch = command.ExecuteReader();
           if (dataSearch.HasRows)
           {
               while (dataSearch.Read())

               {

                   listBox1.Items.Add(dataSearch["SubjectCode"].ToString());
                   listBox2.Items.Add(dataSearch["GroupId"].ToString());
                   listBox3.Items.Add(dataSearch["Session1"].ToString());
                   listBox4.Items.Add(dataSearch["Session2"].ToString());
                   listBox5.Items.Add(dataSearch["Lecturer1"].ToString());
                  // listBox6.Items.Add(dataSearch["Lecturer2"].ToString());

               }
           }

           ABC.Close();
       }
        */
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Search();
            // BindData();

            ABC.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select Session01,Session02 from Consecutive ", ABC);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            ABC.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*if (comboBox1.Text != "" & comboBox3.Text != "" )
            {

                ABC.Open();
                command.CommandText = "Update Consecutive set SubjectCode='" + comboBox1.Text + "', GroupId='" + comboBox3.Text + "' where SubjectCode='" + listBox1.SelectedItem.ToString() + "' and GroupId='" + listBox2.SelectedItem.ToString() + "' and Session1='" + listBox3.SelectedItem.ToString() + "' and Session2='" + listBox4.SelectedItem.ToString() + "' and Lecturer1='" + listBox5.SelectedItem.ToString() + "' ";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Consecutive Sessions Updated Successfully..!");

                comboBox1.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
               
              //  textBox5.Clear();
              //  textBox1.Clear();


                Search();
            }*/
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /* ListBox list = sender as ListBox;
             if (list.SelectedIndex != -1)
             {

                 listBox1.SelectedIndex = list.SelectedIndex;
                 listBox2.SelectedIndex = list.SelectedIndex;
                 listBox3.SelectedIndex = list.SelectedIndex;
                 listBox4.SelectedIndex = list.SelectedIndex;
                 listBox5.SelectedIndex = list.SelectedIndex;
                 //listBox6.SelectedIndex = list.SelectedIndex;


                 //Retrieve to textBox of allowDrop events

                 comboBox1.Text = listBox1.SelectedItem.ToString();
                 comboBox3.Text = listBox2.SelectedItem.ToString();

              //   textBox5.Text = listBox5.SelectedItem.ToString();
               //  textBox1.Text = listBox6.SelectedItem.ToString();



             }*/
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }


        //consective view data
        private void BindData()
        {
           





        }

        private void BindData1()
        {
            




        }

       

        /* ABC.Open();
         command.CommandText = "delete from Consecutive where SubjectCode='" + comboBox1.Text + "'";
         command.ExecuteNonQuery();
         ABC.Close();
         MessageBox.Show("Consecutive Sessions Deleted Successfully..!");

         comboBox1.SelectedIndex = -1;
         comboBox3.SelectedIndex = -1;

      //   textBox5.Clear();
     //    textBox1.Clear();


        Search();*/

        private void Search1()
        {

            {
                SqlCommand sqlComm = new SqlCommand("select fLec,tag,tag from [dbo].[session]", ABC);
                ABC.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                ABC.Close();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    comboBox2.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1] + " |" + ds.Tables[0].Rows[i][2]);
                    comboBox6.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1] + " |" + ds.Tables[0].Rows[i][2]);
                }

            }
        }

        private void Search2()
        {

            {
                SqlCommand sqlComm = new SqlCommand("select fLec,tag,tag from [dbo].[session]", ABC);
                ABC.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                ABC.Close();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    comboBox12.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1] + " |" + ds.Tables[0].Rows[i][2]);
                    comboBox11.Items.Add(ds.Tables[0].Rows[i][0] + " |" + ds.Tables[0].Rows[i][1] + " |" + ds.Tables[0].Rows[i][2]);
                }

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if ((comboBox2.Text != string.Empty) && (comboBox6.Text != string.Empty) && (comboBox7.Text != string.Empty) && (comboBox9.Text != string.Empty) && (comboBox10.Text != string.Empty))
            {



                cmd = new SqlCommand("insert into Paralel1(Session01,Session02,Duration,StartTime,EndTime) values(@session01,@session02,@Duration,@StartTime,@EndTime)", ABC);
                ABC.Open();
                cmd.Parameters.AddWithValue("@session01", comboBox2.Text);
                cmd.Parameters.AddWithValue("@session02", comboBox6.Text);
                cmd.Parameters.AddWithValue("@Duration", comboBox7.Text);
                cmd.Parameters.AddWithValue("@StartTime", comboBox9.Text);
                cmd.Parameters.AddWithValue("@EndTime", comboBox10.Text);
                cmd.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Paralel Session Record Successfully");
                BindData1();


            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        

        private void button15_Click(object sender, EventArgs e)
        {
            ABC.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select Session01,Session02,Duration,StartTime,EndTime from Paralel1 ", ABC);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            ABC.Close();

        }

        /*private void button14_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" & comboBox6.Text != "" & comboBox7.Text != ""& comboBox9.Text != "" & comboBox10.Text != "")
            {

                ABC.Open();
                command.CommandText = "Update Paralel set Subject1='" + comboBox2.Text + "', Subject2='" + comboBox6.Text + "', GroupID='" + comboBox7.Text + "', Start='" + comboBox9.Text + "', EndT='" + comboBox10.Text + "' where Subject1='" + listBox12.SelectedItem.ToString() + "' and Subject2='" + listBox11.SelectedItem.ToString() + "' and GroupID='" + listBox10.SelectedItem.ToString() + "' and Day='" + listBox9.SelectedItem.ToString() + "' and Start='" + listBox8.SelectedItem.ToString() + "' and EndT='" + listBox7.SelectedItem.ToString() + "'";
                command.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Parallel Sessions Updated Successfully..!");

                comboBox2.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;
                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;


                Search1();
            }
        }*/

        /*  private void listBox12_SelectedIndexChanged(object sender, EventArgs e)
          {
              ListBox list = sender as ListBox;
              if (list.SelectedIndex != -1)
              {

                  listBox12.SelectedIndex = list.SelectedIndex;
                  listBox11.SelectedIndex = list.SelectedIndex;
                  listBox10.SelectedIndex = list.SelectedIndex;
                  listBox9.SelectedIndex = list.SelectedIndex;
                  listBox8.SelectedIndex = list.SelectedIndex;
                  listBox7.SelectedIndex = list.SelectedIndex;


                  //Retrieve to textBox of allowDrop events

                  comboBox2.Text = listBox12.SelectedItem.ToString();
                  comboBox6.Text = listBox11.SelectedItem.ToString();
                  comboBox7.Text = listBox10.SelectedItem.ToString();
                  comboBox8.Text = listBox9.SelectedItem.ToString();
                  comboBox9.Text = listBox8.SelectedItem.ToString();
                  comboBox10.Text = listBox7.SelectedItem.ToString();



              }
          }*/

        /*  private void button13_Click(object sender, EventArgs e)
          {
              if (comboBox2.Text != "")
              {

                  ABC.Open();
                  command.CommandText = "delete from Paralel where Subject1='" + comboBox2.Text + "'";
                  command.ExecuteNonQuery();
                  ABC.Close();
                  MessageBox.Show("Parallel Sessions Deleted Successfully..!");

                  comboBox2.SelectedIndex = -1;
                  comboBox6.SelectedIndex = -1;
                  comboBox7.SelectedIndex = -1;
                  comboBox8.SelectedIndex = -1;
                  comboBox9.SelectedIndex = -1;
                  comboBox10.SelectedIndex = -1;


                  Search1();
              }
          }*/





        private void button19_Click(object sender, EventArgs e)
        {
            Search2();
        }

        

        

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
             if ((comboBox12.Text != string.Empty) && (comboBox11.Text != string.Empty) && (comboBox8.Text != string.Empty) && (comboBox5.Text != string.Empty) && (comboBox4.Text != string.Empty))
            {



                cmd = new SqlCommand("insert into NonOverlap1(Session01,Session02,Duration,StartTime,EndTime) values(@session01,@session02,@Duration,@StartTime,@EndTime)", ABC);
                ABC.Open();
                cmd.Parameters.AddWithValue("@session01", comboBox12.Text);
                cmd.Parameters.AddWithValue("@session02", comboBox11.Text);
                cmd.Parameters.AddWithValue("@Duration", comboBox8.Text);
                cmd.Parameters.AddWithValue("@StartTime", comboBox5.Text);
                cmd.Parameters.AddWithValue("@EndTime", comboBox4.Text);
                cmd.ExecuteNonQuery();
                ABC.Close();
                MessageBox.Show("Paralel Session Record Successfully");
                //BindData2();


            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
                ABC.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select Session01,Session02,Duration,StartTime,EndTime from NonOverlap1 ", ABC);
                adapt.Fill(dt);
                dataGridView3.DataSource = dt;
                ABC.Close();





            }
        }
    }

