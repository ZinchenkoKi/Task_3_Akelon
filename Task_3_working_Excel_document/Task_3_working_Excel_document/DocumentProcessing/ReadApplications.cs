using System;
using System.Collections.Generic;
using System.Linq;
using ClosedXML.Excel;
using Task_3_working_Excel_document.DocumentData;

namespace Task_3_working_Excel_document.DocumentProcessing
{
    internal class ReadApplications
    {
        public List<Applications> Read(string path, int number)
        {
            var workbook = new XLWorkbook(path);
            var worksheet = workbook.Worksheet(number);
            var rows = worksheet.RangeUsed().RowsUsed();
            List<Applications> application = new List<Applications>();
            foreach (var row in rows)
            {
                Applications applications = new Applications();
                applications.ApplicationId = row.Cell(1).Value.ToString();
                applications.ProductId = row.Cell(2).Value.ToString();
                applications.CustomersId = row.Cell(3).Value.ToString();
                applications.ApplicationNumber= row.Cell(4).Value.ToString();
                applications.RequiredQuantity = row.Cell(5).Value.ToString();
                applications.DatePlacement = row.Cell(6).Value.ToString();
                application.Add(applications);
            }
            return application;
        }
    }
}
