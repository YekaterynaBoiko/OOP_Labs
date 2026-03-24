using System.Net;
using System.Xml.Linq;
using static Lab13_Task3.Program;

namespace Lab13_Task3
{
    internal class Program //Task3
    {

        public class Person
        {
            public int PersonID, Age;
            public string Name, Address;

            public Person(int PersonID, string Name, int age, string Address)
            {
                this.PersonID = PersonID;
                this.Name = Name;
                this.Age = age;
                this.Address = Address;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"PersonID: {PersonID} \nName: {Name} \nAge: {Age} \nAddress: {Address}");
                Console.WriteLine();
            }

            public void UpdateAddress(string newAddress)
            {
                Address = newAddress;
            }
        }

        public class PersonManager
        {
            public List<Person> Persons = new List<Person>();

            public void AddNewPerson(int PersonID, string Name, int age, string Address)
            {
                Persons.Add(new Person(PersonID, Name, age, Address));
            }

            public void DisplayAllPeople()
            {
                foreach (var person in Persons) { person.DisplayInfo();}
            }

            public Person SearchByName(string Name)
            {
                foreach (var person in Persons)
                {
                    if (person.Name == Name) return person;
                }
                return null;
            }

            public void ShowID()
            {
                foreach (var person in Persons) Console.WriteLine(person.PersonID);
            }
            public Person SearchByID(int PersonID)
            {
                foreach (var person in Persons)
                {
                    if (person.PersonID == PersonID) return person;
                }
                return null;
            }

            public void AddressUpdateByID(int PersonID, string newAddress)
            {
                Person person = SearchByID(PersonID);
                if (person != null) { person.UpdateAddress(newAddress); }
                else Console.WriteLine("Person not found");
            }

            public void RemoveByID(int PersonID) 
            {
                //foreach (var person in Persons) //
                //{
                //    if (person.PersonID == PersonID)
                //    {
                //        Persons.Remove(person);
                //        return;
                //    }
                //}
                var person = SearchByID(PersonID);
                if (person != null)  Persons.Remove(person);
                else Console.WriteLine("Person not found");
            }
        }
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();

            personManager.AddNewPerson(111, "Kate", 18, "Kyiv");
            personManager.AddNewPerson(112, "Max", 25, "Lviv");
            personManager.AddNewPerson(113, "Lilya", 17, "Rivne");
            personManager.AddNewPerson(114, "Anton", 20, "Kharkiv");
            Console.WriteLine("All people and info: ");
            personManager.DisplayAllPeople();

            Console.WriteLine("Enter name to search: ");
            string name = Console.ReadLine();
            Person foundByName = personManager.SearchByName(name);
            if (foundByName != null) foundByName.DisplayInfo();
            else Console.WriteLine("Person not found");

            Console.WriteLine("All IDs: ");
            personManager.ShowID();
            Console.WriteLine("Enter PersobID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Person foundByID = personManager.SearchByID(id);
            if (foundByID != null) foundByID.DisplayInfo();
            else Console.WriteLine("Person not found");

            Console.WriteLine("Enter the city you want to replace it with: ");
            string city = Console.ReadLine();
            personManager.AddressUpdateByID(id, city);
            Console.WriteLine("Info after address updte: ");
            personManager.DisplayAllPeople();

            personManager.RemoveByID(id);
            Console.WriteLine("Info after removing: ");
            personManager.DisplayAllPeople();
        }
    }
}
