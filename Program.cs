namespace Assignment_6_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums1);
            Console.WriteLine($"Output: [{string.Join(", ", nums1)}]");

            int[] nums2 = { 0 };
            MoveZeroes(nums2);
            Console.WriteLine($"Output: [{string.Join(", ", nums2)}]");
        }

        static void MoveZeroes(int[] nums)
        {
            int nonZeroIndex = 0;

            // Move all non-zero elements to the beginning of the array
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroIndex] = nums[i];
                    nonZeroIndex++;
                }
            }

            // Fill the remaining elements with 0
            for (int i = nonZeroIndex; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }

}
 