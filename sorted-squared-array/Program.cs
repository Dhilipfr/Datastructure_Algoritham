using sorted_squared_array;
using System.ComponentModel;
using System;

//Details:
//Write a function that takes in a non-empty array of integers that are sorted
//  in ascending order and returns a new array of the same length with the squares
//  of the original integers also sorted in ascending order.
//Test1
var test1Input = new int[] { 1, 2, 3, 5, 6, 8, 9 };
var test1Output = new int[] { 1, 4, 9, 25, 36, 64, 81 };
var test1Result = Solutions.Solution1(test1Input);
Console.WriteLine(Enumerable.SequenceEqual(test1Result, test1Output));

var test2Input = new int[] { 1, 2, 3, 5, 6, 8, 9 };
var test2Output = new int[] { 1, 4, 9, 25, 36, 64, 81 };
var test2Result = Solutions.Solution2(test2Input);
Console.WriteLine(Enumerable.SequenceEqual(test2Result, test2Output));