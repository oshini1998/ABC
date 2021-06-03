using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    class ConnectorClass
    {
        private SqlConnection con;



        public void OpenConection()
        {
            con = new SqlConnection(@"Server=tcp:oshini.database.windows.net,1433;Initial Catalog=TimeTableDb;Persist Security Info=False;User ID=oshini;Password=Punsara2005*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        public void CloseConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public bool executequery(String Query)
        {
            try
            {
                OpenConection();
                SqlCommand cmd = new SqlCommand(Query, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }

        }

        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }


        public SqlDataReader DataReader(string Query_, String para1)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.Parameters.AddWithValue("@building_name", para1);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader DataReader(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public int DataCount(string Tablename_)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM " + Tablename_, con);

            return (Int32)cmd.ExecuteScalar();
        }

    
}
}
