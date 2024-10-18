<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace POS.ResponseObjects
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            HasResponse = false;
            ErrorMsg = string.Empty;
            dt = null;
            result = string.Empty;
        }

        public bool HasResponse { get; set; }
        public string ErrorMsg { get; set; }
        public DataTable dt { get; set; }
        public string result { get; set; }
    }

    /// <summary>
    /// Class to return Dataset
    /// </summary>
    public class DataSetResponse : BaseResponse
    {
        public DataSet DefaultDataSet { get; set; }
        public int TotalRecords { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace POS.ResponseObjects
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            HasResponse = false;
            ErrorMsg = string.Empty;
            dt = null;
            result = string.Empty;
        }

        public bool HasResponse { get; set; }
        public string ErrorMsg { get; set; }
        public DataTable dt { get; set; }
        public string result { get; set; }
    }

    /// <summary>
    /// Class to return Dataset
    /// </summary>
    public class DataSetResponse : BaseResponse
    {
        public DataSet DefaultDataSet { get; set; }
        public int TotalRecords { get; set; }
    }
}
>>>>>>> 3402ba0e7a57d188dfe7e2632711e20f873e539d
