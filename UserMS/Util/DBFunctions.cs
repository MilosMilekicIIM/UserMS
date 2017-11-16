using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace UserMS.Util
{
    public static class DBFunctions
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["URIS_IIM_DBConnection"].ConnectionString;
            }
        }
    }
}