using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseDBConnection
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            Console.WriteLine("Oracle connection created without timeout.");
        }

        public OracleConnection(string connectionString, TimeSpan timeout)
            : base(connectionString, timeout)
        {
            Console.WriteLine("Oracle connection created with timeout.");
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
            Console.WriteLine("Opened the oracle connection.");
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
            Console.WriteLine("Closed the oracle connection.");
        }
    }
}
