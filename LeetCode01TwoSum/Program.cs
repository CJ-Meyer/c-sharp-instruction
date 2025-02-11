namespace LeetCode01TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the two sum LeetCode testing");
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(nums, target);

        }
        static int[] TwoSum(int[] nums, int target)
        {
            int[] indices = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        indices[0] = i;
                        indices[1] = j;
                        Console.WriteLine($"The indices are: {indices[0]} and {indices[1]}");
                        return indices;
                    }
                }
            }
            return indices; 
        }
    }
}
