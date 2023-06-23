namespace Product_of_Array_Except_Self
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 1, 0, 0, 3 };
            int[] nums2 = new int[3];

            foreach (int i in ProductExceptSelf(nums))
            {
                Console.WriteLine(i);

            }
        }


        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int sum = 1;
            int numberOfZero = 0;
            int positionOfZero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    numberOfZero++;
                    positionOfZero = i;

                    sum *= 1;
                    continue;
                }
                sum *= nums[i];
            }

            if (numberOfZero == 0)
            {


                for (int j = 0; j < result.Length; j++)
                {
                    result[j] = sum / nums[j];
                }

            } 
            
            else if (numberOfZero == 1)

            {
                result[positionOfZero] = sum;
            }
            Console.WriteLine("Sum is " + sum);
            return result;
        }
    }
}