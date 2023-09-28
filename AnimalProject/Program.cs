using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Animal> zoo = new List<Animal>();



            // Создание и добавление экземпляров животных разных видов в список

            Carnivora lion = new Carnivora("Lion", 250);
            lion.FoodInfo();
            lion.id = random.Next(10000, 99999);
            zoo.Add(lion);

            Carnivora crocodile = new Carnivora("Crocodile", 250);
            crocodile.FoodInfo();
            crocodile.id = random.Next(10000, 99999);
            zoo.Add(crocodile);

            Herbivore bull = new Herbivore("Bull", 250);
            bull.FoodInfo();
            bull.id = random.Next(10000, 99999);
            zoo.Add(bull);

            Carnivora tiger = new Carnivora("Tiger", 200);
            tiger.FoodInfo();
            tiger.id = random.Next(10000, 99999);
            zoo.Add(tiger);

            Carnivora cougar = new Carnivora("Cougar", 100);
            cougar.FoodInfo();
            cougar.id = random.Next(10000, 99999);
            zoo.Add(cougar);

            Herbivore cow = new Herbivore("Cow", 250);
            cow.FoodInfo();
            cow.id = random.Next(10000, 99999);
            zoo.Add(cow);

            Omnivore monkey = new Omnivore("Monkey", 70);
            monkey.FoodInfo();
            monkey.id = random.Next(10000, 99999);
            zoo.Add(monkey);


            /* 1. Сортировка животных по убыванию количества пищи.
                  При одинаковом количестве пищи происходит сортировка по имени животного */

            for (int i = 0; i < zoo.Count - 1; i++)
            {
                for (int j = i + 1; j < zoo.Count; j++)
                {
                    if (zoo[i].foodAmount < zoo[j].foodAmount)
                    {
                        Animal temp = zoo[i];
                        zoo[i] = zoo[j];
                        zoo[j] = temp;
                    }
                    else if ((zoo[i].foodAmount == zoo[j].foodAmount) && zoo[i].name.CompareTo(zoo[j].name) > 0)
                    {

                        Animal temp = zoo[i];
                        zoo[i] = zoo[j];
                        zoo[j] = temp;
                    }
                }
            }

            // Вывод списка на экран

            Console.WriteLine("Вывод списка животных на экран:");

            foreach (Animal item in zoo)
            {
                Console.WriteLine("Имя - " + item.name + ", количество пищи - " + item.foodAmount + ", вид пищи - " + item.foodType + ", идентификатор - " + item.id);
            }
            Console.WriteLine();
            // 2. Вывод имен первых пяти животных списка

            Console.WriteLine("Первые пять имен животных:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(zoo[i].name);
            }
            Console.WriteLine();

            // 3. Вывод трех последних идентификатора животных

            Console.WriteLine("Три последних идентификатора животных:");
            for (int i = zoo.Count - 1; i > zoo.Count - 4; i--)
            {
                Console.WriteLine(zoo[i].id);
            }
            Console.WriteLine();


            /* 4-5. Создание пути к файлу для записи коллекции,
             * с обработкой некорректного формата файла, а также запись в файл
             * и чтение из него */

            string path;
            string fileName = "Animals.txt";

            if (fileName.EndsWith(".txt"))
            {
                path = fileName;
            }
            else
            {
                path = @"defaultFile.txt";
            }

            // Запись списка в файл

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (Animal item in zoo)
                {
                    sw.Write(item.name + " ");
                    sw.Write(item.weight + " ");
                    sw.Write(item.foodAmount + " ");
                    sw.Write(item.foodType + " ");
                    sw.WriteLine(item.id);
                }
            }


            // Создание списка для хранения данных из файла

            List<Animal> fromFile = new List<Animal>();


            // Чтение из файла и запись в новый список всех животных

            string[] allData = File.ReadAllLines(path);

            for (int i = 0; i < allData.Length; i++)
            {
                string[] animalLine = allData[i].Split(' ');
                if (animalLine[3] == "Meat")
                {
                    Carnivora carnivora = new Carnivora(animalLine[0], double.Parse(animalLine[1]));
                    carnivora.foodAmount = double.Parse(animalLine[2]);
                    carnivora.foodType = animalLine[3];
                    carnivora.id = int.Parse(animalLine[4]);
                    fromFile.Add(carnivora);
                }
                else if (animalLine[3] == "Everything")
                {
                    Omnivore omnivore = new Omnivore(animalLine[0], double.Parse(animalLine[1]));
                    omnivore.foodAmount = double.Parse(animalLine[2]);
                    omnivore.foodType = animalLine[3];
                    omnivore.id = int.Parse(animalLine[4]);
                    fromFile.Add(omnivore);
                }
                else if (animalLine[3] == "Vegetables")
                {
                    Herbivore herbivore = new Herbivore(animalLine[0], double.Parse(animalLine[1]));
                    herbivore.foodAmount = double.Parse(animalLine[2]);
                    herbivore.foodType = animalLine[3];
                    herbivore.id = int.Parse(animalLine[4]);
                    fromFile.Add(herbivore);
                }
            }

            // Вывод содержимого файла на экран

            Console.WriteLine("Вывод животных, прочитанных из файла: ");

            foreach (Animal item in fromFile)
            {
                Console.WriteLine("Имя - " + item.name + ", количество пищи - " + item.foodAmount + ", вид пищи - " + item.foodType + ", идентификатор - " + item.id);
            }
        }
    }
}
