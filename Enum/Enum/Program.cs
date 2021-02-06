using System;
using Enum.Enum;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //volanie enumu
            Console.WriteLine(TypVozidla.LietajuceAuto);

            //z ID precastovat na enum

            var idVozidla = 1;
            var typVozidla = (TypVozidla)idVozidla;

            Console.WriteLine(typVozidla);

        }
    }
}
