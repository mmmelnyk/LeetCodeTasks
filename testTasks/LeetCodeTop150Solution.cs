using System;
namespace testTasks
{
	public class LeetCodeTop150Solution
	{
		public LeetCodeTop150Solution()
		{
		}

        ///189. Rotate Array
        public void Rotate(int[] nums, int k)
        {
            var numsCopy = (int[])nums.Clone();
            for (var j = 0; j < nums.Length; j++)
            {
                if (j + k < nums.Length)
                {
                    nums[j + k] = numsCopy[j];
                }
                else
                {
                    nums[(j + k) % nums.Length] = numsCopy[j];
                }
            }
        }
    }
}

