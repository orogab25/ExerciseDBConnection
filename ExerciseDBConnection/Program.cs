using System;

namespace ExerciseDBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection sql = new SqlConnection("asd");
            DbConnection oracle = new OracleConnection("bsd");

            sql.Open();
            sql.Close();
        }
    }
}
