namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Yağız" },
                new Student{FirstName = "Sinem"},     //Üçü de person'a bağlı.Interfacelerin tek başına anlamı yok ama classların var.
                new Person{FirstName = "Ahmet"}
            };

            foreach (var person in persons) 
            {
                Console.WriteLine(person.FirstName);   //Hepsini dolaşır ve hepsinin ismini yazdırır.
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Person2
    {
          //Inheritance önce yazılır.Bir kişinin 2 babası olamaz o yüzden Customer: Person,Person2 yazamayız.
          //Kaç tane interface varsa Inheritance'dan sonra yazılır.
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
