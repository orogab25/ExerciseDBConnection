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
            if (Timeout.TotalMilliseconds != 0)
            {
                if (Stopwatch.Elapsed != null)
                {
                    if (Stopwatch.Elapsed < Timeout)
                    {
                        throw new InvalidOperationException("Wait for the timeout!");
                    }
                    Stopwatch.Stop();
                }
            }
            Console.WriteLine("Opened the sql connection.");
        }

        public override void Close()
        {
            if (Timeout.TotalMilliseconds != 0)
            {
                if (Stopwatch.Elapsed != null)
                {
                    throw new InvalidOperationException("You need to open it first!");
                }
                Stopwatch.Start();
            } 
            Console.WriteLine("Closed the sql connection.");
        }
    }
}
