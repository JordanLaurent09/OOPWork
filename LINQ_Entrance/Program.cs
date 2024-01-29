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
            // 1. Goods
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

            // 2. Movies
            List<Movie> movies = new List<Movie>();

            using(StreamReader streamReader = new StreamReader("Movies.csv"))
            {
                CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture);
                CsvReader reader = new CsvReader(streamReader, config);

                movies = reader.GetRecords<Movie>().ToList();
            }

            IOrderedEnumerable<Movie> orderedMovies = movies.OrderByDescending(item => item.Year);

            foreach(Movie movie in orderedMovies)
            {
                Console.WriteLine($"Номер: { movie.Id}   Год: {movie.Year }    Жанр: {movie.Genre }   " +
                    $"Оценка: {movie.Graduate }   Название: {movie.Name }");
            }
        }
    }
}
