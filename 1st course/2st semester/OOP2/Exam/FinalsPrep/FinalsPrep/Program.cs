namespace FinalsPrep;

class Program
{
    static void Main(string[] args)
    {
        void ProccessData(ref int refVar, in int inVar, out int outVar)
        {
            // ref - we can read or edit it(will affect the variable in the Main())
            Console.WriteLine(refVar);
            refVar = 15;
        
            // in - we can only read, cannot change
            Console.WriteLine(inVar);
        
            // out - we can only read it after assigning a value to it(we must)
            outVar = 99;
            Console.WriteLine(outVar);
        }
        
        
        
        
        
        // Action - returns void
        Action<string, int> Greet = (name, age) =>
            Console.WriteLine($"Hi {name}, you are {age} years old!");
        
        // Func - returns double(the last type on the <>)
        Func<double, double, double> GetAverage = (num1, num2) =>
            (num1+num2)/2;
        
        // Predicate - recieves one argument, returns bool
        Predicate<string> StartsWithA = word =>
            word.StartsWith("A");
        
        // Example of usage of lambda functions and predicate
        List<string> words = new List<string> {"Apple", "Pear", "Kiwi", "Banana", "Avocado", "Apricot"};
        List<string> wordsWithA = words.FindAll(StartsWithA);
        
        // Multicast Delegates
        Action<string> notificationService = null;
        
        notificationService += message => Console.WriteLine($"[SMS изпратен]: {message}");
        
        notificationService += message => Console.WriteLine($"[Email изпратен]: {message}");
        
        void LogToFile(string text)
        {
            Console.WriteLine($"[Лог във файл]: Записване на '{text}' в log.txt...");
        }
        
        notificationService += LogToFile;
        
        notificationService("Успешно се записахте за курса по C#!");
        
        
        
        
        
        // Extension methods
        //public static class IntExtensions
        //{
        //    public static bool IsPositive(this int num)
        //    {
        //        return num > 0;
        //    }
        //}
        
        //int num = 5;
        // Console.WriteLine(num.IsPositive());
        
        
        
        
        
        // LINQ
        List<Player> players = new List<Player>
        {
            new Player { Score = 45 },
            new Player { Score = 120 },
            new Player { Score = 80 },
            new Player { Score = 150 }
        };

        var resultLambda = players.Where( p => p.Score > 50)
                                  .OrderBy(p => p.Score)
                                  .Select(p => p.Score);

        var resultQuery = from p in players
                          where p.Score > 50
                          orderby p.Score
                          select p;




        var VIPNumbersQuery = from p in players
                 where p.Score > 100
                 orderby p.Score descending
                 select p.Score;

        var VIPNumbersLambda = players.Where(p => p.Score > 100)
                                      .OrderByDescending(p => p.Score)
                                      .Select(p => p.Score);


        
    }

    public class Player
    {
        public int Score {get;set;}
    }
}
