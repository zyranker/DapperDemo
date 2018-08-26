using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DapperDemo
{
    class SQLHelper
    {
        public static string ConnString
        {
            get { return System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString; }
        }
    }
}
