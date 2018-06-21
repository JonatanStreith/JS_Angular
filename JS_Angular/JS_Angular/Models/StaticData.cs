using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JS_Angular.Models
{
    public class StaticData
    {

        public static void PopulateDatabase()
        {
            List<Person> people = new List<Person>
            {
                new Person() {Name = "Steve", Email = "Steve@mail.com", PhoneNumber = "555-6793", City = "New York", Country = "USA", Occupation = "Telephone hygienist" },
                new Person() {Name = "Joe", Email = "Joe@mail.com", PhoneNumber = "070-3403881", City = "Stockholm", Country = "Sweden", Occupation = "Social vocalist" },
                new Person() {Name = "Margot", Email = "BigM420@hotmail.com", PhoneNumber = "Not available", City = "London", Country = "UK", Occupation = "Mannequin" }    
            };

            var context = new PersonDataContext();

            context.People.AddRange(people);

            context.SaveChanges();


        }
    }
}