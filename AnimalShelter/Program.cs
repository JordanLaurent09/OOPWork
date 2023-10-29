using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cougar = new Animal(3, "Пума", "Pale", new DateTime(2020, 5, 1), 2);
            Animal jaguar = new Animal(1, "Ягуар", "Black", new DateTime(2019, 4, 25), 1);
            Animal tiger = new Animal(2, "Тигр", "Orange-Black", new DateTime(2018, 12, 25), 4);

            Animals<Animal> animals = new Animals<Animal>();
            animals.AddAnimal(cougar);
            animals.AddAnimal(tiger);
            animals.AddAnimal(jaguar);

            List<Animal> total = animals.GetAnimals();

            foreach(var item in total)
            {
                Console.WriteLine(item.Id + " " + item.NickName + " " + item.AcceptanceDate.ToShortDateString() + " " + item.Age + " " + item.Breed);
            }

            Console.WriteLine(animals.GetConcreteAnimal(1).NickName);
        }
    }

    class Animal:IListAnimal
    {
        public Animal(int id, string nickName, string breed, DateTime acceptanceDate, int age)
        {
            Id = id;
            NickName = nickName;
            Breed = breed;
            AcceptanceDate = acceptanceDate;
            Age = age;
        }

        public int Id { get; set; }
        public string NickName { get; set; }
        public string Breed { get; set; }

        public DateTime AcceptanceDate {get; set;}

        public int Age { get; set; }
    }

    interface IListAnimal
    {
        int Id { get; set; }
    }

    class Animals<T> where T : IListAnimal
    {
        public List<T> Wards { get; set; } = new List<T>();


        public void AddAnimal(T animal)
        {
            Wards.Add(animal);
        }

        public List<T> GetAnimals()
        {
            return Wards;
        }

        public T GetConcreteAnimal(int id)
        {
            T value = Wards[0];
            if(id >= Wards.Count)
            {
                Console.WriteLine("Животного с таким идентификатором нет. Выводится первое по списку животное");
                return value;
            }

            foreach(var item in Wards)
            {
                if(item.Id == id)
                {
                    value = item;
                }
            }

            return value;
        }
    }
}
