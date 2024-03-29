namespace TwoSumCC3
{
    public class SolutionTwoSum
    {
        // How to find indices of two numbers that add up to the target
        public int[] TwoSum(int[] nums, int target)
        {
            // Iteration through an array
            for (int i = 0; i < nums.Length; i++)
            {
                // Determine all pairs with the current number
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // If sum equals the target, return the indices
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            // Throw an exception if no valid solution has found
            throw new ArgumentException("No valid solution exists.");
        }

        public static void Main(string[] args)
        {
            // User inputs
            Console.WriteLine("Enter the array of integers (comma-separated):");
            string input = Console.ReadLine();
            int[] nums = Array.ConvertAll(input.Split(','), int.Parse);

            Console.WriteLine("Enter the target sum:");
            int target = int.Parse(Console.ReadLine());

            try
            {
                // Find the indices of the two numbers
                int[] result = new SolutionTwoSum().TwoSum(nums, target);
                Console.WriteLine($"Indices of the two numbers: [{result[0]}, {result[1]}]");
            }
            catch (ArgumentException ex)
            {
                // No valid solution exists handle case
                Console.WriteLine(ex.Message);
            }
        }
    }
}