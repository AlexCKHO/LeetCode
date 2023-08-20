namespace Increasing_Triplet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 1, 5, 0, 4, 6 };



            Console.WriteLine(IncreasingTripet(nums)); 
        }


        public static bool IncreasingTripet(int[] nums)
        {

            if (nums.Length < 3)
            {
                return false;
            }
            // { 2, 1, 5, 0, 4, 6 };
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in nums)
            {
                if (num <= smallest)
                {   // Find the smallest number
                    smallest = num;
                }
                else if (num <= secondSmallest)
                {  // If get here, this number is larger than smallest number
                    secondSmallest = num;
                }
                else
                {  // If get here, smallest, secondSmallest and bigger number will be in a row.
                    return true;
                }
            }

            return false;
        }
    }
}