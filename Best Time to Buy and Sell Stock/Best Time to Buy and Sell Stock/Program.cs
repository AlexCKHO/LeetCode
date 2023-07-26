namespace Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Dictionary<string, int>  test = new Dictionary<string, int>();

            test["one"] = 1;
            test["two"] = 2;
            test["three"] = 3;
            test["four"] = 4;


            foreach (KeyValuePair<string,int> pair in test)
            {
              
                Console.WriteLine($"{pair.Key} is {pair.Value}"   );
            }

            foreach (KeyValuePair<string, int> pair in test)
            {
                if (pair.Key == "four")
                {
                    test.Remove("four");
                }
                   
            }

            foreach (KeyValuePair<string, int> pair in test)
            {

                Console.WriteLine($"{pair.Key} is {pair.Value}");
            }
        }
    }
}