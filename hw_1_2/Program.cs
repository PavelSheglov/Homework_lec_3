using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = InputSequence();
            ShowSequence(sequence);
            Console.WriteLine("Дублирующиеся значения:");
            ShowSequence(SelectDuplicates(sequence));
        }

        static List<int> InputSequence()
        {
            var sequence = new List<int>(100);
            int temp = 0;
            Console.WriteLine("Введите последовательность целых чисел (завершение ввода -1)");
            while (temp!=-1)
            {
                bool isOk = false;
                while(!isOk)
                {
                    try
                    {
                        Console.Write("Введите очередное число:");
                        temp = Convert.ToInt32(Console.ReadLine());
                        isOk = true;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Ошибка ввода!!! Повторите.");
                    }
                }
                if (temp != -1)
                    sequence.Add(temp);
            }
            return sequence;
        }

        static void ShowSequence(List<int> sequence)
        {
            Console.WriteLine("Последовательность чисел:");
            if (sequence.Count > 0)
            {
                foreach (var s in sequence)
                    Console.Write("{0} ", s.ToString());
                Console.WriteLine();
            }
            else
                Console.WriteLine("Последовательность пуста");
        }

        static List<int> SelectDuplicates(List<int> sequence)
        {
            var duplicates = new List<int>(sequence.Count / 2);
            if (sequence.Count>0)
            {
                var uniques = new HashSet<int>(sequence);
                foreach(var u in uniques)
                {
                    if(sequence.Count(val=>val==u)>1)
                    {
                        duplicates.Add(u);
                    }
                }
            }
            return duplicates;
        }
    }
}
