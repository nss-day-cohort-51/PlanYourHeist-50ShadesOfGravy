using System;
namespace _50ShadesOfGravy
{
    public class TeamMember
    {

        private static int _teamIncrementer = 1;

        public TeamMember()
        {
            NumOfMembers = _teamIncrementer++;
        }
        public int NumOfMembers { get; set; }
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