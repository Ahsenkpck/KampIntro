using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "123456";
            customer1.Name = "Ahsen";
            customer1.Surname = "Kıpçak";
            customer1.TcNumber = "1111111111";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.CustomerNumber = "6252422";
            customer2.Id = 2;
            customer2.CompanyName = "Kıpçaklar";
            customer2.TaxNumber = "76262";

            //Gerçek müşteri - Tüzel müşteri

            Customer customer3 = new IndividualCustomer();//new->bellekteki referans numarası
            Customer customer4 = new CoorporateCustomer();
            //hem gerçek hem de tüzel müşterinin referansını tutabiliyor

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
