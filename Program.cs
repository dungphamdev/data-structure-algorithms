using Datastruct.Lib.Searching;

var x = 10;
var arr = new int[] { 1, 2, 3, 4, 5, 6, 10, 40 };


var resultLinear = Searching.LinearSearch(x, arr);
var resultBinary = Searching.BinarySearch(x, arr);

Console.WriteLine($"Linear result: {resultLinear}");
Console.WriteLine($"Binary result: {resultBinary}");