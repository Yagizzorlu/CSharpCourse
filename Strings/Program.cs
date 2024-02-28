using System.Net.WebSockets;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Yağız Zorlu";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Yusuf Zorlu";

            bool result3 = sentence.EndsWith("u");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("namee");   //namee yok cümlede o yüzden -1 yazdırıyor.
            var result6 = sentence.IndexOf(" ");  //IndexOf ilk boşluğa bakar. 0 dan başlayınca ilk boşluk 2.karakterdedir.

            var result7 = sentence.LastIndexOf(" ");  //Aramaya sondan başlar.Sondan başlayıp ilk boşluğu bulur.O boşluğun BAŞTAN kaçıncı karakter olduğunu sayar.
            var result8 = sentence.Insert(0, "Hello, ");  //0. karaktere Hello,  ekler.

            var result9 = sentence.Substring(3);   //3.karakterden itibaren al.  name is Yağız Zorlu yazdırır.
            var result10 = sentence.Substring(3, 4);   //3.karakterden itibaren başlayıp 4 karakter alır.  Yani sadece "name"   yazdırır.
            var result11 = sentence.ToLower();
            var result12 = sentence.ToUpper();
            var result13 = sentence.Replace(" ", "-");    //Boşluklar yerine çizgi koyar.
            var result14 = sentence.Remove(2, 5);   //2 den itibaren 5 karakteri kaldır.

            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9); 
            Console.WriteLine(result13);
        }

        private static void Intro()
        {
            string city = "İzmir";
            Console.WriteLine(city[0]);    //İ yazar.

            foreach (var item in city) 
            {
                Console.WriteLine(item);     //Bu yazım şekliyle "İzmir" harflerini tek tek alt alta yazarız.
            }

            string city2 = "Balıkesir";
            string result = city + city2;

            Console.WriteLine(result);  //Stringlerde toplama yan yana yazmaktır.
        }
    }
}
