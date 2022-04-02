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

            //RetreivingTopTwoRecords_ForAgeIs_LessThanSixty(listPersonInCity);
            //Retrieve_Record_Age_bet_Thirteen_to_Eighteen(listPersonInCity);
            //Retrieve_Average_Age(listPersonInCity);
            Check_spaecific_name_present_absent(listPersonInCity);
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
        public static void Retrieve_Record_Age_bet_Thirteen_to_Eighteen(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(x => (x.Age >= 13 && x.Age < 19)).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public static void Retrieve_Average_Age(List<Person> listPersonInCity)
        {
            var avg_age = listPersonInCity.Average(s => s.Age);
            Console.WriteLine("Average Age in list : " + avg_age);
        }
        public static void Check_spaecific_name_present_absent(List<Person> listPersonInCity)
        {
            Console.WriteLine("Enter name of person you want to check");
            string inputname = Console.ReadLine();
            if (listPersonInCity.Exists(x => x.Name == inputname))
            {
                Console.WriteLine(" A person exists in our list");
            }
            else
            {
                Console.WriteLine(" A person not exists in our list");
            }
        }
    }
}