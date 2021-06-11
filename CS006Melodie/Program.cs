using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS006Melodie
{
    class Program
    {
        const float FC = 261.63f;
        const float FD = 293.66f;
        const float FE = 329.63f;
        const float FF = 349.23f;
        const float FG = 392f;
        const float FA = 440f;
        const float FB = 492.88f;
        const float FC2 = 523.25f;
        const int NotaOsminova = 50;
        const int NotaCtvrtova = NotaOsminova * 2;
        const int NotaPulova = NotaOsminova * 4;
        const int NotaCela = NotaOsminova * 8;

        static void Main(string[] args)
        {
            Console.Beep((int)FC, 100);
            Console.Beep((int)FD, 100);
            Console.Beep((int)FE, 100);
            Console.Beep((int)FF, 100);
            Console.Beep((int)FG, 100);
            Console.Beep((int)FA, 100);
            Console.Beep((int)FB, 100);
            Console.Beep((int)FC2, 100);
            Console.Beep((int)FB, 100);
            Console.Beep((int)FA, 100);
            Console.Beep((int)FG, 100);
            Console.Beep((int)FF, 100);
            Console.Beep((int)FE, 100);
            Console.Beep((int)FD, 100);
            Console.Beep((int)FC, 100);
        }
    }
}
