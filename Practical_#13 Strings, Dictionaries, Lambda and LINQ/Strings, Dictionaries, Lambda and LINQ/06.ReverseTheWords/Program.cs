char[] separators = new char[] { '.', ',', ';', ':', '=', ')', '(', '&', '[', ']', '\'', '"', '\\', '/', '?', '!', ' ' };
string text = Console.ReadLine();
string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
char[] nonSeparators = String.Join("", words).ToCharArray();
string[] punctuation = text.Split(nonSeparators, StringSplitOptions.RemoveEmptyEntries);
words = words.Reverse().ToArray();
for (int i = 0; i < words.Length; i++)
{
    Console.Write(words[i] + punctuation[i]);
}