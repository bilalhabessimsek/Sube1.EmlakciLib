namespace Sube1.EmlakciLib
{

   
    public abstract class Ev
    {
        public static int Sayac { get; private set; }

        public string Buyukluk { get; private set; }
        public int Katno { get; set; }
        private string semt;
        public string Semt { get => semt; set => semt = value.ToUpper(); }
        private int odasayisi;
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }
        private double alan;
        public double Alan
        {

            get { return alan; }
            set
            {
                if (value < 50)
                {
                    throw new Exception("Min alan değeri 50 olmalıdır");
                }
                alan = value;
                if (this.alan > 50 && this.alan < 75)
                {
                    this.Buyukluk = "Küçük Ev";
                }
                else if (this.alan > 75 && this.alan < 120)
                {
                    this.Buyukluk = "Orta büyüklükte ev";
                }
                else
                {
                    this.Buyukluk = "Büyük ev";
                }
            }
        }

        public Ev()
        {
            Sayac++;
        }
        public Ev(int odasayisi, int katno, double alan, string semt = "Kızılay")
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
            Sayac++;
        }

        public Ev(int odasayisi, int katno, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = "Kızılay";
            this.Alan = alan;
            Sayac++;
        }
        public abstract string OzelBilgi();
        public virtual string TemelBilgiler()
        {
            return $"Oda Sayısı:{this.Odasayisi}\n" +
                   $"Kat no:{this.Katno}\n" +
                   $"Alan:{this.Alan}\n" +
                   $"Semt:{this.Semt}\n" +
                   $"Büyüklük:{this.Buyukluk}";
        }
        public string EvBilgileri()
        {
            return $"{TemelBilgiler()}\n{OzelBilgi()}";
        }
    }

}
    //virtual: Override edilmesi gereken üyeler, virtual anahtar kelimesi ile tanımlanır.
    //Polymorphisim(Çok biçimlilik): base classta virtual olarak tanımlanan üyeler, türeyen classlarda override edilerek farklı biçimlerde kullanılabilir.

    //Constructor-Yapıcı Metod-Kurucu Metod
    //Görevi: Bir classtan nesne türetilirken çalışır ve class içindeki fieldlara varsayılan değer atamalarını yapar.
    //Her classta mutlaka vardır. Varsayılan olarak parametre almazlar. bu constructorlara default constructor da denir.
    //İsimleri class adı ile aynıdır. Farklı isimle tanımlamazlar.
    //Geri dönüş tipleri yoktur.
    //Classlardan nesne türetildilğinde çalışan ilk metoddur.
    //ctor code snippeti ile default constructor oluşturulabilir. ctor+tab

    //Bir class içinde static olarak tanımlanan üyelere, class ismi ile erişilir ve bu üyeler program çalıştığı sürece bellekte tutulurlar. Nesnelerden bağımsız, class'a ait yapılar.

    //Kapsülleme (Encapsulation) İlkesi: Class içerisinde yapılan işlerin, class dışından gizlenmesidir. Örn: odasayisi field'ına değer atama işlemi yapmak için öncelikle field private yapıldı, sonrasında bu fielda erişebilen public SetOdaSayisi(int odasayisi) metodu yazıldı. Bu metod içinde gelen değerin mutlak değeri alınarak odasayisi fieldına aktarıldı ve bu işlemden bu metodu kullananların bilgisi olmadı.

