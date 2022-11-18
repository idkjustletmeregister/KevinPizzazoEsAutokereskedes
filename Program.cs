using System;
using System.Collections.Generic;

namespace KevinPizzazoes_Autokereskedes
{
    class Program
    {
        static void Main(string[] args)
        {
            // EZEKET LETRE LEHETNE HOZNI EGY KULON .CS FILEBAN?
            Menu menu = new Menu();
            Raktarkeszlet keszlet = new Raktarkeszlet();
            Konyha konyha = new Konyha();

            Pizza songoku = new SonGoKu("SonGoKu", 1990);
            Pizza negysajtos = new Negysajtos("Negysajtos", 2090);
            Pizza salami = new Salami("Szalamis", 1890);

            Teszta lasagne = new Lasagne("Lasagne", 1890);
            Teszta bolognai = new Bolognai("Bolognai", 1690);
            Teszta carbonara = new Carbonara("Carbonara", 2190);

            Desszert tiramisu = new Tiramisu("Tiramisu", 490);
            Desszert fagyi = new Fagyi("Fagyi", 450);
            Desszert somloi = new Somloi("Somloi", 490);

            menu.AddDish(3,songoku);
            menu.AddDish(2,salami);
            menu.AddDish(1,negysajtos);
            menu.AddDish(11,tiramisu);
            menu.AddDish(12,fagyi);
            menu.AddDish(13,somloi);
            menu.AddDish(6,carbonara);
            menu.AddDish(9,bolognai);
            menu.AddDish(7,lasagne);

            menu.ShowDish();

            //songoku.ShowIngredients();
            //somloi.ShowIngredients();
            //carbonara.ShowIngredients();

            //Console.WriteLine(carbonara.ElkeszitesiIdo);
            keszlet.FeltoltTMP();

            //konyha.AddOrder(1,carbonara, keszlet);
            //konyha.AddOrder(1,carbonara, keszlet);
            //konyha.AddOrder(2,carbonara, keszlet);
            //konyha.AddOrder(3,tiramisu, keszlet);
            //konyha.AddOrder(1,fagyi, keszlet);
            //konyha.AddOrder(4,fagyi, keszlet);
            //konyha.AddOrder(4,lasagne, keszlet);
            //konyha.AddOrder(4,negysajtos, keszlet);
            //Console.WriteLine("\n");
            //konyha.ShowTime();
            //konyha.Cook();

            //Fudpanda fp = new Fudpanda();

            string _meal;
            int rendelesszam = 0;
            Console.WriteLine("\nÜdvözöljük a Kevin Pizzazo es Autokereskedesben!\n");
            Console.WriteLine("A billentyűzet segítségével adja meg, mit kér az étlapról, majd nyomjon egy 'Enter'-t");
            Console.WriteLine("(Ha befejezte a rendelést ne írjon be semmit, csak nyomjon egy 'Enter'-t)");

            while (!Console.KeyAvailable)
            {
                _meal = Console.ReadLine();

                if (_meal.Length > 0)
                {
                    bool found = false;
                    foreach (var item in menu.Dishes)
                    {
                        if (_meal == item.Value.Nev)
                        {
                            if(rendelesszam < 3)
                            {
                                konyha.AddOrder(item.Value, keszlet);
                                found = true;
                            }
                            else
                            {
                                Console.WriteLine("Elérte a maximálisan leadható rendelések számát!");
                                //fp.Elszamolas(konyha);
                                konyha.Cook();
                            }
                            rendelesszam++;
                        }
                    }
                    if(!found)
                    {
                        Console.WriteLine("Ilyen étel nem szerepel az étlapon, kérem próbálja újra!");
                    }
                }
                else
                {
                    //fp.Elszamolas(konyha);
                    konyha.Cook();
                    Console.WriteLine("\nKöszönjük rendelését!");
                    Console.WriteLine("\n\tAll rights reserved (C) 2022");
                    break;

                }
            }
        }
        //enum EnumType
    }
}