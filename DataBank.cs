using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSQLApp
{
    static class DataBank
    {

        public static string loginShow = "User Name";
        public static string userName = "name";
        public static string userPost = "post";


        public static string taskId;

        // data task edit info
        public static DateTime date;
        public static string description;
        public static string responsible;
        public static string priority;
        public static string status;

        // data group edit info

        public static int group_id;
    }



}
