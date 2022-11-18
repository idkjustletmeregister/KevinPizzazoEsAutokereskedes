using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinPizzazoes_Autokereskedes
{
    public class Desszert : EtelBase
    {
        public Desszert(string nev, double price) : base(nev, price)
        {
            
        }
    }
    
    public class Tiramisu : Desszert
    {
        public Tiramisu(string nev, double price) : base(nev,  price)
        {
            AddIngredient("Tiramisu", 1);
            _elkeszitesiido = 2;
        }
    }
    
    public class Somloi : Desszert
    {
        public Somloi(string nev, double price) : base(nev, price)
        {
            AddIngredient("Somloi", 1);
            _elkeszitesiido = 2;
        }
    }

    public class Fagyi : Desszert
    {
        public Fagyi(string nev,  double price) : base(nev,price)
        {
            AddIngredient("Fagyi", 2);
            _elkeszitesiido = 1;
        }
    }
}
