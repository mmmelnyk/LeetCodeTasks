// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//var nums = new int[] { 3, 2, 2, 3 };
//var val = 3;

//int valCounter = nums.Length;
//nums = nums.Where(c => c != val).ToArray();
//valCounter -= nums.Length;
//Console.WriteLine(valCounter);
//Array.ForEach(nums, Console.WriteLine);
var k = 3;
var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
for (var j = 0; j < nums.Length; j++)
{
    if (j + k < nums.Length)
    {
        nums[j + k] = nums[j];
    }
    else
    {
        nums[nums.Length - (j + k + 1)] = nums[j];
    }

}

Array.ForEach(nums, Console.WriteLine);