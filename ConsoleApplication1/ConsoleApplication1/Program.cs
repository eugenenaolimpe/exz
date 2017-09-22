using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Domino
    {
        public Domino(int one, int two)
        {
            num1 = one;
            num2 = two;
        }

        public int num1;
        public int num2;

        public override string ToString()
        {
            return string.Format("one: {0} | two: {1}", num1, num2);
        }
    }

    class User
    {
        public List<Domino> collection = new List<Domino>() { new Domino(12, 23), new Domino(11, 14) };
    }

    class Program
    {
        static void Main(string[] args)
        {
            User userr = new User();
            foreach (var item in userr.collection)
            {
                Console.WriteLine(item);
            }
        }
        /*создать класс Domino, содержащий два целых числа. Создать класс User, который содержит коллекцию из 2-х Domino. 
        Создать объект User и вывестиего набор домино*/
        
        

    }
}
