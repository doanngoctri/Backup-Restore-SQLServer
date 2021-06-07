using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data;
using System.Data.SqlClient;

namespace Backup_Restore
{
    
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static string connstr;
        public static SqlDataAdapter da;

        public static string servername = "DNT";
        public static string username = "";
        public static string password = "";
        public static string database = "tempdb";
        public static string mlogin = "";

        public static int nambatdau = 2016;//để cho cmbNK tự động tính dựa vào năm này
        public static int flagRestore = 0;//để kiểm tra user có phcuj hồi csdl?
        public static string strDefaultPath = "D:/Backup_Restore/Backup";
        public static String device_type = "Disk";
        public static FormLogin form;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                //Program.connstr = "Data source=" + Program.servername + ";Initial Catalog=" + Program.database +
                //    ";User Id=" + Program.mlogin + ";Password=" + Program.password;
                Program.connstr = "Data source=" + Program.servername + ";User Id = " + Program.username + "; Password = " + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(" Lỗi kết nối CSDL.\nXem lại username và password.\n" + e.Message, "", MessageBoxButtons.RetryCancel);
                return 0;
            }
        }



        public static SqlDataReader myreader;
        public static SqlDataReader ExecSqlDataReader  (String cmd)
        {
            conn.Close();
            
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch(SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String cmd, String connectionstring)
        {
            conn.Close();

            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable (String cmd, String connectionstring)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(connectionstring);
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String cmd, String connectionstring, string errstr)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand(cmd, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600; //10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int loi = Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch( SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format lại các cột kiểu char qua int");
                else
                    MessageBox.Show(errstr + "\n" + ex.Message);
                conn.Close();
                return (ex.State);// trạng thái lỗi gửi từ RAISERROR trong sql server qua
            }
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new FormLogin();
            Application.Run(form);
            
            
        }
    }
}
