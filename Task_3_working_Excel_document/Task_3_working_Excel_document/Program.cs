using System;
using Task_3_working_Excel_document.DocumentData;
using System.Collections.Generic;
using Task_3_working_Excel_document.DocumentProcessing;

namespace Task_3_working_Excel_document
{
    public class Program
    {
        public static void Main()
        {
            FilePath filePath = new FilePath();
            ReadApplications readingDocument = new ReadApplications();
            ReadProducts readingProducts = new ReadProducts();
            ReadCustomers readCustomers = new ReadCustomers();
            CustomersBoughtProduct boughtProduct = new CustomersBoughtProduct();
            string path = filePath.Path();

            List<Products> products = readingProducts.Read(path, 1);
            List<Customers> customers = readCustomers.Read(path, 2);
            List<Applications> applications = readingDocument.Read(path, 3);

            boughtProduct.BoughtProduct(products, customers, applications);
            Console.ReadKey();
        }
    }

}