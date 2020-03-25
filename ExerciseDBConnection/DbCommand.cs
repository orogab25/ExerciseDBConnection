using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseDBConnection
{
    class DbCommand
    {
        public DbConnection Connection { get; set; }
        public string Instruction { get; set; }

        public DbCommand(DbConnection connection,string instruction)
        {
            if (connection == null || instruction==null || instruction=="")
            {
                throw new NullReferenceException("The connection and instruction can't be null or empty!");
            }
            Connection = connection;
            Instruction = instruction;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine("Running '"+Instruction+"' command");
            Connection.Close();
        }
    }
}
