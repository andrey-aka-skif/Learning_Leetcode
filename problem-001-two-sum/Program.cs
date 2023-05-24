using problem_001_two_sum;

var nums = new int[] { 3, 3 };
var target = 6;

var solution = new Solution();
var result = solution.TwoSum(nums, target);

if (result != null)
    Console.WriteLine($"[{result[0]},{result[1]}]");
else
    Console.WriteLine($"[Решений нет]");

Console.ReadLine();
