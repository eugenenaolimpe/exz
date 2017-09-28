using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        { Jenkia my = new Jenkia();

                my.name = "jenia";
                my.family = "lol";
                my.adress = "keke";
                my.b = 19;

            Jenkia me = new Jenkia();

                 me.name = "Evgesha";
                 me.family = "keker";
                 me.adress = "luler";
                 me.b = 2;

            my.writetoconsole(me.name, me.family, me.adress, me.b);
            my.writetoconsole(my.name, my.family, my.adress, my.b);
            Console.ReadKey();


        }
    }
}
