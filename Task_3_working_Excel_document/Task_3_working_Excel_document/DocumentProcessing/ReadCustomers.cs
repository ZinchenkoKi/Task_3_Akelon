using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3_working_Excel_document.DocumentData;

namespace Task_3_working_Excel_document.DocumentProcessing
{
    internal class ReadCustomers
    {
        public List<Customers> Read(string path, int number)
        {
            var workbook = new XLWorkbook(path);
            var worksheet = workbook.Worksheet(number);
            var rows = worksheet.RangeUsed().RowsUsed();
            List<Customers> customer = new List<Customers>();
            foreach (var row in rows)
            {
                Customers customers = new Customers();
                customers.CustomersId = row.Cell(1).Value.ToString();
                customers.NameOrganization = row.Cell(2).Value.ToString();
                customers.Address = row.Cell(3).Value.ToString();
                customers.ContactPerson = row.Cell(4).Value.ToString();
                customer.Add(customers);
            }
            return customer;
        }
    }
}
