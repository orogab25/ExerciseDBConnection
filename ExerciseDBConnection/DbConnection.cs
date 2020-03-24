using System;

namespace ExerciseDBConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public DateTime TempDate { get; set; }

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
        }

        public abstract void Open();

        public abstract void Close();
    }
}
