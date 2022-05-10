using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Customer customer1 = new Customer();
            customer1.Iban = 1381284564510841;
            customer1.Name = "Mahmud";
            customer1.Surname = "Yuvakuran";
            customer1.Gender = "Bay";
            customer1.TcNo = 12345678910;
            

            Customer customer2 = new Customer();
            customer2.Iban = 9656546455625829;
            customer2.Name = "Kenan";
            customer2.Surname = "İmirzali";
            customer2.Gender = "Bay";
            customer2.TcNo = 45687912310;
            

            Customer customer3 = new Customer();
            customer3.Iban = 01585654432956;
            customer3.Name = "Simge";
            customer3.Surname = "Toktaş";
            customer3.Gender = "Bayan";
            customer3.TcNo = 98765432110;
            

           
            Customer[] customers = new Customer[]
            {
                customer1,
                customer2,
                customer3
            };


            Console.WriteLine("Her Bir Musterinin Bilgilerini Sirayla Gostermek:");
            Console.WriteLine("**************************************************");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Iban);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Gender);
                Console.WriteLine(customer.TcNo);
                
                Console.WriteLine("--------------------------------------------------");
            }


            Console.WriteLine("Musterilerin Bankaya Eklenmesi");
            Console.WriteLine("*********************************");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("--------------------------------------------------");

            
            Console.WriteLine("Musterilerin Listelenmesi:");
            Console.WriteLine("**************************************************");
            customerManager.CustomerList(customer1, customer2, customer3);    


            Console.WriteLine("--------------------------------------------------");


            Console.WriteLine("Musterilerin Bankadan Silinmesi:");
            Console.WriteLine("**************************************************");
            customerManager.Delete(customer3);
            customerManager.Delete(customer1);

            Console.WriteLine("--------------------------------------------------");

            
            Console.WriteLine("Operasyonun Sonlanmasi:");
            Console.WriteLine("**************************************************");
            customerManager.OperationEnd("Operasyon Sonlandi!!!");

            Console.WriteLine("--------------------------------------------------");
            Console.ReadKey();
        }
    }
}