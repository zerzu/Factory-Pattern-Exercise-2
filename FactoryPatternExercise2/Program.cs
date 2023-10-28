using System.Linq.Expressions;

namespace FactoryPatternExercise2
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            int selection;

            Console.WriteLine("What type of DataBase would you like to store your data in?");
            Console.WriteLine("PLease Select 1 for a MongoDB, 2 for a SQL DB, or 3 to put your data in a list");

            var input = Console.ReadLine();

            if (int.TryParse(input, out selection) && (selection > 0) && (selection < 4))
            {
                var dataBaseType = (selection == 1) ? "mongo" : (selection == 2) ? "sql" : (selection == 3) ? "list" : "default";
                IDataAccess db = DataAccessFactory.DataFactory(dataBaseType);
                db.GetDatabase();
                db.SaveData();
            }

            else
            {
                Console.WriteLine("Invalid input, goodbye!");
            }
        }
    }
}
