using System;

namespace _50ShadesOfGravy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.WriteLine("Please Enter a Team Member's Name");
            string memberName = Console.ReadLine();

            Console.WriteLine("Enter Team Members skill level");
            int skillLevel = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Team Members courage factor between 0.0 and 2.0");
            decimal courageFactor = decimal.Parse(Console.ReadLine());

            TeamMember newMember = new TeamMember()
            {
                Name = memberName,
                SkillLevel = skillLevel,
                Courage = courageFactor
            };

            Console.WriteLine($"{newMember.Name} has a skill level of {newMember.SkillLevel} and Courage Factor of {newMember.Courage}");


        }
    }
}
