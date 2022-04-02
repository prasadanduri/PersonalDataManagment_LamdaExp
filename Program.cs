using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to Lambda Expression Program");
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);

            RetreivingTopTwoRecords_ForAgeIs_LessThanSixty(listPersonInCity);
        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "Snehal", "12 Nagpur, Maharashtra", 15));
            listPersonInCity.Add(new Person("203456878", "Jitesh", "34 Wardha, Maharashtra", 25));
            listPersonInCity.Add(new Person("203456877", "Ashish", "16  Nashik, Maharashtra", 34));
            listPersonInCity.Add(new Person("203456879", "Amit", "31 Nanded, Maharashtra", 26));
            listPersonInCity.Add(new Person("203456880", "Shubham", "18 Lakhnau, Maharashtra", 23));
            listPersonInCity.Add(new Person("203456881", "Meena", "17 Wardha, Maharashtra", 21));
            listPersonInCity.Add(new Person("203456882", "Rita", "62 ,Baramati, Maharashtra", 22));
            listPersonInCity.Add(new Person("203456883", "Geeta", "42 Pune, Maharashtra", 54));
        }
        public static void RetreivingTopTwoRecords_ForAgeIs_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(x => (x.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
    }
}