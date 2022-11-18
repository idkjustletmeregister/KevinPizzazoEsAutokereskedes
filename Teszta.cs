using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinPizzazoes_Autokereskedes
{
    public class Teszta : EtelBase
    {
        public Teszta(string nev, double price) : base(nev, price)
        {
            
        }
    }

    public class Carbonara : Teszta
    {
        public Carbonara(string nev, double price) : base(nev, price)
        {
            AddIngredient("teszta",330);
            AddIngredient("sonka",200);
            AddIngredient("tojas",5);
            AddIngredient("parmezan",15);
            _elkeszitesiido = 45;
        }
    }

    public class Bolognai : Teszta
    {
        public Bolognai(string nev, double price) : base(nev,price)
        {
            AddIngredient("teszta",150);
            AddIngredient("pulykahus",150);
            AddIngredient("passata",200);
            _elkeszitesiido = 35;
        }
    }
   
    public class Lasagne : Teszta
    {
        public Lasagne(string nev,double price) : base(nev,price)
        {
            AddIngredient("teszta",350);
            AddIngredient("pulykahus",250);
            AddIngredient("passata",200);
            AddIngredient("liszt",125);
            AddIngredient("tej",450);
            AddIngredient("vaj",120);
            AddIngredient("trappista",100);
            _elkeszitesiido = 60;
        }
    }
}
