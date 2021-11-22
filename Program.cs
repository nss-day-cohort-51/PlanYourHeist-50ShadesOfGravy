using System;
namespace _50ShadesOfGravy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Team team = new Team();
            while (true)
            {
                bool keepGoing = team.AddTeamMember();
                if (!keepGoing)
                {
                    break;
                }
            }
        }
    }
}
