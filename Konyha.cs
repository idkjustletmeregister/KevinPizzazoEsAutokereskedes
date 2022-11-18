using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinPizzazoes_Autokereskedes
{
    public class Konyha
    {
        protected Dictionary<int,List<EtelBase>> _rendeles;
        private int _rendeles_no;

        Raktarkeszlet keszlet = new Raktarkeszlet();

        public Konyha()
        {
            _rendeles = new Dictionary<int, List<EtelBase>>();
            _rendeles_no = 1;
            keszlet.FeltoltTMP();
        }
        // itt kell szamon tartanom a rendelesek szamat...
        public void AddOrder(EtelBase rendeles, Raktarkeszlet keszlet)
        {
            List<EtelBase> _tmp = new List<EtelBase>();

            if (keszlet.Vanelegkeszlet(rendeles))
            {
                _tmp.Add(rendeles);
                keszlet.Elhasznal(rendeles);

                //ifelse
                if (_rendeles.ContainsKey(_rendeles_no))
                {
                    _rendeles[_rendeles_no].Add(rendeles);
                }
                else
                {
                    _rendeles.Add(_rendeles_no, _tmp);
                    //}
                    //try
                    //{
                    //    _rendeles.Add(_rendeles_no, _tmp);
                    //}
                    //catch (ArgumentException)
                    //{
                    //    _rendeles[_rendeles_no].Add(rendeles);
                    //}
                    // counter, ha elérte a 3-at, akkor már nem dobja fel a consolet
                }
            }
            else
            {
                // itt feldobja újra a consolet
                Console.WriteLine($"léci válasz mázst, me nics elég a {rendeles.Nev}ho'");
            }
        }

        public void ShowTime()
        {
            double _tmp = 0;
            Console.WriteLine("Rendelés\tEtel\t\tElk.idő");
            foreach (var rendeles in _rendeles)
            {
                foreach (var kaja in rendeles.Value)
                {
                    Console.WriteLine($"\t{rendeles.Key}\t{kaja.Nev}\t{kaja.ElkeszitesiIdo}");
                    _tmp += kaja.ElkeszitesiIdo;
                }
            }
            Console.WriteLine($"Összesen {_tmp} perc mulva lesznek keszen.");
        }

        public void Cook()
        {
            foreach (var rendelesek in _rendeles)
            {
                double _ar = 0;
                double _ido = 0;

                Console.WriteLine($"/////  {rendelesek.Key}. rendeles  /////");
                foreach (var kaja in rendelesek.Value)
                {
                    Console.WriteLine($"{kaja.Nev}\t{kaja.Price}");
                    _ido += kaja.ElkeszitesiIdo;
                    _ar += kaja.Price;
                }

                Console.WriteLine($"________________________");
                Console.WriteLine($"Elkeszitesi ido: {_ido} perc");
                Console.WriteLine($"Vegosszeg:\t {_ar} Ft\n\n");
            }
        }

    }
}



//namespace KevinPizzazoes_Autokereskedes
//{
//    public class Konyha
//    {
//        protected List<EtelBase> _rendeles;

//        public Konyha()
//        {
//            _rendeles = new List<EtelBase>();
//        }

//        public void AddOrder(EtelBase rendeles, Raktarkeszlet keszlet)
//        {
//            if(keszlet.KeszletEllenoriz(rendeles))
//            {
//                _rendeles.Add(rendeles);
//                keszlet.Elhasznal(rendeles);
//                // counter, ha elérte a 3-at, akkor már nem dobja fel a consolet
//            }
//            else
//            {
//                // itt feldobja újra a consolet
//                Console.WriteLine($"léci válasz mázst, me nics elég a {rendeles.Nev}ho'");
//            }
//        }

//        public void ShowTime()
//        {
//            double _tmp = 0;
//            Console.WriteLine("Rendelés\tElk.idő");
//            foreach (var rendeles in _rendeles)
//            {
//                Console.WriteLine($"{rendeles.Nev}\t{rendeles.ElkeszitesiIdo}");
//                _tmp += rendeles.ElkeszitesiIdo;
//            }
//            Console.WriteLine($"Összesen {_tmp} perc mulva lesznek keszen.");
//        }

//        public void Cook()
//        {
//            foreach (EtelBase kaja in _rendeles)
//            {
//                Console.WriteLine($"{kaja.Nev}, {kaja.Price}, {kaja.ElkeszitesiIdo}");
//                foreach (var item in kaja.Hozzavalok)
//                {
//                    Console.WriteLine($"{item}");
//                }

//            }
//        }

//    }
//}
