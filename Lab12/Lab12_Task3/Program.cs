namespace Lab12_Task3
{
    internal class Program
    {

        public class SpaceShip
        {
            public string name;
            public int crew, fuelLevel, shieldStrength;


            public SpaceShip(string name, int crew, int fuelLevel, int shieldStrength) //з усіма параметрами
            {
                this.name = name;
                this.crew = crew;
                this.fuelLevel = fuelLevel;
                this.shieldStrength = shieldStrength;
            }


            public SpaceShip(string name) : this(name, 5, 50, 75) { } //лише назву приймає
            public SpaceShip(string name, int crew) : this(name, crew, 50, 75) { } //лише назва і екіпаж
            public SpaceShip(string name, int crew, int fuelLevel) : this(name, crew, fuelLevel, 75) { } //назва екіпаж і паливо

            public SpaceShip(SpaceShip otherSpaceShip) //клон
            {
                this.name = otherSpaceShip.name + "Клон";
                this.crew = otherSpaceShip.crew;
                this.fuelLevel = otherSpaceShip.fuelLevel;
                this.shieldStrength = otherSpaceShip.shieldStrength;
            }
            ~SpaceShip()
            {
                Console.WriteLine($"Space Ship {name} disappeared from the radar");
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {name} \nCrew: {crew} \nFuelLevel: {fuelLevel}% \nShieldStrength: {shieldStrength}%");
            }

            public void TakeDamage(int damage)
            {
                shieldStrength -= damage;
                if (shieldStrength < 0) shieldStrength = 0;
            }
        }
        static void Main(string[] args)
        {
            SpaceShip spaceShip1 = new SpaceShip("Max");
            spaceShip1.DisplayInfo();

            SpaceShip spaceShip2 = new SpaceShip("Tree");
            spaceShip2.TakeDamage(10);
            spaceShip2.DisplayInfo();
        }
    }
}
