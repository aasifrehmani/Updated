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
    public class userDal
    {
        public static int TotalRecord { get; set; }
        public static userInfo ValidateUser(string query)
        {
            userInfo User = null;

          
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(Settings.DBConnectionString, CommandType.Text, query, null))
            {
                if (rdr.Read())
                {
                    User = PopulateRecord(rdr);
                }
            }
            return User;
        }
        private static userInfo PopulateRecord(SqlDataReader rowData)
        {
            return new userInfo
            {
                ID = Convert.ToInt32(rowData["ID"]),
                userName = Convert.ToString(rowData["userName"]),
                password = Convert.ToString(rowData["password"]),
                address = Convert.ToString(rowData["address"]),
                contactInfo = Convert.ToString(rowData["contactInfo"]),
                rights = Convert.ToString(rowData["rights"]),
                isActive = Convert.ToString(rowData["isActive"]),
                dateCreated = Convert.ToDateTime(rowData["dateCreated"]),
                dateUpdated = Convert.ToDateTime(rowData["dateUpdated"]),
                updatedBy = Convert.ToString(rowData["updatedBy"]),
                SOID = Convert.ToString(rowData["SOID"]),
            };
        }
        public static void Insert(userInfo info)
        {
            SqlParameter[] paramList = GetParametersByEntity();

            paramList[0].Value = info.ID;
            paramList[1].Value = info.userName;
            paramList[2].Value = info.password;
            paramList[3].Value = info.address;
            paramList[4].Value = info.contactInfo;
            paramList[5].Value = info.rights;
            paramList[6].Value = info.isActive;
            paramList[7].Value = info.dateCreated;
            paramList[8].Value = info.dateUpdated;
            paramList[9].Value = info.updatedBy;

            SqlHelper.ExecuteNonQuery(Settings.DBConnectionString, CommandType.StoredProcedure, "Sp_InsertUser", paramList);
        }
        public static void Update(userInfo info)
        {
            SqlParameter[] paramList = GetParametersByEntity();

            paramList[0].Value = info.ID;
            paramList[1].Value = info.userName;
            paramList[2].Value = info.password;
            paramList[3].Value = info.address;
            paramList[4].Value = info.contactInfo;
            paramList[5].Value = info.rights;
            paramList[6].Value = info.isActive;
            paramList[7].Value = info.dateCreated;
            paramList[8].Value = info.dateUpdated;
            paramList[9].Value = info.updatedBy;

            SqlHelper.ExecuteNonQuery(Settings.DBConnectionString, CommandType.StoredProcedure, "Sp_UpdateUser", paramList);
        }
       private static SqlParameter[] GetParametersByEntity()
        {
            return new SqlParameter[]
            {      
                new SqlParameter("@ID", SqlDbType.Int),
	            new SqlParameter("@userName", SqlDbType.VarChar),
	            new SqlParameter("@password", SqlDbType.VarChar),
	            new SqlParameter("@address", SqlDbType.VarChar),
	            new SqlParameter("@contactInfo", SqlDbType.VarChar),
	            new SqlParameter("@rights", SqlDbType.VarChar),
	            new SqlParameter("@isActive", SqlDbType.VarChar),
	            new SqlParameter("@dateCreated",SqlDbType.DateTime),
	            new SqlParameter("@dateUpdated",SqlDbType.DateTime),
	            new SqlParameter("@updatedBy", SqlDbType.VarChar),
            };
        }

        #region Admin Methods


        #endregion
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
    public class userDal
    {
        public static int TotalRecord { get; set; }
        public static userInfo ValidateUser(string query)
        {
            userInfo User = null;

          
            using (SqlDataReader rdr = SqlHelper.ExecuteReader(Settings.DBConnectionString, CommandType.Text, query, null))
            {
                if (rdr.Read())
                {
                    User = PopulateRecord(rdr);
                }
            }
            return User;
        }
        private static userInfo PopulateRecord(SqlDataReader rowData)
        {
            return new userInfo
            {
                ID = Convert.ToInt32(rowData["ID"]),
                userName = Convert.ToString(rowData["userName"]),
                password = Convert.ToString(rowData["password"]),
                address = Convert.ToString(rowData["address"]),
                contactInfo = Convert.ToString(rowData["contactInfo"]),
                rights = Convert.ToString(rowData["rights"]),
                isActive = Convert.ToString(rowData["isActive"]),
                dateCreated = Convert.ToDateTime(rowData["dateCreated"]),
                dateUpdated = Convert.ToDateTime(rowData["dateUpdated"]),
                updatedBy = Convert.ToString(rowData["updatedBy"]),
                SOID = Convert.ToString(rowData["SOID"]),
            };
        }
        public static void Insert(userInfo info)
        {
            SqlParameter[] paramList = GetParametersByEntity();

            paramList[0].Value = info.ID;
            paramList[1].Value = info.userName;
            paramList[2].Value = info.password;
            paramList[3].Value = info.address;
            paramList[4].Value = info.contactInfo;
            paramList[5].Value = info.rights;
            paramList[6].Value = info.isActive;
            paramList[7].Value = info.dateCreated;
            paramList[8].Value = info.dateUpdated;
            paramList[9].Value = info.updatedBy;

            SqlHelper.ExecuteNonQuery(Settings.DBConnectionString, CommandType.StoredProcedure, "Sp_InsertUser", paramList);
        }
        public static void Update(userInfo info)
        {
            SqlParameter[] paramList = GetParametersByEntity();

            paramList[0].Value = info.ID;
            paramList[1].Value = info.userName;
            paramList[2].Value = info.password;
            paramList[3].Value = info.address;
            paramList[4].Value = info.contactInfo;
            paramList[5].Value = info.rights;
            paramList[6].Value = info.isActive;
            paramList[7].Value = info.dateCreated;
            paramList[8].Value = info.dateUpdated;
            paramList[9].Value = info.updatedBy;

            SqlHelper.ExecuteNonQuery(Settings.DBConnectionString, CommandType.StoredProcedure, "Sp_UpdateUser", paramList);
        }
       private static SqlParameter[] GetParametersByEntity()
        {
            return new SqlParameter[]
            {      
                new SqlParameter("@ID", SqlDbType.Int),
	            new SqlParameter("@userName", SqlDbType.VarChar),
	            new SqlParameter("@password", SqlDbType.VarChar),
	            new SqlParameter("@address", SqlDbType.VarChar),
	            new SqlParameter("@contactInfo", SqlDbType.VarChar),
	            new SqlParameter("@rights", SqlDbType.VarChar),
	            new SqlParameter("@isActive", SqlDbType.VarChar),
	            new SqlParameter("@dateCreated",SqlDbType.DateTime),
	            new SqlParameter("@dateUpdated",SqlDbType.DateTime),
	            new SqlParameter("@updatedBy", SqlDbType.VarChar),
            };
        }

        #region Admin Methods


        #endregion
    }
}
>>>>>>> 3402ba0e7a57d188dfe7e2632711e20f873e539d
