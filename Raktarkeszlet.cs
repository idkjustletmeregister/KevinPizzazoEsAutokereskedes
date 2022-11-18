using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinPizzazoes_Autokereskedes
{
    public class Raktarkeszlet
    {
        Dictionary<string, int> _raktar;

        public Raktarkeszlet()
        {
            _raktar = new Dictionary<string, int>();
        }

        public void AddIngredient(string hozzavalo, int mennyiseg)
        {
            if(_raktar.ContainsKey(hozzavalo))
            {
                _raktar[hozzavalo] += mennyiseg;
            }
            else
            {
                _raktar.Add(hozzavalo, mennyiseg);
            }
        }

        public void PrintItemsInStock()
        {
            Console.WriteLine("Aktualis raktarkeszlet:");
            foreach (KeyValuePair<string, int> kvp in _raktar)
            {
                Console.WriteLine($"\t- {kvp.Key}: {kvp.Value}");
            }
        }
        

        public bool Vanelegkeszlet(EtelBase rendeles)
        {
            foreach (var hozzavalo in rendeles.Hozzavalok)
            {
                if (_raktar[hozzavalo.Key] < hozzavalo.Value)
                {
                    return false;
                }
            }
            return true;
        }

        public void Elhasznal(EtelBase rendeles)      // itt lehetne bool a visszateresi ertek, amit megkap a rendelo
        {
            foreach (var hozzavalo in rendeles.Hozzavalok)
            {
                _raktar[hozzavalo.Key] -= hozzavalo.Value;  
            }
        }

        public void FeltoltTMP()
        {
            List<string> raktar = new List<string>{"paradicsom","sonka","gomba","kukorica","trappista","mozzarella","parmezan", 
                "gorgonzola","szalami","teszta","pulykahus","passata","liszt","tej","vaj","trappista"};
            List<string> fagyi = new List<string>{"tojas","Fagyi","Tiramisu","Somloi"};

            foreach (string ingr in raktar)
            {
                AddIngredient(ingr, 1000);
            }
            
            foreach (string ingr in fagyi)
            {
                AddIngredient(ingr, 10);
            }
            Console.WriteLine("Készletek feltöltve!");
        }
    }
}
