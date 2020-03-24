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
            if (Timeout != null)
            {
                if (TempDate != null && (DateTime.Now - TempDate) < Timeout)
                {
                    throw new InvalidOperationException("Wait for the timeout!");
                }
                TempDate = DateTime.Now;
            }
            Console.WriteLine("Opened the oracle connection.");
        }

        public override void Close()
        {
            Console.WriteLine("Closed the oracle connection.");
        }
    }
}
