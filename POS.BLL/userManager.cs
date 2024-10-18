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
    public class userManager
    {
        public static userResponse  ValidateUserLogin(string query)
        {
            userResponse res = new userResponse();
            try
            {
                res.UserRecord = userDal.ValidateUser(query);
                if (res.UserRecord.ID > 0)
                {
                    res.HasResponse = true;
                }

                //res.HasResponse = true;
            }
            catch (Exception ex)
            {
                res.ErrorMsg = ex.Message;
                res.HasResponse = false;
            }

            return res;
        }

        public static BaseResponse insert(userInfo info)
        {
            BaseResponse response = new BaseResponse();
            try
            {
                userDal.Insert(info);
                response.HasResponse = true;
            }
            catch (Exception ex)
            {
                response.HasResponse = false;
                response.ErrorMsg = ex.Message.ToString();
            }
            return response;
        }
        public static BaseResponse Update(userInfo info)
        {
            BaseResponse response = new BaseResponse();
            try
            {
                userDal.Update(info);
                response.HasResponse = true;
            }
            catch (Exception ex)
            {
                response.HasResponse = false;
                response.ErrorMsg = ex.Message.ToString();
            }
            return response;
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
    public class userManager
    {
        public static userResponse  ValidateUserLogin(string query)
        {
            userResponse res = new userResponse();
            try
            {
                res.UserRecord = userDal.ValidateUser(query);
                if (res.UserRecord.ID > 0)
                {
                    res.HasResponse = true;
                }

                //res.HasResponse = true;
            }
            catch (Exception ex)
            {
                res.ErrorMsg = ex.Message;
                res.HasResponse = false;
            }

            return res;
        }

        public static BaseResponse insert(userInfo info)
        {
            BaseResponse response = new BaseResponse();
            try
            {
                userDal.Insert(info);
                response.HasResponse = true;
            }
            catch (Exception ex)
            {
                response.HasResponse = false;
                response.ErrorMsg = ex.Message.ToString();
            }
            return response;
        }
        public static BaseResponse Update(userInfo info)
        {
            BaseResponse response = new BaseResponse();
            try
            {
                userDal.Update(info);
                response.HasResponse = true;
            }
            catch (Exception ex)
            {
                response.HasResponse = false;
                response.ErrorMsg = ex.Message.ToString();
            }
            return response;
        }
    }
}
>>>>>>> 3402ba0e7a57d188dfe7e2632711e20f873e539d
