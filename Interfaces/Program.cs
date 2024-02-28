namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Interfaceler new'lenemez.
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();     //Sql Added ve Oracle Added yazdıracak. Onları new'ledik ve sonrasında dolaştık.
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());

            IPerson person = new Customer();    //Bu yapılabilir.
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Yağız",
                LastName = "Zorlu",
                Address = "İzmir"
            };

            Student student = new Student()
            {
                Id = 2,
                FirstName = "Metehan",
                LastName = "Kaya",
                Department = "Computer Sciences"
            };
            personManager.Add(customer);   //personManager in Add metodunda adını yazdırıyoruz.
            personManager.Add(student);
        }
    }

    interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Worker : IPerson     //Worker eklediğimizde kalan hiçbir şeyle oynamadık çünkü zaten PersonManagerda IPerson eklemesi yapmıştık.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)   //IPerson dediğimiz için Student ve Customer i de kapsıyor.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
