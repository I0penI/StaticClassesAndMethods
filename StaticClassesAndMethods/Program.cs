namespace StaticClassesAndMethods
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string test1 = null;
            bool result = Util.StringHasData(test1);
            if(result)
                Console.WriteLine($"{test1} has data.");
            else
                Console.WriteLine("String has no data");

            Config.ConnectionString = "Microsoft SQL Server Connection String";
            Console.WriteLine(Config.ConnectionString);

            Config config = new Config()
            {
                TimeOut = 10
            };
            Console.WriteLine(config.TimeOut);
        }

    }
    static class Util
    {
        public static bool StringHasData(string value) // value: null, value: ", value: " ", value: "  "
        {
            // 1. yöntem
            //if (value == null)
            //    return false;
            //if (value.Trim() == "")
            //    return false;
            //return true;


            //return !string.IsNullOrEmpty(value); // value: null -> true ,  value: "" -> true , value: " " -> false //pek tercih edilmez
            return !string.IsNullOrWhiteSpace(value); // value: null -> true ,  value: "" -> true , value: " " -> true // genelde tercih edilir çünkü boşlukları trimler
        }
    }

    class Config
    {
        public static string ConnectionString { get; set; }
        public int TimeOut { get; set; }


    }
}