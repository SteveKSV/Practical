string word = Console.ReadLine();

string text = Console.ReadLine();

string[] sentences = text.Split('.', '?', '!');

string[] words;
string[] resultSentences;

for (int i = 0; i < sentences.Length; i++)
{
    words = sentences[i].Split(' ');
    for (int j = 0; j < words.Length; j++)
    {
        if (word == words[j])
        {
            resultSentences = words;
            foreach (string s in resultSentences)
                Console.Write(s + " ");
        }
    }
}
