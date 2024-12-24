using System;

class TextGeneratorTask
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите фразу, содержащую в конце одно из данных слов: ");
        Console.WriteLine("hello\nso\nlove\nI");
        Console.WriteLine("");
        string phraseBeginning = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Введите сколько слов должны дополнять вашу фразу (1/2/3): ");
        int wordsCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Ваша дополненная фраза: ");

        string[] phraseBeginninStore = new string[4] { "hello", "so", "love", "I" };
        string[] endings1 = new string[3] { "friend", "dear friend", "my dear friend" };
        string[] endings2 = new string[3] { "cozy", "cozy day ", "cozy day today" };
        string[] endings3 = new string[3] { "cats", "cats, dogs", "cats and dogs" };
        string[] endings4 = new string[3] { "enjoy", "enjoy everything", "enjoy everything today" };

        string[][] endings = new string[][] { endings1, endings2, endings3, endings4 };

        string result = GeneratePhrase(phraseBeginning, phraseBeginninStore, endings, wordsCount);

        Console.WriteLine(result);


        static string GeneratePhrase(string phraseBeginning, string[] phraseBeginninStore, string[][] endings, int wordsCount)
        {
            string result = phraseBeginning;
            string[] words = phraseBeginning.Split(' ');


            while (true)
            {

                foreach (string str in phraseBeginninStore)
                {

                    string key = string.Join(" ", words[^1..^0]);
                    if (phraseBeginninStore.Contains(key))
                    {
                        int countOfBeginning = Array.FindIndex(phraseBeginninStore, word => word == key);

                        string nextWord = endings[countOfBeginning][wordsCount - 1];
                        result += " " + nextWord;
                        words = (nextWord + " ").Split(' ');
                    }
                    else
                    {
                        break;
                    }
                    return result;
                }
            }
        }
    }
}













