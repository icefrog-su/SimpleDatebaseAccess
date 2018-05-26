using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDatebaseAccess.Util
{
    //LOG APPLICATION USED INFORMATION
    public class LogDB
    {
        //LOG THIS CONFIGURATION INFORMATION
        public static string ConnectionString;
        public static string ConnectionDatabase;
        public static string dbversion;

        //APPLICATION CONTENT DATABASE NAME,USE THE DATABASE MUST CALL THE MEMBER
        public const string ORACLE = "Oracle";
        public const string SQLSERVER = "SQLServer";
        public const string MYSQL = "MySQL";

        //SELECT ORACLE/MYSQL/SQLSERVER DATABASE'S ALL DATABASE OR USER T-SQL/PL-SQL SCRIPT
        /// <summary>
        /// SELECT ORACLE DATABASE'S ALL USER
        /// </summary>
        public const string ORACLE_ALL_USER_SCRIPT = "SELECT * FROM ALL_USERS";

        /// <summary>
        /// SELECT MYSQL DATABASE ALL DATABASE NAME
        /// </summary>
        public const string MYSQL_ALL_TABLE_SCRIPT = "SHOW DATABASES";

        /// <summary>
        /// SELECT SQLSERVER DATABASE ALL DATABASE NAME
        /// </summary>
        public const string SQLSERVER_ALL_TABLE_SCRIPT = "SELECT NAME FROM MASTER..SYSDATABASES ORDER BY NAME";

        /// <summary>
        /// SELECT ORACLE DATABASE CURRENT LOGINED USERNAME
        /// </summary>
        public const string ORACLE_CURRENT_USERNAME = "SELECT USER FROM DUAL";

        /// <summary>
        /// SELECT ORACLE DATABASE CURRENT USER'S ALL TABLE
        /// </summary>
        public const string ORACLE_CURRENT_USERNAME_TABLE = "SELECT TABLE_NAME FROM TABS";
    }
}
