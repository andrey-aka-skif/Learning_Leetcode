﻿using Solutions;

var nums = new int[] { 2, 7, 11, 15 };
var target = 17;

var solution = new Solution();
var result = solution.TwoSum(nums, target);

if (result.Length != 0)
    Console.WriteLine($"[{result[0]},{result[1]}]");
else
    Console.WriteLine($"[Решений нет]");

Console.ReadLine();