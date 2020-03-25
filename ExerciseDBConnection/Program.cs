using System;

namespace ExerciseDBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection sql = new SqlConnection("asd");
            sql.Open();
            sql.Open();
            sql.Close();

            TimeSpan timeout = TimeSpan.FromSeconds(5);
            DbConnection oracle = new OracleConnection("bsd",timeout);
            oracle.Open();
            oracle.Close();
        }
    }
}
