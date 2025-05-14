using Sube1.EmlakciLib;

namespace Sube1.EmlakciApp
{
    internal class Program
        {
            static void Main(string[] args)
            {
                KiralikEv ke = new KiralikEv(500, 600, 3, "Kiralik Ev", 100, 80);
                KiralikEv ke1 = new KiralikEv(800, 900, 2, "Kiralik Ev", 120, 90);
                KiralikEv ke2 = new KiralikEv(10000, 10000, 4, "Kiralik Ev", 200, 100);


                var se = new SatilikEv(400, 3, "Satılık Ev", 110, 60);
                var se1 = new SatilikEv(700, 2, "Satılık Ev", 120, 70);
                Ev se2 = new SatilikEv(900, 4, "Satılık Ev", 140, 80);
                Ev[] evler = { ke, ke1, ke2, se, se1, se2 };

                for (int i = 0; i < evler.Length; i++)
                {
                    Console.WriteLine(evler[i].EvBilgileri());

                    Console.WriteLine("\n------------------\n");
                }
            }
        }
    }


    //var evim3 = new Ev(2, 3, 120);
    //Console.WriteLine(evim3.EvBilgileri());

    //Console.WriteLine($"Bellekteki ev sayısı:{Ev.sayac}");



    //try
    //{
    //    var evim = new Ev();
    //    evim.Alan = 60;
    //    evim.Odasayisi = 3;
    //    evim.Semt = "Gazi";
    //    evim.Katno = 2;
    //    Console.WriteLine(Ev.Sayac);
    //    //evim.Buyukluk = "Küçük Ev";
    //    Console.WriteLine(evim.Buyukluk);
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}



//Ev evim = new Ev();//Ev classından nesne türetildi
//evim: Referans. Nesnelerin bellekteki adresini tutarlar.Belleğin STACK bölgesinde tutulurlar
//Ev: Class. Classlar aynı zamanda bir veri tipidir.
//new: Bellekte nesne oluşturmaya yarayan anahtar sözcük
//Nesne: new anahtar sözcüğü ile HEAP bölgesinde oluşturulurlar.
//Erişim Belirleyiciler(Access Modifiers)
//private: Sadece class içinden erişilebilir üyelerdir
//public: Class içinde tanımlanan üyeye her yerden erişim imkanı sağlar
//DRY: Don't Repeat Yourself

