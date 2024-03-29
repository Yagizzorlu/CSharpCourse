﻿using System.Reflection.Metadata.Ecma335;

namespace Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            if(IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            } 
            else
            {
                Console.WriteLine("This is not a prime number");
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if(number%i==0)
                {
                    result = false;  //Eğer tam bölünüyorsa result false'dir.
                }
            }
            return result;

            //metodu çalıştırırken 6 sayısını verdik. 2'ye tam bölündüğü için asal olmadığını gördük. For bittiğinde de result'ı döndürdük.
        }
    }
}
