﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class MemberData
    {
        public static string id_pur;
        public static string id;
        public static string fname;
        public static string lname;
        public static string email;
        public static string address;
        public static string status;

        public static void clearData()
        {
            id_pur = null;
            id = null;
            fname = null;
            lname = null;
            email = null;
            address = null;
            status = null;
        }
    }
}
