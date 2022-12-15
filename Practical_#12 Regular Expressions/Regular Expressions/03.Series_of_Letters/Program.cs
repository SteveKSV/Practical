using System.Text.RegularExpressions;

string input = Console.ReadLine();

var result = Regex.Replace(input, @"([A-Za-z])\1+", "$1");

Console.WriteLine(result);