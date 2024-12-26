using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Тест");
        Console.WriteLine();
        Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>
{
{ "Вопрос 1: Какой язык программирования мы изучаем? ", "Java\nPython\nC++\nC#\n"},
{ "Вопрос 2: Переменные пишутся с ", "заглавной буквы\nс двух заглавных букв\nс буквы в любом регистре\nстрочной буквы\n" },
{ "Вопрос 3: В конце каждой инструкции в C# ставится ", "точка\nзапятая\nпробел\nточка с запятой\n" },
{ "Вопрос 4: Однострочный комментарий размещается на одной строке после символа ", "звёздочка\nрешётка\nквадратные скобки\nдвойной слэш\n" },
{ "Вопрос 5: Именнованная область памяти, в которой хранится значение определенного типа- это...", "программа\nцикл\nсимвол\nпеременная\n" },
{ "Вопрос 6: ... должна быть обязательно инициализирована при определении,\n и после определения значение ... не может быть изменено\r\n\r\n", "переменная(ой)\nфунция(и)\nпрограмма(ы)\nконстанта(ы)\n" },
{ "Вопрос 7: Тип данных, хранит значение true или false (логические литералы)", "string\nchar\nint\nbool\n" },
{ "Вопрос 8: Тип данных, хранит целое число от 0 до 255 и занимает 1 байт", "bool\nstring\nchar\nbyte\n" },
{ "Вопрос 9: Тип данных, хранит целое число от -2147483648 до 2147483647 и занимает 4 байта", "ushort\nlong\nbyte\nint\n" },
{ "Вопрос 10: Тип данных, хранит одиночный символ в кодировке Unicode и занимает 2 байта", "string\nint\nbool\nchar\n" },
};

        
        int correctAnswersCount = 0;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        
        foreach (var questionAndAnswer in questionsAndAnswers)
        {
            Console.WriteLine(questionAndAnswer.Key);

            
            string[] questionData = questionAndAnswer.Value.Split('\n');
            
            for (int i = 0; i < questionData.Length - 1; i++)
            {
                Console.WriteLine(questionData[i]);
            }

            
            Console.Write("Введите правильный ответ: ");
            string userAnswer = Console.ReadLine();
            
            if (userAnswer == questionData[questionData.Length - 2])
            {
                correctAnswersCount++;
            }

            Console.WriteLine();
        }

        stopwatch.Stop();

        Console.WriteLine($"Количество правильных ответов: {correctAnswersCount}");
        if (correctAnswersCount > 5)
        {
            Console.WriteLine("Результат теста: тест пройден ");
        }
        else
            Console.WriteLine("Результат теста: тест не пройден ");

        Console.WriteLine($"Время прохождения теста: {stopwatch.Elapsed}");
    }
}