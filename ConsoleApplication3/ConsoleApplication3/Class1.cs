using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
   public class Jenkia
    {
        public int b;
        public string name, family, adress;
        public void writetoconsole(string name, string family, string adress, int b)
        {
            Console.WriteLine(" имя: {0}\n фамилия: {1}\n адресс: {2} \n\n", name, family, adress);
        }


    }
}
