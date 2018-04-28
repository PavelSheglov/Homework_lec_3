using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = InputText();
            var dictionary = CreateDictionary(text);
            ShowDictionary(dictionary);
        }

        static string InputText()
        {
            string input=String.Empty;
            while (input==String.Empty)
            {
                Console.WriteLine("Введите непустую строку:");
                input = Console.ReadLine();
            }
            return input;
        }

        static int GetCountOfRepetitions(string text, char symbol)
        {
            int count = 0;
            if(!String.IsNullOrEmpty(text) && symbol!='\0')
            {
                count = text.ToCharArray().Count(s => s == symbol);
            }
            return count;
        }

        static Dictionary<char, int> CreateDictionary(string text)
        {
            var dictionary = new Dictionary<char, int>(200);
            if(!String.IsNullOrEmpty(text))
            {
                char[] symbols = text.ToCharArray().Distinct().ToArray();
                foreach(var sym in symbols)
                {
                    dictionary.Add(sym, GetCountOfRepetitions(text, sym));
                }
            }
            return dictionary;
        }

        static void ShowDictionary(Dictionary<char, int> dictionary)
        {
            if (dictionary.Count > 0)
            {
                Console.WriteLine("Словарь содержит следующие записи:");
                foreach (var dic in dictionary)
                    Console.WriteLine("Символ-ключ = '{0}', значение-количество = {1}", dic.Key, dic.Value);
            }
            else
                Console.WriteLine("Словарь пуст!!!");
        }
    }
}
