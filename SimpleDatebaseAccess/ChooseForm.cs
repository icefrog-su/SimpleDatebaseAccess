using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OracleClient;
using System.Data.SqlClient;
using SimpleDatebaseAccess.Util;

namespace SimpleDatebaseAccess
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        public bool closeStatus = false;

        private void ChooseForm_Load(object sender, EventArgs e)
        {
            cbo_db.Items.Add(LogDB.ORACLE);
            cbo_db.Items.Add(LogDB.SQLSERVER);
            cbo_db.Items.Add(LogDB.MYSQL);
        }

        private void cbo_db_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentChoose = cbo_db.Text;
            lb_dbname.Text = currentChoose;
            if (LogDB.ORACLE.Equals(currentChoose))
            {
                lb_tips.Text = "Recommend more than v9G";
                txt_url.Text = "User ID=scott;Password=123;Data Source=orcl";
            }
            else if (LogDB.SQLSERVER.Equals(currentChoose))
            {
                lb_tips.Text = "Recommend more than v2005";
                txt_url.Text = "server=127.0.0.1;uid=sa;pwd=123";
            }
            else if (LogDB.MYSQL.Equals(currentChoose))
            {
                lb_tips.Text = "Recommend more than v5.0";
                txt_url.Text = "server=127.0.0.1;User Id=root;password=123";
            }
        }

        private bool isSuccess = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isSuccess)
            {
                MessageBox.Show("Please click check connection button confirm this database connect.");
                return;
            }
            string currentChoose = cbo_db.Text;
            if (currentChoose.Trim().Length == 0)
                return;
            else
            {
                closeStatus = true;
                LogDB.ConnectionString = txt_url.Text.Trim();
                LogDB.ConnectionDatabase = cbo_db.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string currentDB = cbo_db.Text;
            string currentURL = txt_url.Text;
            if (currentDB.Trim().Length == 0) { return; }
            if (currentURL.Trim().Length == 0) { return; }
            if (LogDB.ORACLE.Equals(currentDB))
                dic = PingOracleDBConnection(currentURL);
            else if (LogDB.MYSQL.Equals(currentDB))
                dic = PingMySQLDBConnection(currentURL);
            else if (LogDB.SQLSERVER.Equals(currentDB))
                dic = PingSQLServerDBConnection(currentURL);

            if (dic != null)
            {
                isSuccess = true;
                lb_ConnectionURL.Text = dic["connectionString"];
                lb_ConnectionTimeOut.Text = dic["connectionTimeout"];
                lb_ConnectionDataSouece.Text = dic["dataSource"];
                lb_ConnectionDatabaseVersion.Text = dic["serverVersion"];
                LogDB.dbversion = dic["serverVersion"]; 
            }
            else
            {
                isSuccess = false;
                lb_ConnectionURL.Text = string.Empty;
                lb_ConnectionTimeOut.Text = string.Empty;
                lb_ConnectionDataSouece.Text = string.Empty;
                lb_ConnectionDatabaseVersion.Text = string.Empty;
            }
        }

        private Dictionary<string,string> PingMySQLDBConnection(string url) 
        {
            MySqlConnection mysqlConnection = null;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            try
            {
                mysqlConnection = new MySqlConnection(url);
                mysqlConnection.Open();
                string connectionString = mysqlConnection.ConnectionString;
                int connectionTimeout = mysqlConnection.ConnectionTimeout;
                string dataSource = mysqlConnection.DataSource;
                string serverVersion = mysqlConnection.ServerVersion;
                dic.Add("connectionString", connectionString);
                dic.Add("connectionTimeout", connectionTimeout.ToString());
                dic.Add("dataSource", dataSource);
                dic.Add("serverVersion", serverVersion);
                return dic;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed. "+ex.Message);
            }
            finally
            {
                mysqlConnection.Close();
            }
            return null;
        }
        private Dictionary<string, string> PingOracleDBConnection(string url)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            OracleConnection oracleConnection = null;
            try
            {
                oracleConnection = new OracleConnection(url);
                oracleConnection.Open();
                string connectionString = oracleConnection.ConnectionString;
                int connectionTimeout = oracleConnection.ConnectionTimeout;
                string dataSource = oracleConnection.DataSource;
                string serverVersion = oracleConnection.ServerVersion;
                dic.Add("connectionString", connectionString);
                dic.Add("connectionTimeout", connectionTimeout.ToString());
                dic.Add("dataSource", dataSource);
                dic.Add("serverVersion", serverVersion);
                return dic;  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed. " + ex.Message);
            }
            finally
            {
                oracleConnection.Close();
            }
            return null;
        }
        private Dictionary<string, string> PingSQLServerDBConnection(string url)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(url);
                sqlConnection.Open();
                string connectionString = sqlConnection.ConnectionString;
                int connectionTimeout = sqlConnection.ConnectionTimeout;
                string dataSource = sqlConnection.DataSource;
                string serverVersion = sqlConnection.ServerVersion;
                dic.Add("connectionString", connectionString);
                dic.Add("connectionTimeout", connectionTimeout.ToString());
                dic.Add("dataSource", dataSource);
                dic.Add("serverVersion", serverVersion);
                return dic; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed. " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return null;
        }
    }
}
