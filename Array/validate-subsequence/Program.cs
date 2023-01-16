// Input = [5, 1, 22, 25, 6, -1, 8, 10]
// Target = [1, 6, -1, 10]
using validate_subsequence;

//Test1
var test1Input = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
var test1Target = new List<int> { 5, 1, 22, 22, 25, 6, -1, 8, 10 };
var test1Output = true;
var testResult1 = Solutions.IsValidSubsequence(test1Input, test1Target);
Console.WriteLine(testResult1 == test1Output);