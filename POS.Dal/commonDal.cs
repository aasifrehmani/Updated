<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using POS.Core;
using POS.DBUtility;
using POS.Model;

namespace POS.Dal
{
    public class commonDal
    {
        public static DataTable getDataTable(string query)
        {
            DataTable dt = new DataTable();
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(Settings.DBConnectionString, CommandType.Text, query, null))
            {
                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                }
            }
            return dt;
        }
        public static string executeNonQuery(string query)
        {
            return Convert.ToString(SqlHelper.ExecuteNonQuery(Settings.DBConnectionString, CommandType.Text, query, null));
        }
        public static string executeScaller(string query)
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(Settings.DBConnectionString, CommandType.Text, query, null));
        }

        public static string dbName()
        {
            return Settings.DBConnectionString;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using POS.Core;
using POS.DBUtility;
using POS.Model;

namespace POS.Dal
{
    public class commonDal
    {
        public static DataTable getDataTable(string query)
        {
            DataTable dt = new DataTable();
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(Settings.DBConnectionString, CommandType.Text, query, null))
            {
                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                }
            }
            return dt;
        }
        public static string executeNonQuery(string query)
        {
            return Convert.ToString(SqlHelper.ExecuteNonQuery(Settings.DBConnectionString, CommandType.Text, query, null));
        }
        public static string executeScaller(string query)
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(Settings.DBConnectionString, CommandType.Text, query, null));
        }

        public static string dbName()
        {
            return Settings.DBConnectionString;
        }
    }
}
>>>>>>> 3402ba0e7a57d188dfe7e2632711e20f873e539d
