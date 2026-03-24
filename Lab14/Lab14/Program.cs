using System.ComponentModel;

namespace Lab14
{
    internal class Program
    {

        public class SoftwareLicense
        {
            public static int AvailableLicenses = 5;
            public string OwnerName;
            public string LicenseKey;
            public bool IsActive;

            public SoftwareLicense(string ownerName)
            {
                this.OwnerName = ownerName;
                if (AvailableLicenses > 0)
                {
                    AvailableLicenses--;
                    IsActive = true;
                    LicenseKey = Guid.NewGuid().ToString().Substring(0, 8).ToUpper(); //генерація рандомних штук
                }
                else
                {
                    IsActive = false;
                    LicenseKey = "No License";
                    Console.WriteLine("Error 404");
                }
            }
            public static void PrintAvalabelLicenses()
            {
                Console.WriteLine($"Available Licenses: {AvailableLicenses}");
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Name: {OwnerName} \nActive or not: {IsActive} \nLicenses Key: {LicenseKey}");
            }
        }
        static void Main(string[] args)
        {
            SoftwareLicense.PrintAvalabelLicenses();
            string[] people = { "Petro", "Mark", "Vlad", "Mariia", "Max", "Olena", "Nikita" };
            SoftwareLicense[] softwareLicenses = new SoftwareLicense[people.Length];
            for (int i = 0; i < people.Length; i++) 
            { 
                softwareLicenses[i] = new SoftwareLicense(people[i]);
                softwareLicenses[i].ShowInfo();
            }
            SoftwareLicense.PrintAvalabelLicenses();
        }
    }
}
