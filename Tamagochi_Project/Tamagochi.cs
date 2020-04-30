using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tamagochi_Project
{
    class Tamagochi
    {
        public TamagochDelegat playEvent;
        public TamagochDelegat eatEvent;
        public TamagochDelegat walkEvent;
        public TamagochDelegat illEvent;
        public TamagochDelegat diedEvent;
       private int n = 0;



        public void Play()
        {
            Console.WriteLine("Lets play");

            if (playEvent != null)
            { playEvent(); }
           // Thread.Sleep(500);
        }

        public void Eat()
        {
            Console.WriteLine("I want eat");
            if (eatEvent != null)
                eatEvent();
               // Thread.Sleep(500);
        }

        public void Walk()
        {
            Console.WriteLine("Let's walk");

            if (walkEvent != null)
                walkEvent();
                //Thread.Sleep(500);

        }
        public void Died()
        {
            if (diedEvent != null)
            {
                diedEvent();
                
            }
           
        }
        public void Ill()
        {
            Console.WriteLine("I'm ill");

            if (illEvent != null)
           
                illEvent();
           
                //Thread.Sleep(500);

        }
        public int WantRand()
        {
            int want;
            Random rnd = new Random();
            
            want = rnd.Next(1, 4);
            if (n == want)
                WantRand();
            n = want;
            return want;



            
        }
        
    }
}
