using System;
namespace _50ShadesOfGravy
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal Courage { get; set; }
        public string FullTeamName
        {
            get
            {
                return $"{Name}\n{SkillLevel}\n{Courage}";
            }
        }
    }
}