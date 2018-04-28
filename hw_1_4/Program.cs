using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = new Telephone();
            var number2 = new Telephone(1234567);
            var number3 = new Telephone(222, 9876543);
            var number4 = new Telephone(0, 7777777);
            var number5 = new Telephone(0, 0);
            var number6 = new Telephone(33, 2578);
            var number7 = new Telephone(12578);
            Console.WriteLine("Номер 1: {0}", number1.NumberInString);
            Console.WriteLine("Номер 2: {0}", number2.NumberInString);
            Console.WriteLine("Номер 3: {0}", number3.NumberInString);
            Console.WriteLine("Номер 4: {0}", number4.NumberInString);
            Console.WriteLine("Номер 5: {0}", number5.NumberInString);
            Console.WriteLine("Номер 6: {0}", number6.NumberInString);
            Console.WriteLine("Номер 7: {0}", number7.NumberInString);
        }
    }

    public class Telephone
    {
        private uint _cityCode;
        private uint _telephoneNumber;

        public Telephone()
        {
            _cityCode = 0;
            _telephoneNumber = 0;
        }

        public Telephone(uint number) : this(0, number)
        {

        }

        public Telephone(uint code, uint number)
        {
            _cityCode = code;
            _telephoneNumber = number;
        }

        public string NumberInString => _cityCode != 0 ?
                                        string.Format("({0:d3}) {1:d6}", _cityCode, _telephoneNumber) :
                                        string.Format("{0}", _telephoneNumber);
    }
}
