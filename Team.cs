using System;
using System.Collections.Generic;
namespace _50ShadesOfGravy
{
    public class Team
    {
        public List<TeamMember> TeamList { get; set; }

        public Team()
        {

            TeamList = new List<TeamMember>();
        }
        public bool AddTeamMember()
        {
            string name = Prompt("First Name: ");
            if (String.IsNullOrEmpty(name))
            {
                return false;
            }
            int skillLevel = Int32.Parse(Prompt("What is your skill level: "));
            decimal courage = decimal.Parse(Prompt("What is your courage between 0 and 2.0: "));
            TeamMember newTeamMember = new TeamMember()
            {
                Name = name,
                SkillLevel = skillLevel,
                Courage = courage,
            };


            TeamList.Add(newTeamMember);

            // Console.WriteLine(newTeamMember.Name + " has a skill level of: " + newTeamMember.SkillLevel + " and a Courage Factor of: " + newTeamMember.Courage + ". Current Amount of Members:  " + newTeamMember.NumOfMembers);

            foreach (TeamMember member in TeamList)
            {
                Console.WriteLine(member.Name + " has a skill level of: " + member.SkillLevel + " and a Courage Factor of: " + member.Courage + ". Current Amount of Members: " + member.NumOfMembers);
            }

            return true;
        }
        public string Prompt(string promptText)
        {
            Console.Write(promptText);
            string response = Console.ReadLine();
            Console.WriteLine();
            return response;
        }
    }
}