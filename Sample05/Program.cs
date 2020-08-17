using System;
using System.Data.SqlClient;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using Sample05.Sample05.Models;
using System.Configuration;
using System.Linq;
using Sample05.DbOperator;

namespace Sample05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestDapperSelect();
        }

        static void TestDapperSelect()
        {
            using (var conn = DapperFactory.CrateOracleConnection())
            {
                string insertSql = "SELECT * FROM RPT_TW_ODST_BOM_TRACE WHERE UNITID = :unitid AND MATERIALNO = :materialno";
                var result = conn.Query<RPT_TW_ODST_BOM_TRACE>(insertSql, new { unitid = "DLC95140049KTY2AH", materialno = "095-0009-F937H" });
                Console.WriteLine(result.Count().ToString());
                Console.ReadKey();
            }
        }
    }
}
