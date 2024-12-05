using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public int ExperienceYears { get; set; }

        // Конструктор класса "Caregiver"
        public Teacher(string name, int age, string role, int experienceYears)
        {
            Name = name;
            Age = age;
            Role = role;
            ExperienceYears = experienceYears;
        }
        public void SuperviseChildren()
        {
            Console.WriteLine($"{Name} наблюдает за детьми во время игрового времени.");
        }
        public void EngageInActivities()
        {
            Console.WriteLine($"{Name} проводит образовательные мероприятия с детьми.");
        }
        public void CommunicateWithParents()
        {
            Console.WriteLine($"{Name} регулярно общается с родителями, предоставляя обновления об успехах детей.");
        }

        public void HandleBehavioralIssues()
        {
            Console.WriteLine($"{Name} решает любые поведенческие проблемы, которые могут возникнуть среди детей.");
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Привет, мое имя -  {Name}. Я {Role} с {ExperienceYears}  годами опыта в области воспитания. ");
        }
    }
}
