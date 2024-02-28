namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İzmir";
            customer.Id = 1;
            customer.FirstName = "Yağız";
            customer.LastName = "Zorlu";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İzmir",
                FirstName = "Sinem",
                LastName = "Çetiner"
            };

            Console.WriteLine(customer2.FirstName);
        }
    }
}
