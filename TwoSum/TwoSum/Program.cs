namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 7, 11, 15 };
            Console.WriteLine(TwoSum(ints, 13)[0] + "," + TwoSum(ints, 13)[1]);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
                if (pairs.ContainsKey(target - nums[i]))
                    //if you finally find the last match
                    return new int[] { pairs[target - nums[i]], i };
                //pair[target - nums[i]] = the previous value in the array

                else
                    pairs.TryAdd(nums[i], i);

            return default;
        }

    }
}

