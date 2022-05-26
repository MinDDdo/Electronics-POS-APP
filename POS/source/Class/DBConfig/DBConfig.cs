﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POS
{
    static class DBConfig
    {
        private static string server = "HP\\DEMODB";
        private static string database = "ElectronicsDB";
        private static string user = "user2";
        private static string password = "mypass2";
        private static string strConnect = $"server = {server};" +
                                           $"database = {database};" +
                                           $"user id = {user};" +
                                           $"password = {password};";
        public static SqlConnection conn = new SqlConnection(strConnect);

    }
}
