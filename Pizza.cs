using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinPizzazoes_Autokereskedes
{
    public class Pizza : EtelBase
    {
        public Pizza(string nev,double price) : base(nev, price)
        {

        }
    }

    public class SonGoKu : Pizza
    {
        public SonGoKu(string nev, double price) : base(nev, price)
        {
            AddIngredient("paradicsom",200);
            AddIngredient("sonka",150);
            AddIngredient("gomba",80);
            AddIngredient("kukorica",90);
            _elkeszitesiido = 15;
        }
    }   
    
    public class Negysajtos : Pizza
    {
        public Negysajtos(string nev,double price) : base(nev, price)
        {
            AddIngredient("paradicsom",500);
            AddIngredient("trappista",200);
            AddIngredient("mozzarella",200);
            AddIngredient("parmezan",100);
            AddIngredient("gorgonzola",150);
            _elkeszitesiido = 25;
        }
    }

    public class Salami : Pizza
    {
        public Salami(string nev, double price) : base(nev, price)
        {
            AddIngredient("paradicsom",200);
            AddIngredient("szalami",175);
            AddIngredient("mozzarella",100);
            _elkeszitesiido = 20;
        }
    }
}
