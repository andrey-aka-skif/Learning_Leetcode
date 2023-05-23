using Solutions;

var nums = new int[] { 3, 2, 4 };
var target = 6;

var solution = new Solution();
var result = solution.TwoSum(nums, target);

if (result.Length != 0)
    Console.WriteLine($"[{result[0]},{result[1]}]");
else
    Console.WriteLine($"[Решений нет]");

Console.ReadLine();
