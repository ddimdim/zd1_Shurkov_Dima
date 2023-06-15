using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    class Program
    {
        static void Main (string[] args)
        {
            Cat murzik = new Cat("Мурзик", -1.4);
            Cat barsik = new Cat("Барсег", 3.5);
            murzik.Weight = 4.7;
            murzik.Meow();
            barsik.Meow();
            barsik.Name = "Барсик";
            barsik.Meow();
            barsik.Ves();
            murzik.Ves();
            barsik.Name = "1234";
            barsik.Meow();
            Console.ReadKey();
        }
    }
}
