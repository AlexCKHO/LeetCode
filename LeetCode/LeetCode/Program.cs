namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] array = new char[] { 'a', 'a', 'a', 'b', 'b', 'c' };

            StringCompression stringCompression = new StringCompression();

            Console.WriteLine(stringCompression.Compress(array));
        }
    }
}