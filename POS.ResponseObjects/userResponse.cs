<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using POS.Model;

namespace POS.ResponseObjects
{
    public class userResponse : BaseResponse
    {
        public bool User { get; set; }
        public userInfo UserRecord { get; set; }
        public IList<userInfo> UserList { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using POS.Model;

namespace POS.ResponseObjects
{
    public class userResponse : BaseResponse
    {
        public bool User { get; set; }
        public userInfo UserRecord { get; set; }
        public IList<userInfo> UserList { get; set; }
    }
}
>>>>>>> 3402ba0e7a57d188dfe7e2632711e20f873e539d
