namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int number1 = 10;
            Console.WriteLine("Number1 is {0} ", number1);  // Bu {0} virgülden sonraki ilk şeyi yazdırır.
            //int number2 = 10000000000;  //int in sınırı var.
            long number3 = 2147483647;    //long 64 bitlik yer kaplar.
            Console.WriteLine("Number3 is {0} ", number3);
            short number4 = -32768;  //sınırı eksilerde bu sayıya kadar.
            Console.WriteLine("Number4 is {0} ", number4);
            byte number5 = 0;  //Max 255 sayısını tutabilir.
            bool condition = false;   //condition şart demektir.
            char character = 'A';
            Console.WriteLine("Character is {0} ", character);
            Console.WriteLine("Character is {0} ", (int)character); //Bu şekilde yazarsak A harfinin ASCII de sayısal karşılığını verir.
            double number6 = 10.4;  //ondalık sayıları yazdırır.
            decimal number7 = 10.4m;
            //if(Days.Friday ==) { }
            Console.WriteLine((int)Days.Friday);  // Saymaya 0'dan başladığımız için 4 yazdırır.
            //Monday = 10, dersek diğerlerinin değerini ona göre yazdırır bu arada.
            var number8 = 10;  //number8 in veri tipi int olarak algılanır. 
            //number8 = 'A';  65 olarak algılanır çünkü number8 in veri tipi int oldu. Bunu 'var' sağladı.
            
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
