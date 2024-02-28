namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();    Mesajı değiştirdiğimizde bu 4 ünü de tek tek değiştirmiyoruz. Metotların amacı bu.Kendimizi tekrar etmiyoruz.
            //var result = Add2(20, 50);    var eşitliğin karşısı neyse o veri tipini atar.

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1 , number2);
            Console.WriteLine(result2);   //130 olur cevap. number1 'e 20 verdik. Metot içinde number1 = 30 olduğu için işlem 30 + 100 haline geldi.
            //Burada metoda gittiği için oradaki değişimlerden etkilenir.
            Console.WriteLine(number1);  // Cevap 20 dir.  number1 aynı gözükse de int bir değer tip olduğundan int number1 = 30 işlemi buradaki number1 i etkilemez.

            //Metotta ref int number1 ve var result2 = Add3 içinde ref number1 yazarsak artık number1 tek bir adres kullanır ve number1 yazdırdığımızda da cevap 30 olur.

            //Console.WriteLine(result);

            Console.WriteLine(Multiply(2 , 4));
            Console.WriteLine(Multiply(2 , 4 , 5));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));   //params sayesinde istediğimiz kadar parametre gönderebiliriz.
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!");
        }

        static int Add2(int number1 , int number2)
        {
            var result = number1 + number2;
            return result;  //void ile return olmaz.
        }
        //Add2 içinde int number1 , int number2 = 30 yazarsak mesela Add2(20); dediğimizde ikinci sayıyı default olarak 30 alır ve 20 + 30 yapar.
        //Tek bir default değer vereceksek baştakine veremeyiz,sondaki olmalı.

        static int Add3(int number1 , int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2) 
        {
            return number1 * number2;   
        }

        static int Multiply(int number1, int number2, int number3)   //Parametreler farklı olunca metot ismi aynı olabiliyor. Method Overloading denir.
        {
            return number1 * number2 * number3 ;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();  //Bu hazır metotlardan biri.
        }
    }
}
