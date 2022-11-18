using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinPizzazoes_Autokereskedes
{
    public class Menu
    {
        protected SortedList<int,EtelBase> _dishes;

        public SortedList<int, EtelBase> Dishes { get { return _dishes; } }

        public Menu()
        {
            _dishes = new SortedList<int, EtelBase>();
        }

        public void AddDish(int kod, EtelBase fogas)
        {
            _dishes.Add(kod, fogas);
        }
        
        
        public void ShowDish()
        {
            bool pizzawritten = false;
            bool desszertwritten = false;
            bool tesztawritten = false;

            Console.WriteLine("\n.:.:.:.:.:.: ÉTLAP :.:.:.:.:.:.\n");

            foreach (KeyValuePair<int, EtelBase> kvp in _dishes)
            {
                if (kvp.Value is Pizza)
                {
                    if (pizzawritten == false)
                    {
                        Console.WriteLine("------------Pizzák--------------");
                        pizzawritten = true;
                    }

                    Console.WriteLine($"{kvp.Key}\t{kvp.Value.Nev}\t{kvp.Value.Price}");
                }

                if (kvp.Value is Teszta)
                {
                    if (tesztawritten == false)
                    {
                        Console.WriteLine("-----------Tészták--------------");
                        tesztawritten = true;
                    }
                    Console.WriteLine($"{kvp.Key}\t{kvp.Value.Nev}\t{kvp.Value.Price}");
                }

                if (kvp.Value is Desszert)
                {
                    if (desszertwritten == false)
                    {
                        Console.WriteLine("-----------Desszertek-----------");
                        desszertwritten = true;
                    }
                    Console.WriteLine($"{kvp.Key}\t{kvp.Value.Nev}\t{kvp.Value.Price}");
                }
            }
        }
    }
}
