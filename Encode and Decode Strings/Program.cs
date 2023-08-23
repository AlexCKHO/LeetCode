using System.Text;

namespace Encode_and_Decode_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> list = new List<string>() { "", "vn" };
            var result = decode(encode(list));
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

        }

        public static string encode(IList<string> strs)
        {
            StringBuilder sb = new();
            for (int i = 0; i < strs.Count; i++)
            {
                if (i == strs.Count - 1) //If that string is the last one in the list  then, don't add the sb.Append("\n");
                {
                    sb.Append(strs[i]);
                }
                else
                {
                    sb.Append(strs[i]);
                    sb.Append("\n");
                }

            }
            return sb.ToString();

        }

        // Decodes a single string to a list of strings.
        public static IList<string> decode(string s)
        {
            string[] arr = s.Split('\n');
            return arr.ToList();
        }

    }
}