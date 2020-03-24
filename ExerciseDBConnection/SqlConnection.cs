using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseDBConnection
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            :base(connectionString)
        {
            Console.WriteLine("Sql connection created without timeout.");
        }

        public SqlConnection(string connectionString,TimeSpan timeout)
            :base(connectionString,timeout)
        {
            Console.WriteLine("Sql connection created with timeout.");
        }

        public override void Open()
        {
            if (Timeout != null)
            {
                if (TempDate != null && (DateTime.Now - TempDate) < Timeout)
                {
                    throw new InvalidOperationException("Wait for the timeout!");
                }
                TempDate = DateTime.Now;
            }
            Console.WriteLine("Opened the sql connection.");
        }

        public override void Close()
        {
            Console.WriteLine("Closed the sql connection.");
        }
    }
}
