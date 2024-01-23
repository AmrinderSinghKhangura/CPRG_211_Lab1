using System.Diagnostics.Metrics;

namespace Lab1Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {   //a. Create four objects using the following data:
            Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            //b. Display Gina’s information as a sentence that shows her id, first name, last name and her favorite colour. 
            Gina.DisplayPersonInfo();
            //c. Display all of Mike’s information as a list.
            Console.WriteLine(Mike);
            //d. Change Ian’s Favorite Colour to white, and then print his information as a sentence.
            Ian.ChangeFavoriteColor();
            Ian.DisplayPersonInfo();
            //e. Display Mary’s age after ten years.
            Console.WriteLine($"Mary Beal's age in 10 years: {Mary.GetAgeInTenYears()}");

            //f. Create two Relation Objects that show that Gina and Mary are sisters, and that Ian and Mike are brothers. Then, display both relationships.
            Relation sisterhood = new Relation("Sister");
            Relation brotherhood = new Relation("Brother");
            sisterhood.ShowRelationShip(Gina, Mary);
            brotherhood.ShowRelationShip(Ian, Mike);

            // Add all the Person objects to a list 
            List<Person> personList = new List<Person> { Ian, Gina, Mike, Mary };
            
            // Display average age
            int total = 0;
            double counter = 0;
            foreach (Person person in personList)
            
            {
                total += person.age;
                counter++;
            }
            double average = total / counter;
            Console.WriteLine($"Average age is: {average}");
            
            // Display youngest and oldest Persons
            int youngest= 999, oldest=0;
            string youngestName="", oldestName="";
            foreach (Person person in personList)
            {
                if (person.age < youngest)
                {
                    youngest = person.age;
                    youngestName = person.firstName;
                }
                if (person.age > oldest)
                {
                    oldest = person.age;
                    oldestName = person.firstName;
                }
            }
            Console.WriteLine($"The youngest person is: {youngestName}");
            Console.WriteLine($"The oldest person is: {oldestName}");
            
            // Display Names of Persons who's name starts with "M"
            Console.WriteLine($"\nPeople who's names start with M:");
            foreach (Person person in personList)
            {
                if (person.firstName.StartsWith("M"))
                {
                    Console.WriteLine(person.firstName);
                }
            }

            // Display all info of Persons who's favourite color is "Blue"
            Console.WriteLine("\nPeople who's favorite color is blue:");
            foreach (Person person in personList)
            {
                if(person.favoriteColor == "Blue")
                {
                    Console.WriteLine(person);
                }
            }

            Console.ReadLine();
        }
    }
}
