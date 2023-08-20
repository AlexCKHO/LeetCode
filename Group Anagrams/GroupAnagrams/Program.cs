using System.Collections.Generic;

namespace GroupAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] str = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            string[] sortedstr = new string[] { "aet", "aet", "ant", "aet", "ant", "abt" };
            string[] str1 = new string[] { "a" };

            foreach (var kvp in GroupAnagrams(str1))
            {
                Console.WriteLine("--------------------------------------------");

                foreach (var item in kvp)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("--------------------------------------------");
            }
        }



        public static List<List<string>> GroupAnagrams(string[] strs)
        {
            HashSet<string> set = new HashSet<string>();
            string[] sortedStringsArray = new string[strs.Length];
            List<List<string>> list = new List<List<string>>();
            Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();



            for(int i = 0; i < strs.Length; i++)
            {
                char[] charArray = strs[i].ToCharArray();
                Array.Sort(charArray);
                string sortedString = new string(charArray);
                sortedStringsArray[i] = sortedString; // Adding sorted item in the sorted list
                if (!keyValuePairs.ContainsKey(sortedString))
                {
                    keyValuePairs.Add(sortedString, new List<string>());
                    keyValuePairs[sortedString].Add(strs[i]);
                } else if (keyValuePairs.ContainsKey(sortedString))
                {
                    keyValuePairs[sortedString].Add(strs[i]);
                }
            }

            foreach(var item in keyValuePairs)
            {
                item.Value.Sort();
                list.Add(item.Value);

            }

            return list;
            
            

        }

    }
}