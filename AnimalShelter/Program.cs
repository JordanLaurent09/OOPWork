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
            Wards[animal.Id] = animal;
        }

        public List<T> GetAnimals()
        {
            return Wards;
        }

        public T GetConcreteAnimal(int id)
        {
            return Wards[id];
        }
    }
}
