using System;
using System.Globalization;

namespace notas_e_moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double _100, _100r, _50, _50r, _20, _20r, _10, _10r, _5, _5r, _2, _2r, m1, m1r, m50, m50r, m25, m25r, m10, m10r, m5, valor;
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            _100 = (int)valor / 100;
            _100r = valor % 100;

            _50 = (int)_100r / 50;
            _50r = _100r % 50;

            _20 = (int)_50r / 20;
            _20r = _50r % 20;

            _10 = (int)_20r / 10;
            _10r = _20r % 10;

            _5 =(int)_10r / 5;
            _5r = _10r % 5;

            _2 = (int)_5r / 2;
            _2r = _5r % 2;

            m1 = (int)_2r / 1;
            m1r = _2r % 1;

            m50 = (int)m1r / 0.50;
            m50r = (double)m1r % 0.50;

            m25 = (int)m50r / 0.25;
            m25r = (double)m50r % 0.25;

            m10 = (int)m25r / 0.10;
            m10r = (double)m25r % 0.10;

            m5 = (int)m10r % 5;
           

            Console.WriteLine("NOTAS");
            Console.WriteLine(_100 + "nota(s) de R$ 100,00");
            Console.WriteLine(_50 + "nota(s) de R$ 50,00");
            Console.WriteLine(_20 + "nota(s) de R$ 20,00");
            Console.WriteLine(_10 + "nota(s) de R$ 10,00");
            Console.WriteLine(_5 + "nota(s) de R$ 5,00");
            Console.WriteLine(_2 + "nota(s) de R$ 2,00");
            Console.WriteLine("MOEDAS");
            Console.WriteLine(m1 + "moeda(s) de R$ 1.00");
            Console.WriteLine(m50 + "moeda(s) de R$ 0.50");
            Console.WriteLine(m25 + "moeda(s) de R$ 0.25");
            Console.WriteLine(m10 + "moeda(s) de R$ 0.10");
            Console.WriteLine(m5 + "moeda(s) de R$ 0.05");

            Console.ReadLine();

        }
    }
}
