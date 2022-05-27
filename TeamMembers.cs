using System;

namespace Heist
{
  public class TeamMember 
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public decimal CourageLevel { get; set; }

    public TeamMember(string name, int skill, decimal courage)
    {
      Name = name;
      SkillLevel = skill;
      CourageLevel = courage;
    }

    public override string ToString()
    {
      return $"Team mate {Name}, your skill level is {SkillLevel} and your courage level is {CourageLevel}!";
    }

  } 
}