using System;

namespace ExerciseDBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection sql = new SqlConnection("sql");
            sql.Open();
            sql.Close();

            TimeSpan timeout = TimeSpan.FromSeconds(5);
            DbConnection oracleTimeout = new OracleConnection("oracle",timeout);

            DbConnection oracle = new OracleConnection("oracle");

            DbCommand sqlCommand = new DbCommand(sql, "sql command");
            sqlCommand.Execute();

            DbCommand oracleCommand = new DbCommand(oracle, "oracle command");
            oracleCommand.Execute();
        }
    }
}
