using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Dapper;

namespace DA_PhanHe1
{
    class OracleConnect
    {
        public static string connString(string host, string port, string servicename, string user, string pass)
        {
            return String.Format(
              "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})" +
              "(PORT={1}))(CONNECT_DATA=(SERVICE=DEDICATED)));User Id={3};Password={4};",
              host,
              port,
              servicename,
              user,
              pass);
        }
    }
}
