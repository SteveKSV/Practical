string input = Console.ReadLine();
string input2 = input;
//First variant
char[] c = input.ToCharArray();

Array.Reverse(c);

input = new string(c);
Console.WriteLine("First variant: " + input);

//Second variant 

Console.Write("Second variant: ");
for(int i = input2.Length - 1; i >= 0; i--)
{
    Console.Write(input2[i]);
}