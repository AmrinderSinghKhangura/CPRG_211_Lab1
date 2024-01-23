using Lab1Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Classes
{
    internal class Relation(string t)
    {
        private string relationshipType = t;

        public void ShowRelationShip(Person one, Person two)
        {
                Console.WriteLine($"Relationsship between {one.firstName} and {two.firstName} is: {this.relationshipType}hood");
        }

    }
}

