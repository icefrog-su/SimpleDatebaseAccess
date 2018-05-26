using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;

namespace SimpleDatebaseAccess.Util
{
    public class ORACLEDBHelp
    {
          /// <summary>
        /// 数据库连接地址
        /// </summary>
        private static string address;

        /// <summary>
        /// 数据库连接对象
        /// </summary>
        private static OracleConnection conn;

        /// <summary>
        /// 实例化数据库连接地址和数据库连接对象
        /// </summary>
        static ORACLEDBHelp()
        {
            conn = new OracleConnection(LogDB.ConnectionString);
        }

        public static int ExecuteNonQuery(string sql)
        {
            try
            {//异常处理块
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                int flag = cmd.ExecuteNonQuery();
                return flag;
            }
            catch
            {
                //出现异常则返回-1
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public static object ExecuteScalar(string sql)
        {
            try
            { //异常处理块
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                object obj = cmd.ExecuteScalar();
                return obj;
            }
            catch
            { //抛出异常返回值
                Console.WriteLine("Simple select happend exception");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static OracleDataReader ExecuteDataReader(string sql)
        {
            try
            { //错误处理
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            { //返回异常值
                return null;
            }
        }

        public static DataSet ExecuteDataSet(string sql)
        {
            try
            {//异常处理块
                OracleDataAdapter dat = new OracleDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                dat.Fill(ds);
                return ds;
            }
            catch
            { //抓取异常返回异常值
                return null;
            }
        }

        public static DataTable ExecuteDataTable(string sql)
        {
            DataTable dt = new DataTable();
            dt = ExecuteDataSet(sql).Tables[0];
            return dt;
        }

        public static DataRow ExecuteDataRow(string sql)
        {
            DataRow dr;
            dr = ExecuteDataSet(sql).Tables[0].Rows[0];
            return dr;
        }
    }
}
