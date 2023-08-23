namespace Longest_Consecutive_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] o ={0,0};
            Console.WriteLine(LongestConsecutive(o));
        }

        public static int LongestConsecutive(int[] nums)
        {
            Array.Sort(nums);
            HashSet<int> set = new HashSet<int>(nums);
            List<int> ints = new List<int>(set);
            int result = 0;
            int count = 0;
            
            for(int i = 1; i < set.Count; i++)
            {
                if (ints[i] - ints[i-1] == 1)
                {
                    count++;

                    if(count> result)
                    {
                        result = count;
                    }
                }
                else
                {
                    count = 0;
                }

                
            }
            if(nums.Length == 1)
            {
                return 1;
            }


            return result==0?0:++result;
        }
    }
}