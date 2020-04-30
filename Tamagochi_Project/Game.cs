using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_Project
{
    class Game
    {
        public string Name { get; set; }
        public string read;
        public  int count;
        int r;
        //Exception ex = new Exception();

        public Game(string Name)
        {
            this.Name = Name;
        }
        public Game() { }
        public void Play()
        {

            read = Console.ReadLine();
            if (Int32.TryParse(read, out r))
            {

                if (r == 1)
                {
                    Console.WriteLine($"{Name} It was fanny.\n");
                }
                else
                {
                    Console.WriteLine($"{Name} I'm sad, you don't play with me.\n");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("Your anwer must be only 1,2,3 or 4");
                count++;
            }
            
           
        }
        public void Eat()
        {

        read = Console.ReadLine();
        if (Int32.TryParse(read, out r))
        {

            if (r == 2)
            {
                Console.WriteLine($"{Name} very tasty\n"); 
            }
            else { Console.WriteLine($"{Name} I'm sad, you give me nothing.\n"); count++; }
        }
            else
            {
                Console.WriteLine("Your anwer must be only 1,2,3 or 4");
                count++;
            }

        }
        public void Walk()
        {
            read = Console.ReadLine();
            if (Int32.TryParse(read, out r))
            {
                if (r == 3)
            {
                Console.WriteLine($"{Name} Good walk)).\n"); 
            }
            else { Console.WriteLine($"{Name} Are you forgot about me???.\n"); count++; }
            }
            else
            {
                Console.WriteLine("Your anwer must be only 1,2,3 or 4");
                count++;
            }

        }
        public void Ill()
        {
            read = Console.ReadLine();
            if (Int32.TryParse(read, out r))
                {
                
                if (r == 4)
                {
                    Console.WriteLine($"{Name} Good work)).\n");
                    count--;
                }
            }
            else
            {
                Console.WriteLine("Your anwer must be only 1,2,3 or 4");
                count++;
            }


        }

        public void Died()
        {
            Console.WriteLine($"{Name}, Tamagochi died !!!");
        }
    }
}
