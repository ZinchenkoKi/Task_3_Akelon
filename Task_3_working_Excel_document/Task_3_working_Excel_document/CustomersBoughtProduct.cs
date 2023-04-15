using System;
using System.Linq;
using Task_3_working_Excel_document.DocumentData;
using System.Collections.Generic;

namespace Task_3_working_Excel_document
{
    internal class CustomersBoughtProduct
    {
        public void BoughtProduct(List<Products> products, List<Customers> customers, List<Applications> applications)
        {

            string ProductName = ProductNameRequest();

            Products product = products.FirstOrDefault(p => p.ProductName == ProductName);
            Applications application = applications.FirstOrDefault(p => p.ProductId == product.ProductId);

            if (application == null)
            {
                Console.WriteLine($"Товар не был куплен");
            }
            else
            {
                Customers customer = customers.FirstOrDefault(c => c.CustomersId == application.CustomersId);
                PrintingReport(product, application, customer);
            }
        }

        private string ProductNameRequest()
        {
            Console.WriteLine($"Ввыедите название товара : ");
            return Console.ReadLine();
        }

        private int PricePurchasedProduct(string firstValue, string secondValue)
        {
            return Convert.ToInt32(firstValue) * Convert.ToInt32(secondValue);
        }

        private void PrintingReport(Products product, Applications application, Customers customer)
        {
            Console.WriteLine($"Клиент {customer.ContactPerson} Код клиента {customer.CustomersId} ");
            Console.WriteLine($"Наименование организации {customer.NameOrganization} Адресс {customer.Address}");
            Console.WriteLine($"Купил {product.ProductName} в количестве {application.RequiredQuantity}-ти {product.UnitMeasurement}");
            Console.WriteLine($"На сцмму {PricePurchasedProduct(application.RequiredQuantity, product.ProductPricePerUnit)} рублей");
            Console.WriteLine($"Дата покупки {application.DatePlacement}");
        }
    }
}
