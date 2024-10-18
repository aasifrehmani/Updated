<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.Dal;
using POS.Model;
using POS.ResponseObjects;
using System.Data;

namespace POS.BLL
{
    public class commonManager
    {
        public static BaseResponse getDataTable(string query)
        {
            BaseResponse responce = new BaseResponse();
            try
            {
                responce.dt = commonDal.getDataTable(query);
                responce.HasResponse = true;
            }
            catch (Exception ex)
            {
                responce.HasResponse = false;
                responce.ErrorMsg = ex.Message;
            }
            return responce;
        }

        public static BaseResponse executeNonQuery(string query)
        {
            BaseResponse responce = new BaseResponse();
            try
            {
                responce.result = commonDal.executeNonQuery(query);
                if (Convert.ToInt16(responce.result) > 0)
                {
                    responce.HasResponse = true;
                }
                else
                {
                    responce.HasResponse = false;
                    responce.ErrorMsg = "No record effected.";
                }

            }
            catch (Exception ex)
            {
                responce.HasResponse = false;
                responce.ErrorMsg = ex.Message;
            }
            return responce;
        }

        public static BaseResponse executeScaller(string query)
        {
            BaseResponse responce = new BaseResponse();
            try
            {
                responce.result = commonDal.executeScaller(query);
                responce.HasResponse = true;
            }
            catch (Exception ex)
            {
                responce.HasResponse = false;
                responce.ErrorMsg = ex.Message;
            }
            return responce;
        }

        public static BaseResponse dbName()
        {
            BaseResponse responce = new BaseResponse();
            try
            {
                responce.result = commonDal.dbName();
                responce.HasResponse = true;
            }
            catch (Exception ex)
            {
                responce.HasResponse = false;
                responce.ErrorMsg = ex.Message;
            }
            return responce;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.Dal;
using POS.Model;
using POS.ResponseObjects;
using System.Data;

namespace POS.BLL
{
    public class commonManager
    {
        public static BaseResponse getDataTable(string query)
        {
            BaseResponse responce = new BaseResponse();
            try
            {
                responce.dt = commonDal.getDataTable(query);
                responce.HasResponse = true;
            }
            catch (Exception ex)
            {
                responce.HasResponse = false;
                responce.ErrorMsg = ex.Message;
            }
            return responce;
        }

        public static BaseResponse executeNonQuery(string query)
        {
            BaseResponse responce = new BaseResponse();
            try
            {
                responce.result = commonDal.executeNonQuery(query);
                if (Convert.ToInt16(responce.result) > 0)
                {
                    responce.HasResponse = true;
                }
                else
                {
                    responce.HasResponse = false;
                    responce.ErrorMsg = "No record effected.";
                }

            }
            catch (Exception ex)
            {
                responce.HasResponse = false;
                responce.ErrorMsg = ex.Message;
            }
            return responce;
        }

        public static BaseResponse executeScaller(string query)
        {
            BaseResponse responce = new BaseResponse();
            try
            {
                responce.result = commonDal.executeScaller(query);
                responce.HasResponse = true;
            }
            catch (Exception ex)
            {
                responce.HasResponse = false;
                responce.ErrorMsg = ex.Message;
            }
            return responce;
        }

        public static BaseResponse dbName()
        {
            BaseResponse responce = new BaseResponse();
            try
            {
                responce.result = commonDal.dbName();
                responce.HasResponse = true;
            }
            catch (Exception ex)
            {
                responce.HasResponse = false;
                responce.ErrorMsg = ex.Message;
            }
            return responce;
        }
    }
}
>>>>>>> 3402ba0e7a57d188dfe7e2632711e20f873e539d
