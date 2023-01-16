// Input = [3, 5, -4, 8, 11, 1, -1, 6]
// Target = 10
using two_number_sum;

//Test1
var test1Input = new int[8] { 3, 5, -4, 8, 11, 1, -1, 6 };
var test1Target = 10;
var test1Output = new int[2] { -1, 11 };
var testResult1 = Soution1.TwoNumberSum(test1Input,test1Target);
Console.WriteLine(Enumerable.SequenceEqual(testResult1, test1Output));


//Test2
var test2Input = new int[8] { 3, 5, -4, 8, 11, 1, -1, 6 };
var test2Target = 10;
var test2Output = new int[2] { -1, 11 };
var testResult2 = Soution1.TwoNumberSum1(test2Input, test2Target);
Console.WriteLine(Enumerable.SequenceEqual(testResult2, test2Output));