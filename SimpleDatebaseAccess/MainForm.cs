using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleDatebaseAccess.Util;
using System.Data.OracleClient;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SimpleDatebaseAccess
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            loadImageList();
            tss_dbname.Text = LogDB.ConnectionDatabase;
            tss_version.Text = LogDB.dbversion;
            this.Text += " [ "+LogDB.ConnectionDatabase+" ]";


            //If now choose database is oracle,loading all oracle database's user space,behave inside user
            if (LogDB.ORACLE.Equals(LogDB.ConnectionDatabase))
            {
                //string currendUser = ORACLEDBHelp.ExecuteScalar(LogDB.ORACLE_CURRENT_USERNAME).ToString(); 
                string currendUser = string.Empty;
                OracleDataReader reader = ORACLEDBHelp.ExecuteDataReader(LogDB.ORACLE_CURRENT_USERNAME);
                if (reader.Read())
                    currendUser = reader[0].ToString();
                reader.Close();

                OracleDataReader oracle_table_reader = ORACLEDBHelp.ExecuteDataReader(LogDB.ORACLE_CURRENT_USERNAME_TABLE);
                List<string> tabName = new List<string>();
                while (oracle_table_reader.Read())
                {   
                    tabName.Add(oracle_table_reader[0].ToString());
                }
                if (!oracle_table_reader.IsClosed)
                    oracle_table_reader.Close();

                OracleDataReader oracleReader = ORACLEDBHelp.ExecuteDataReader(LogDB.ORACLE_ALL_USER_SCRIPT);
                while (oracleReader.Read())
                {        
                    if (oracleReader[0].ToString().Equals(currendUser))
                    {
                        //If current user is now loaded
                        TreeNode nodeUser = new TreeNode(oracleReader[0].ToString()+"(Current user)");
                        nodeUser.ImageIndex = 3;
                        TreeNode nodeTable = new TreeNode("Table");
                        foreach (string item in tabName)
                        {
                            TreeNode nodeInnerTable = new TreeNode(item);
                            nodeInnerTable.ImageIndex = 0;
                            nodeTable.Nodes.Add(nodeInnerTable);
                        }
                        nodeUser.Nodes.Add(nodeTable);
                        nodeUser.ForeColor = Color.Red;
                        tv_allDB.Nodes.Add(nodeUser);
                    }
                    else
                    {
                        //Loading all user information
                        TreeNode nodeUser = new TreeNode(oracleReader[0].ToString());
                        nodeUser.ImageIndex = 3;
                        TreeNode nodeTable = new TreeNode("Low permissions");
                        nodeTable.ImageIndex = 2;
                        nodeTable.ForeColor = Color.Gray;
                        nodeUser.Nodes.Add(nodeTable);
                        tv_allDB.Nodes.Add(nodeUser);
                    }  
                }
                if (!oracleReader.IsClosed)
                    oracleReader.Close();
            }
            //If now choose database is sqlserver,loading all sqlserver database,behave system database
            else if (LogDB.SQLSERVER.Equals(LogDB.ConnectionDatabase))
            {
                SqlDataReader sqlserverReader = SQLSERVERDBHelp.ExecuteDataReader(LogDB.SQLSERVER_ALL_TABLE_SCRIPT);
                while (sqlserverReader.Read())
                {
                    string databaseName = sqlserverReader[0].ToString();
                    TreeNode nodeDatabase = new TreeNode(databaseName);
                    nodeDatabase.ImageIndex = 1;
                    SqlDataReader sqlReader = SQLSERVERDBHelp.ReBuilderSqlDataReader("select * from " + databaseName + ".dbo.sysobjects where xtype='U'");
                    while (sqlReader.Read())
                    {
                        string tagName = sqlReader[0].ToString();
                        TreeNode table = new TreeNode(tagName);
                        table.ImageIndex = 0;
                        nodeDatabase.Nodes.Add(table);
                    }
                    if (!sqlReader.IsClosed)
                        sqlReader.Close();

                    tv_allDB.Nodes.Add(nodeDatabase);
                }
                if (!sqlserverReader.IsClosed)
                    sqlserverReader.Close();
            }
            //If now choose database is mysql,loading all mysql database,behave system database
            else if (LogDB.MYSQL.Equals(LogDB.ConnectionDatabase))
            {
                MySqlDataReader mysqlReader = MYSQLDBHelp.ExecuteDataReader(LogDB.MYSQL_ALL_TABLE_SCRIPT);
                while (mysqlReader.Read())
                {
                    string databaseName = mysqlReader[0].ToString();
                    TreeNode databaseNode = new TreeNode(databaseName);
                    databaseNode.ImageIndex = 1;
                    MySqlDataReader myReader = MYSQLDBHelp.ReBuildMySQLDataReader("use " + databaseName + ";show tables");
                    while (myReader.Read())
                    {
                        TreeNode table = new TreeNode(myReader[0].ToString());
                        table.ImageIndex = 0;
                        databaseNode.Nodes.Add(table);
                    }
                    if (!myReader.IsClosed)
                        myReader.Close();
                    tv_allDB.Nodes.Add(databaseNode);
                }
                if (!mysqlReader.IsClosed)
                    mysqlReader.Close();
            }
        }

        private ImageList imgList = new ImageList();
        private void loadImageList()
        {
            imgList.Images.Add(Image.FromFile("icons/table2.ico"));//index of 0
            imgList.Images.Add(Image.FromFile("icons/db.ico"));//index of 1
            imgList.Images.Add(Image.FromFile("icons/warn.ico"));//index of 2
            imgList.Images.Add(Image.FromFile("icons/user.ico"));//index of 3
            imgList.Images.Add(Image.FromFile("icons/pin.ico"));//index of 4
            tv_allDB.ImageList = imgList;
            tv_allDB.SelectedImageIndex = 4;
        }

        private void tv_allDB_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Oracle database
            if (LogDB.ORACLE.Equals(LogDB.ConnectionDatabase))
            {
                try
                {
                    if (tv_allDB.SelectedNode.Nodes.Count == 0 && !tv_allDB.SelectedNode.Text.Equals("Low permissions"))
                    {
                        string sql = "SELECT * FROM " + tv_allDB.SelectedNode.Text;
                        gb_result.Text = "Result set. current table[ " + tv_allDB.SelectedNode.Text + " ]";
                        DataSet ds = ORACLEDBHelp.ExecuteDataSet(sql);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
                catch
                {
                    MessageBox.Show("Currently selected is not a table or Low permissions. ");
                }
            }
            //SQL Server database 
            else if (LogDB.SQLSERVER.Equals(LogDB.ConnectionDatabase))
            {
                try
                {
                    if (tv_allDB.SelectedNode.Nodes.Count == 0)
                    {
                        gb_result.Text = "Result set. current table[ " + tv_allDB.SelectedNode.Text + " ]";
                        string sql = "USE " + tv_allDB.SelectedNode.Parent.Text + ";SELECT * FROM " + tv_allDB.SelectedNode.Text;
                        DataSet ds = SQLSERVERDBHelp.ExecuteDataSet(sql);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
                catch
                {
                    MessageBox.Show("Currently selected is not a table or Low permissions. ");
                }
            }
            //MySQL database
            else if (LogDB.MYSQL.Equals(LogDB.ConnectionDatabase))
            {
                try
                {
                    if (tv_allDB.SelectedNode.Nodes.Count == 0)
                    {
                        gb_result.Text = "Result set. current table[ " + tv_allDB.SelectedNode.Text + " ]";
                        string sql = "USE " + tv_allDB.SelectedNode.Parent.Text + ";SELECT * FROM " + tv_allDB.SelectedNode.Text;
                        DataSet ds = MYSQLDBHelp.ExecuteDataSet(sql);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
                catch
                {
                    MessageBox.Show("Currently selected is not a table or Low permissions. ");
                }
            }
        }

        private void 实体类构建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tv_allDB == null || tv_allDB.SelectedNode == null)
                return;
            if (tv_allDB.SelectedNode.Nodes.Count == 0)
            {
                //如果当前选择的是最后一个子节点,可以暂定为数据表
                string tableName = tv_allDB.SelectedNode.Text;
                EntityBuilderForm entityBuilder = new EntityBuilderForm(tableName);
                entityBuilder.Text = "Entity Builder [DB: " + LogDB.ConnectionDatabase + " | Table: " + tableName + "]";
                entityBuilder.Show();
            }
        }
        private bool isExpendAll = false;
        private void 全部展开AllExperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tv_allDB == null)
                return;
            if (isExpendAll==false)
            {
                tv_allDB.ExpandAll();
                isExpendAll = true;
                全部展开AllExperToolStripMenuItem.Text = "全部关闭(Collapse all)";
            }
            else
            { 
                tv_allDB.CollapseAll();
                isExpendAll = false;
                全部展开AllExperToolStripMenuItem.Text = "全部展开(Expand all)";
            }
        }
    }
}
