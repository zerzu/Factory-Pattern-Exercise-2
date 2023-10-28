using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal interface IDataAccess
    {
        public int size { get; set; }
        public bool isRelational { get; set; }
        public bool isSynchronized { get; set; }

        public void GetDatabase();

        public void SaveData();
       
    }
}
