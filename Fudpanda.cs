//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace KevinPizzazoes_Autokereskedes
//{
//    public class Fudpanda
//    {
//        // Is-A, Has-A
//        // EtelBase -> Pizza          Pizza is a EtelBase
//        // Has-A     Fudpanda Has-A Konyh
//        private string _meal;
//        private int _ctr;
//        private Konyha _konyha;
//        public Fudpanda()
//        {
//            _konyha = new Konyha();
//            _ctr = 1;
//        }

//       public void Elszamolas()
//       { 
//            _konyha.Cook();

//            foreach (var rendelesek in _rendeles)
//            {
//                double _ar = 0;
//                double _ido = 0;

//                Console.WriteLine($"/////  {rendelesek.Key}. rendeles  /////");
//                foreach (var kaja in rendelesek.Value)
//                {
//                    Console.WriteLine($"{kaja.Nev}\t{kaja.Price}");
//                    _ido += kaja.ElkeszitesiIdo;
//                    _ar += kaja.Price;
//                }

//                Console.WriteLine($"________________________");
//                Console.WriteLine($"Elkeszitesi ido: {_ido} perc");
//                Console.WriteLine($"Vegosszeg:\t {_ar} Ft\n\n");
//            }


//            Console.WriteLine("\nKöszönjük rendelésed! Várunk vissza egy újabb szerencsés üzletre, taven baktale!");
//            Console.WriteLine("\n\tAll rights reserved (C) 2022");
//            Console.WriteLine("\tNAV-os kutyák ne keresenek\n\n\n");
//       }

//    public void RendelesFelvetel()
//        {
//            // Itt vesszuk fel a rendeleseket.

//            // Amikor vegzunk a rendeles felvetellel elkeszitjuk az elszamolast
//            Elszamolas();
//            // majd leadjuk a konyhanak a rendelst
//            _konyha.Cook(rendeles);
//        }

//        public void AccessKonyha()
//        {
//            _konyha.Cook();
//        }

//        //public void Beolvas()
//        //{
//        //    Console.WriteLine("\nSzaszto baktale! Üdv a Kevin Pizzazo es Autokereskedesben!\n");
//        //    Console.WriteLine("A billentyűzet segicségével ad meg, mit kérsz az étlapról, majd nyomj 'Enter'-t");
//        //    Console.WriteLine("(Ha befejezted a rendelést ne írj be semmit, csak nyomj egy 'Enter'-t)");

//        //    while (!Console.KeyAvailable)
//        //    {
//        //        _meal = Console.ReadLine();

//        //        if (_meal.Length > 0)
//        //        {
//        //            bool found = false;
//        //            foreach (var item in menu.MN)
//        //            {
//        //                if (_meal == item.Value.Nev)
//        //                {
//        //                    konyha.AddOrder(_ctr, item.Value, keszlet);
//        //                    found = true;
//        //                }
//        //            }
//        //            if (found == false)
//        //            {
//        //                Console.WriteLine("Ilyen étel nem szerepel az étlapon, kérlek próbáld újra!");
//        //            }
//        //        }
//        //        else
//        //        {
//        //            konyha.Cook();
//        //            Console.WriteLine("\nKöszönjük rendelésed! Várunk vissza egy újabb szerencsés üzletre, taven baktale!");
//        //            Console.WriteLine("\n\tAll rights reserved (C) 2022");
//        //            Console.WriteLine("\tNAV-os kutyák ne keresenek\n\n\n");
//        //            break;
//        //        }
//        //    }
//        //}
//    }
//}
