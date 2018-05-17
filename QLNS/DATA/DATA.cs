using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DATA
{
    public class Data

    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-TJS5B35;Initial Catalog=QLNS;Integrated Security=True");
        }
        //sql tra ve 1  bang 
        public DataTable GetTable(string sql)
        {
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        //sql khong tra ve  bang
        public void ExNonQuery(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }
        // xu ly combobox
        public DataSet EXreader(string sql)

        {


            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataSet dt = new DataSet();
            ad.Fill(dt);
            return (dt);




        }
        // tra ve phan tu dc tiem kiem 
        public string ExScalar1(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            string a = Convert.ToString(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            return a;

            //tra ve chuoi tim kiem 
        }
        public int ExScalar(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            int a = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Dispose();
            con.Close();
            return a;
        }
    }
}
