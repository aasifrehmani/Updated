<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Collections;
using Decode;

namespace POS.Core
{
    public static class Settings
    {

        // Initialization is needed to make locks work in any circumstance
        private static Dictionary<string, string> config;

        /// <summary>
        /// Initializes the internal data.
        /// </summary>
        static Settings()
        {
            config = new Dictionary<string, string>();
        }


        #region HardCoded settings

        /// <summary>
        /// Gets the Master Password, used to encrypt the Users data.
        /// </summary>
        public static string DBConnectionString
        {
            get
            {
                // Read the file as one string.
                System.IO.StreamReader myFile = new System.IO.StreamReader("ConnectionString.txt");
                string myString = myFile.ReadToEnd();
                myFile.Close();
                //string connectionString = System.Configuration.ConfigurationSettings.AppSettings["DBConnectionString"]; //@"Data Source=SONY\SQLEXPRESS;Initial Catalog=CPlusPortal;Integrated Security=True"; //ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
               // string connectionString = Decode.Decode.DecodeString(myString.ToString());//"Data Source=221.120.222.251;Initial Catalog=SMS;user id=sa;password=Reg@ssc13;";
                string connectionString = myString.ToString();//"Data Source=221.120.222.251;Initial 
                if (connectionString == null || connectionString.Length == 0)
                    throw new Exception("Configuration: DBConnectionString cannot be null.");

                return connectionString;
            }
        }

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
using System.Xml;
using System.Collections;
using Decode;

namespace POS.Core
{
    public static class Settings
    {

        // Initialization is needed to make locks work in any circumstance
        private static Dictionary<string, string> config;

        /// <summary>
        /// Initializes the internal data.
        /// </summary>
        static Settings()
        {
            config = new Dictionary<string, string>();
        }


        #region HardCoded settings

        /// <summary>
        /// Gets the Master Password, used to encrypt the Users data.
        /// </summary>
        public static string DBConnectionString
        {
            get
            {
                // Read the file as one string.
                System.IO.StreamReader myFile = new System.IO.StreamReader("ConnectionString.txt");
                string myString = myFile.ReadToEnd();
                myFile.Close();
                //string connectionString = System.Configuration.ConfigurationSettings.AppSettings["DBConnectionString"]; //@"Data Source=SONY\SQLEXPRESS;Initial Catalog=CPlusPortal;Integrated Security=True"; //ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
               // string connectionString = Decode.Decode.DecodeString(myString.ToString());//"Data Source=221.120.222.251;Initial Catalog=SMS;user id=sa;password=Reg@ssc13;";
                string connectionString = myString.ToString();//"Data Source=221.120.222.251;Initial 
                if (connectionString == null || connectionString.Length == 0)
                    throw new Exception("Configuration: DBConnectionString cannot be null.");

                return connectionString;
            }
        }

        #endregion
    }
}
>>>>>>> 3402ba0e7a57d188dfe7e2632711e20f873e539d
