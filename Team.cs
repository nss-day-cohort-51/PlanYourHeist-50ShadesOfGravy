using System;
using System.Collections.Generic;
namespace _50ShadesOfGravy
{
    public class Team
    {
        public List<TeamMember> TeamList { get; set; }
        private static int _TeamIncrementer = 0;
        public int NumOfMembers { get; set; }
        public Team()
        {
            NumOfMembers = _TeamIncrementer++;
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
                Courage = courage
            };
            Console.WriteLine(newTeamMember.Name + " " + newTeamMember.SkillLevel + " " + newTeamMember.Courage + " " + NumOfMembers);
            TeamList.Add(newTeamMember);
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