using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    class Cat
    {
        private string name;
        private double weight;
        public string Name 
        {
            get { return name; }
            set
            {
                bool OnlyLetters = true;
                
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                } 
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value>0)
                {
                    weight = value;
                } 
                else
                {
                    Console.WriteLine($"У кота не может быть вес {value}");
                }
            }
        }
        public Cat (string CatName, double CatWeight)
        {
            Name = CatName;
            Weight = CatWeight;
        }
        public void Meow ()
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
        }
        public void Ves ()
        {
            Console.WriteLine($"{name} весит {weight} кг");
        }
        public void SetCatName (string CatName)
        {

            bool OnlyLetters = true;

            foreach (var ch in CatName)
            {
                if (!char.IsLetter(ch))
                {
                    OnlyLetters = false;
                }
            }

            if (OnlyLetters == true)
                name = CatName;
            else
                Console.WriteLine($"{CatName} - неправильное имя!!!");
        }
    }
}
