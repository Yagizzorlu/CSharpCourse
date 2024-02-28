using System.Globalization;

namespace Conditionals
{
    public class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            if (number == 10)
            {
                Console.WriteLine("Number is ten");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is twenty");
            }
            else
            {
                Console.WriteLine("Number is not ten or twenty");
            }
            //Console.WriteLine(number == 10 ? "Number is ten : Number is not ten");
            //Burada tek satırda if yazmış olduk. Soru işareti 'ise' anlamını taşıyor. İki noktadan sonraki kısım else bloğunun çalışmasıdır.

            switch(number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:      //10 veya 20 olmama durumu
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }

            if (number >= 0 && number <= 100)  //ve anlamında
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0)  //veya anlamında
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            //if(number<100)
            //{
            //    if(number >= 90 && number < 95)
            //    {

            //    }
            //}    İç içe if yazılabilir.
        }
    }
}
