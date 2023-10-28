using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class DataAccessFactory
    {
        public static IDataAccess DataFactory(string dataBaseType)
        {
            switch (dataBaseType)
            {
                case "mongo":
                    return new MongoDataAccess();

                case "sql":
                    return new SQLDataAccess();

                case "list":
                    return new ListDataAccess();

                default:
                    return new SQLDataAccess();
            }
         

        }
    }
}
