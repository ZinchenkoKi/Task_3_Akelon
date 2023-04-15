using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3_working_Excel_document.DocumentData;

namespace Task_3_working_Excel_document.DocumentProcessing
{
    internal class ReadProducts
    {
        public List<Products> Read(string path, int number)
        {
            var workbook = new XLWorkbook(path);
            var worksheet = workbook.Worksheet(number);
            var rows = worksheet.RangeUsed().RowsUsed();
            List<Products> product = new List<Products>();
            foreach (var row in rows)
            {
                Products products = new Products();
                products.ProductId = row.Cell(1).Value.ToString();
                products.ProductName = row.Cell(2).Value.ToString();
                products.UnitMeasurement = row.Cell(3).Value.ToString();
                products.ProductPricePerUnit = row.Cell(4).Value.ToString();
                product.Add(products);
            }
            return product;
        }
    }
}
