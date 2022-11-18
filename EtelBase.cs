using System;
using System.Collections.Generic;

namespace KevinPizzazoes_Autokereskedes
{
    public abstract class EtelBase
    {
        private string _nev;
        private double _price;
        protected double _elkeszitesiido;       // ez igy jo? mert lejjebb a getternel a konstruktorban nem tudok neki milyen erteket adni
        private Dictionary<string, int> _hozzavalok;

        public string Nev { get { return _nev; } }
        public double Price { get { return _price; } }
        public double ElkeszitesiIdo { get { return _elkeszitesiido; } }
        public Dictionary<string, int> Hozzavalok { get { return _hozzavalok; } }


        public EtelBase(string nev, double price)
        {
            _nev = nev;
            _price = price;
            _hozzavalok = new Dictionary<string, int>();
        }

        public void AddIngredient(string hozzavalo, int mennyiseg)
        {
            _hozzavalok.Add(hozzavalo, mennyiseg);
        }

        public void ShowIngredients()
        {
            Console.WriteLine($"{Nev} feltetei:");

            foreach (KeyValuePair<string, int> kvp in _hozzavalok)
            {
                Console.WriteLine($"\t- {kvp.Key}");
            }
        }

        public abstract void Cook();
    }
}