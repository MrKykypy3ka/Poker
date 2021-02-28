using System;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck one= new Deck("","");
            int n=0;
            do
            {
                Console.WriteLine("Сколько игроков за столом? (Игроков должно быть больше 1 и меньше 6)");
                try{
                n = Convert.ToInt32(Console.ReadLine());}
                catch(FormatException){
                    Console.WriteLine("Нужно число");}        
            }
            while (n < 2 || n > 6);
            one.shuffle();
            one.Distribution(n);
            Console.ReadKey(true);
        }
    }
}
