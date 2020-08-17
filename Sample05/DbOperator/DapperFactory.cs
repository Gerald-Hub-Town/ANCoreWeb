using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace Sample05.DbOperator
{
    public class DapperFactory
    {
        public static readonly string connectionString = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = ksrpti-scan.luxshare.com.cn)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = ksrpti)));Persist Security Info=True;User ID=rptprod;Password=rptprod;";

        public static OracleConnection CrateOracleConnection()
        {
            var connection = new OracleConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
