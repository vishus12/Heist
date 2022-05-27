using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("----------------");
            Console.WriteLine("Enter Difficulty Level Of The Bank");
            int DifficultyLvl = int.Parse(Console.ReadLine());


            List<TeamMember> teamList = new List<TeamMember>();
           

            Console.Write("What is your team member's name? ");
            string name = Console.ReadLine();
            Console.Write("What is the skill level of your member? ");
            int skill = int.Parse(Console.ReadLine());
            Console.Write("What is your team member's courage factor (0.0 - 2.0) ");
            decimal courage = decimal.Parse(Console.ReadLine());

            while (courage < 0 || courage > 2)
            {
                Console.Write("What is your team member's courage factor (0.0 - 2.0) ");
                courage = decimal.Parse(Console.ReadLine());
            }

            TeamMember firstMember = new TeamMember(name, skill, courage);
            teamList.Add(firstMember);

            Team newTeam = new Team(teamList);

            int skillSum = 0;
            skillSum += skill;

            newTeam.Description();

            while(true)
            {
                Console.Write("What is your team member's name? ");
                name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name)) 
                {
                    break;
                }
                else 
                {
                    Console.Write("What is the skill level of your member? ");
                    skill = int.Parse(Console.ReadLine());
                    skillSum += skill; 
                    Console.Write("What is your team member's courage factor (0.0 - 2.0) ");
                    courage = decimal.Parse(Console.ReadLine());
                while (courage < 0 || courage > 2)
                {
                    Console.Write("What is your team member's courage factor (0.0 - 2.0) ");
                    courage = decimal.Parse(Console.ReadLine());
                }
                TeamMember thisMember = new TeamMember(name, skill, courage);
                teamList.Add(thisMember);
                newTeam.Description();
                Console.WriteLine($"Combined skill level is {skillSum}");
                }
            }
            Console.Write("How many trials would you like to try?");
            int trials = int.Parse(Console.ReadLine());

            int Report = 0;
        
        
            for(int i = 0; i < trials; i++)
             {
                  Random rand = new Random();
            int randomNum = rand.Next(-10 , 11);


            Bank thisBank = new Bank( DifficultyLvl + randomNum);
            Console.WriteLine($"The bank's difficulty level is {thisBank.Difficulty}");
            if (skillSum >= thisBank.Difficulty){
                Console.WriteLine("You robbed the bank!");
                Report++; 
            }
            else {
                Console.WriteLine("You failed and you are a failure.");
            }
    };
            Console.WriteLine($" You were successful {Report} amount of times!");
            TeamMember member = new TeamMember(name, skill, courage);
            newTeam.Description();
        }
    }
}