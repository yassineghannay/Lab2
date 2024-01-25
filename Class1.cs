
using System;
using System.Collections.Generic;
using System.Globalization;


namespace lab2
{
    
    class Person
    {
        public int personId;
        public string firstName;
        public string lastName ;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name= {firstName} {lastName} personId: {personId}, {firstName}'s favorite color is {favoriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            string favoriteColour;
            favoriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            int age = 0;
            return age + 10;
        }

        public override string ToString()
        {
            return $"PersonId: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavoriteColour: {favoriteColour}\nAge: {age}\nIsWorking: {isWorking}";
        }
    }

    class Relation
    {
        public string RelationshipType;

        public void ShowRelationShip(Person person1, Person person2)
        {
            Console.WriteLine($"relationship between {person1.firstName} and {person2.firstName} is: {RelationshipType}");
        }
    }

    class Main
    {
        public static void Main(string[] args)
        {
           
            Person Ian = new Person { personId = 1, firstName = "Ian", lastName = "Brooks", favoriteColour = "Red", age = 30, isWorking = true };
            Person Gina = new Person { personId = 2, firstName = "Gina", lastName = "James", favoriteColour = "Green", age = 18, isWorking = false };
            Person Mike = new Person { personId = 3, firstName = "Mike", lastName = "Briscoe", favoriteColour = "Blue", age = 45, isWorking = true };
            Person Mary = new Person { personId = 4, firstName = "Mary", lastName = "Beals", favoriteColour = "Yellow", age = 28, isWorking = true };

           
            Console.WriteLine($"{Gina.personId}: {Gina.firstName} {Gina.lastName}'s favorite colour is {Gina.favoriteColour}");

           
            Console.WriteLine(Mike.ToString());

            
            Ian.ChangeFavoriteColour();
            Console.WriteLine($"{Ian.firstName} {Ian.lastName}'s favorite colour is: {Ian.favoriteColour}");

            
            Console.WriteLine($"{Mary.firstName} {Mary.lastName}'s Age in 10 years is: {Mary.GetAgeInTenYears()}");

           
            Relation sisterhood = new Relation { RelationshipType = "Sisterhood" };
            Relation brotherhood = new Relation { RelationshipType = "Brotherhood" };

            sisterhood.ShowRelationShip(Gina, Mary);
            brotherhood.ShowRelationShip(Ian, Mike);

            
    
            // unfinished
        }

      
        }
    }
