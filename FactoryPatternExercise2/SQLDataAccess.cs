using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public int size
        {
            get; set;
        }
        public bool isRelational
        {
            get; set;
        }
        public bool isSynchronized
        {
            get; set;
        }

        public void GetDatabase()
        {
            Console.WriteLine($"I am reading data from SQL DB...");
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL DB...");
        }
    }
}
