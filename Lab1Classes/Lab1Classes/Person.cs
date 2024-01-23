using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Classes
{
    public class Person(int p, string f, string l, string c, int a, bool w)
    {
        public int personid = p;
        public string firstName = f;
        public string lastName = l;
        public string favoriteColor = c;
        public int age = a;
        public bool isWorking = w;

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{this.personid}: {this.firstName} {this.lastName}'s favourite color is {this.favoriteColor}");
        }
        public void ChangeFavoriteColor()
        {
            this.favoriteColor = "white";
        }
        public int GetAgeInTenYears()
        {
            return this.age + 10;
        }
        public override string ToString()
        {
            return $"PersonId: {this.personid}\n" +
                $"FirstName: {this.firstName}\n" +
                $"LastName: {this.lastName}\n" +
                $"FavoriteColor: {this.favoriteColor}\n" +
                $"Age: {this.age}\n" +
                $"IsWorking: {this.isWorking}\n";
        }
    }
}
