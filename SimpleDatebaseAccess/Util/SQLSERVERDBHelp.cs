using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SimpleDatebaseAccess.Util
{
    /// <summary>
    /// Operation database basic class
    /// Authod:ICE FROG
    /// </summary>
    public class SQLSERVERDBHelp
    {
        /// <summary>
        /// 数据库连接地址
        /// </summary>
        private static string address;

        /// <summary>
        /// 数据库连接对象
        /// </summary>
        private static SqlConnection conn;

        /// <summary>
        /// rebuild a SQLDataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader ReBuilderSqlDataReader(string sql)
        {
            SqlDataReader reader = null;
            SqlConnection reConn = new SqlConnection(LogDB.ConnectionString);
            try
            { //错误处理
                reConn.Open();
                SqlCommand cmd = new SqlCommand(sql, reConn);
                reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            { //返回异常值
                return reader;
            }
        }

        /// <summary>
        /// 实例化数据库连接地址和数据库连接对象
        /// </summary>
        static SQLSERVERDBHelp()
        {
            conn = new SqlConnection(LogDB.ConnectionString);
        }
        /// <summary>
        /// 执行增删改操作，返回受影响的行数
        /// 出现异常返回-1
        /// </summary>
        /// <param name="sql">数据库执行语句</param>
        /// <param name="parr">参数化数组</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            try
            {//异常处理块
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
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

        /// <summary>
        /// 执行单值查询操作，返回查询到的第一行第一列的值。忽略其他值-参数化技术
        /// 如果出现异常 返回null
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parr"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            try
            { //异常处理块
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                object obj = cmd.ExecuteScalar();
                return obj;
            }
            catch
            { //抛出异常返回值
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 多值查询操作，返回SqlDataReader阅读器对象-参数化技术
        /// 如果出现异常则返回null;
        /// </summary>
        /// <param name="sql">数据库执行语句</param>
        /// <param name="parr">参数化列表</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteDataReader(string sql)
        {
            try
            { //错误处理
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            { //返回异常值
                return null;
            }
        }

        /// <summary>
        /// 执行查询数据表的操作，返回查询到的表的集合-参数化技术
        /// 如果发生异常 返回null
        /// </summary>
        /// <param name="sql">数据库执行语句</param>
        /// <param name="parr">参数化列表</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string sql)
        {
            try
            {//异常处理块
                SqlDataAdapter dat = new SqlDataAdapter(sql,conn);
                DataSet ds = new DataSet();
                dat.Fill(ds);
                return ds;
            }
            catch(Exception ex)
            { //抓取异常返回异常值
                Console.WriteLine("++++++++++++++++++++++++++++++"+ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 基函数:ExecuteDataSet()
        /// 执行查询表的操作，返回查询到的表对象-参数化技术
        /// 出现异常，返回null
        /// </summary>
        /// <param name="sql">数据库执行语句</param>
        /// <param name="parr">参数化列表</param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string sql)
        {
            DataTable dt = new DataTable();
            dt = ExecuteDataSet(sql).Tables[0];
            return dt;
        }

        /// <summary>
        /// 基函数:ExecuteDataSet()
        /// 执行查询数据行的操作，返回查询到的表的第一行。忽略其他行-参数化技术
        /// </summary>
        /// <param name="sql">数据库执行语句</param>
        /// <param name="parr">参数化列表</param>
        /// <returns></returns>
        public static DataRow ExecuteDataRow(string sql)
        {
            DataRow dr;
            dr = ExecuteDataSet(sql).Tables[0].Rows[0];
            return dr;
        }
    }
}
