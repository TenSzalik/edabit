//Create a function that takes an array and a string as arguments and returns the index of the string.
using NUnit.Framework;
using System;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(new string[] { "abc", "ghj", "banana", "grape" }, "grape", Result = 3)]
    [TestCase(new string[] { "a", "b", "c", "d", "e", "f" }, "f", Result = 5)]
    [TestCase(new string[] { "hi", "edabit.com", "testcase", "validstring" }, "edabit.com", Result = 1)]
    public static int FindIndex(string[] arr, string str)
    {
        Console.WriteLine($"Input: [{string.Join(", ", arr)}], {str}");
        return Program.FindIndex(arr, str);
    }
}
public class Program
{
    public static int FindIndex(string[] arr, string str)
    {

    }
}
