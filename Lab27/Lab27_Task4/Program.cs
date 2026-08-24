namespace Lab27_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            ICombatSystem combatSystem = character;
            combatSystem.Action();
            IBuildSystem buildSystem = character;
            buildSystem.Action();
        }
    }
}
