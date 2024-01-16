using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;

namespace LINQ_Entrance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Good> goods = new List<Good>();

            using(StreamReader streamReader = new StreamReader("inventoryControl.csv"))
            {
                CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture);
                CsvReader reader = new CsvReader(streamReader, config);

                goods = reader.GetRecords<Good>().ToList();
            }

            IEnumerable<Good> evenGoods = goods.Where(p => p.Quantity % 2 == 0);

            foreach(Good item in evenGoods)
            {
                Console.WriteLine($"Название товара: {item.Name}, количество: {item.Quantity}," +
                    $"цена - {item.Price}, а вот описание: {item.Description}");
            }
        }
    }
}
