using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //individual customer
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.customerId = 2;
            customer1.customerNumber = "987654";
            customer1.firstName = "Aişe";
            customer1.lastName = "Meydan";
            customer1.TcNo = "12345678910";
            

            //corporate customer
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.customerId = 1;
            customer2.customerNumber = "123456";
            customer2.companyName = "Ahm Holding";
            customer2.taxtNo = "1234567890";


            //Gerçek Müşteri  -  Tüzel Müşteri
            //SOLID
            //customer classı hem individual customer hem de corporate customer referansını tutabiliyor;
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer3);

        }
    }
}
//olay tamamen referans tip, base sınıf yani müşterinin yani temel sınıfın onu inherite eden tüzel müşteri,gerçek müşterinin
//aslında referanslarını tutabilmesi

//referans tutucu