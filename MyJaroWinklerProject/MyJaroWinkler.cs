using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJaroWinklerProject
{
    public partial class MyJaroWinkler : Component
    {
        /// <summary>
        /// Karşılaştırılacak sözcükleri tutması için Metin1 Ve Metin2 isimli iki özellik tanımladım.
        /// </summary>
        public string Metin1 { get; set; }

        public string Metin2 { get; set; }

        /// <summary>
        /// jarowinkler puanı hesaplaması yapan metodun sonucunu döndürür.
        /// </summary>
        public double JaroWinklerPuan
        {
            get
            {
                return jarowinklerpuan();

            }
        }
        /// <summary>
        /// Jaro puanı hesaplayan metodun sonucunu geri döndürür.
        /// </summary>
        public double JaroPuan
        {
            get
            {
                return jaropuanhesapla();

            }
        }
        /// <summary>
        /// Jaro-Winkler mesafesini geri döndürür.Jaro-Winkler mesafesi; Jaro-Winkler benzerliğinin 1'den çıkarılmasıyla
        /// elde edilmektedir.
        /// </summary>
        public double JarowinklerMesafesi
        {
            get
            {
                return (1 - jarowinklerpuan());
            }
        }

        /// <summary>
        /// Jaro-Winkler benzerliğini hesaplayan metottur.
        /// </summary>
        /// <returns></returns>
        private double jarowinklerpuan()
        {


            string s1;
            string s2;
            int l = 0; //en fazla 4 karaktere kadar dizenin başlangıcındaki ortak önek uzunluğudur.
            double p = 0.1;//ortak öneklere sahip olmak için puanın ne kadar yukarı doğru ayarlandığına ilişkin sabit bir ölçeklendirme faktörüdür .0.25'i geçmemelidir (yani 1/4, ön ekin maksimum uzunluğu dikkate alınır),
            ///aksi takdirde benzerlik 1'den büyük olabilir. Winkler'in çalışmasında bu sabit için standart değer p=0.1
            bool ayni = true;
            if (Metin1.Length < Metin2.Length)//Kısa olan sözcüğü ilk kelime olarak belirledim.
            {
                s1 = Metin1.ToLower();
                s2 = Metin2.ToLower();
            }
            else
            {
                s1 = Metin2.ToLower();
                s2 = Metin1.ToLower();
            }
            for (int i = 0; i < s1.Length; i++)
            {

                if (ayni && s1[i] == s2[i]) // Başlangıçta aynı olan karakter sayısı tespit ediliyor
                {
                    l = l + 1;
                }
                else
                {
                    ayni = false;
                    break;
                }


            }

            if (l >= 4) //önek uzunluğu 4ten büyük olsa dahi l değerini 4 yaptım çünkü en fazla 4 olabilir. 
            {
                l = 4;
            }

            double jaropuan = jaropuanhesapla();//jaro puanının hesaplandığı metodun sonucunu double türünde bir değişkene atadım.
            return (jaropuan + l * p * (1 - jaropuan)); //Jaro-Winkler formülüdür.


        }

        private double jaropuanhesapla()
        {
            int apart = (int)(Math.Max(Metin1.Length, Metin2.Length) / 2 - 1);//Sözcüğün uzunluğuna bağlı olarak benzerlik hesabı sırasında karakterin 
            //en fazla ne kadar uzakta aranabileceğini hesaplayan işlem.

            double m; // eşleşen harf sayısı
            int n = 0;
            int t;// yer değiştirme sayisi
            int fark;
            string s1;
            string s2;
            double jaropuan;


            if (Metin1.Length <= Metin2.Length)//Kısa sözcüğü ilk sözcük yapıp hepsini küçük harf olarak dönüştürdüm.
            {
                s1 = Metin1.ToLower();
                s2 = Metin2.ToLower();
            }
            else
            {
                s1 = Metin2.ToLower();
                s2 = Metin1.ToLower();
            }

            List<char> eslesenler1 = new List<char>();//Eşleşen karakterler için listler tanımladım.
            List<char> eslesenler2 = new List<char>();
            int[] sec1 = new int[s1.Length];//İlk kelimenin uzunluğu kadar eleman içeren bir dizi tanımladım.
            int[] sec2 = new int[s2.Length];//İkinci kelimenin uzunluğu kadar eleman içeren bir dizi tanımladım.


            for (int i = 0; i < s1.Length; i++)
            {

                for (int j = 0; j < s2.Length; j++)
                {
                    fark = (int)Math.Abs(j - i);//Karşılaştırılan karakterlerin konumları arasındaki farkın mutlak değerini hesaplattım.

                    if (j == i && s1[i] == s2[i])//Bir karakterin iki sözcükte de aynı konumda bulunması durumu. 
                    {

                        sec1[i] = 1;
                        sec2[j] = 1;
                        break;
                    }

                    if (j < s1.Length)//j döngü değişkeni ilk sözcüğün uzunluğundan küçük ise gerçekleşecekleri yazdım.
                    {
                        if (j != i && s1[j] != s2[j] && s1[i] == s2[j] && fark <= apart)//Konumları aynı değil ama aynı karakterlerin uzaklık maksimum karşılaştırma uzaklığından(apart)
                        {                                                               //küçük veya eşit olma durumu.

                            sec1[i] = 1;
                            sec2[j] = 1;

                        }

                    }
                    else
                    {
                        if (j != i && s1[i] == s2[j] && fark <= apart)
                        {
                            sec1[i] = 1;
                            sec2[j] = 1;

                        }
                    }

                }


            }
            for (int j = 0; j < sec1.Length; j++)//İlk sözcüktede ikinci sözcüktede kurala uygun olarak eşleşen karakterleri listemize ekliyoruz.
            {
                if (sec1[j] == 1)//Ekleme işlemini eğer dizinin indeksindeki değer 1 ise gerçekleştirdim.
                {
                    eslesenler1.Add(s1[j]);
                }
            }
            for (int j = 0; j < sec2.Length; j++)////ikinci sözcüktede ikinci sözcüktede kurala uygun olarak eşleşen karakterleri listemize ekliyoruz.
            {
                if (sec2[j] == 1)//Ekleme işlemini eğer dizinin indeksindeki değer 1 ise gerçekleştirdim.
                {
                    eslesenler2.Add(s2[j]);
                }
            }
            for (int j = 0; j < eslesenler1.Count; j++) //Konumları farklı olarak eşleşen karakterler aracılığıyla transpoze hesaplaması için tanımladığım for döngüsü.
            {
                if (j < eslesenler2.Count && eslesenler1[j] != eslesenler2[j])
                {
                    n++;

                }
            }
            m = eslesenler1.Count;
            t = n / 2; //Sırayla olmayan karakter sayısının yarısı.

            if (m == 0) //  eşleşen karakter yok ise benzerlik puanı 0 dir
            {
                jaropuan = 0;
            }
            else
            {
                

                jaropuan = (m / Metin1.Length + m / Metin2.Length + (m - t) / m) / 3;//Jaro formülüdür.
            }



            return jaropuan;
        }
        public MyJaroWinkler()
        {
            InitializeComponent();
        }

        public MyJaroWinkler(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
