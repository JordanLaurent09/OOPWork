using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace JsonLibraryApp
{
    public class Library
    {
        public List<Book> library { get; set; } = new List<Book>();


        /// <summary>
        /// Метод, записывающий список объектов в файл 
        /// </summary>
        /// <param name="books"></param>
        public void SerializeBooks(List<Book> books)
        {
            JsonSerializer serializer = new JsonSerializer();

            using(StreamWriter sw = new StreamWriter($"{Directory.GetCurrentDirectory()}\\library.json"))
                using(JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, books);
            }
        }

        /// <summary>
        /// Метод, получающий данные из файла в список
        /// </summary>
        /// <returns></returns>
        public List<Book> DeserializeBooks()
        {
            List<Book> books = new List<Book>();

            string data = File.ReadAllText("library.json");

            books = JsonConvert.DeserializeObject<List<Book>>(data);

            return books;
        }
    }
}
