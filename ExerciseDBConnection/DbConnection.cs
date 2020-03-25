using System;
using System.Diagnostics;

namespace ExerciseDBConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public Stopwatch Stopwatch { get; set; }

        public DbConnection(string connectionString)
        {
            if(connectionString==null || connectionString == "")
            {
                throw new InvalidOperationException("connectionString is empty or null");
            }
            ConnectionString = connectionString;
        }

        public DbConnection(string connectionString,TimeSpan timeout)
            :this(connectionString)
        {
            Timeout = timeout;
            Stopwatch = new Stopwatch();
        }

        public abstract void Open();

        public abstract void Close();
    }
}
