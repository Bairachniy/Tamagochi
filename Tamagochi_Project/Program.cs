using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tamagochi_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Play 1");
            Console.WriteLine("Eat 2");
            Console.WriteLine("Walk 3");
            Console.WriteLine("Treat 4 \n \n");

            Tamagochi gogi = new Tamagochi();
            Game game = new Game("Dima");


            gogi.eatEvent += game.Eat;
            gogi.illEvent += game.Ill;
            gogi.walkEvent += game.Walk;
            gogi.playEvent += game.Play;
            gogi.diedEvent += game.Died;
            SMSEventArgs sms1 = new SMSEventArgs();


            while(game.count<3)
            {
                
                switch (gogi.WantRand())
                {
                    case 1:gogi.Play(); Thread.Sleep(1000); break;
                    case 2: gogi.Eat(); Thread.Sleep(1000); break;
                    case 3:gogi.Walk(); Thread.Sleep(1000); break;

                }
                if (game.count == 3)
                    gogi.Ill(); Thread.Sleep(3000);
                if (game.count >= 3)
                    gogi.Died();
            }

        }

    }
}
