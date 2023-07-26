namespace ReverseWords
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string s = "  hello world  ";


            Console.WriteLine(s);


        }

        public static string Re(string s)
        {
            return String.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
            // Split will add string to array and split by ' ', 

            // StringSplitOptions.RemoveEmptyEntries will remove empty ""
            // 
            //"apple,,banana,orange,," > Split() > ["apple", "", "banana", "orange", "", ""]
            // StringSplitOptions.RemoveEmptyEntries will remove all the "" > ["apple", "banana", "orange"]

        }


        public static string ReverseWords(string s)
        {
            List<string> words = new List<string>();

            string a = s.Trim();

            string save = "";

            string ans = "";



            for (int i = 0; i < a.Length; i++)
            {
                if (!a[i].Equals(' '))
                {
                    save += a[i];
                }

                if ((a[i].Equals(' ') && !String.IsNullOrEmpty(save)) || i == a.Length - 1)
                {
                    words.Add(save);
                    save = "";
                }

            }

            for (int j = words.Count - 1; j >= 0; j--)
            {

                ans += words[j];

                if (j != 0)
                {
                    ans += " ";
                }
            }



            return ans;


        }

    }
}