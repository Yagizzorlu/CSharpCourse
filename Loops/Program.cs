namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Bitti");   //100 ü yazdıktan sonra bunu yazar.
            for (int i = 1; i <= 100; i+=2)   //Tek sayıları yazdırmış oluruz.
            {
                Console.WriteLine(i);
            }
            //100 den başlatıp 0 dan büyük diyip i-=2 de diyebiliriz.

            int number = 100;
            while(number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0} ", number);  //En son sayı -1 e düşer ve döngünün içine girmez.Çünkü 0'dan küçük.
            //Bu yüzden -1 yazdırır.

            int number2 = 10;
            do
            {
                Console.WriteLine(number2);
                number2--;

            } while (number>=11);    //Şart sağlanmıyor ama yine de 1 kere çalışıyor. Do-While şart sağlanmasa bile en az 1 kere çalışır.

            string[] students = new string[3] { "Yağız", "Metehan", "Ahmet" };
            foreach (var student in students) 
            {
                Console.WriteLine(student);
            }
        }
    }
}
