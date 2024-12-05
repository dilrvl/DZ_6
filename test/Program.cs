using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание объекта класса Toddler
            Toddler toddler1 = new Toddler("Аделя", 2, "Плюшевый медведь", "Синий", "Рисование");
            //Вызов методов для малыша
            toddler1.AttendClass();
            toddler1.Play();
            toddler1.EatSnack();
            toddler1.TakeNap();
            toddler1.DisplayShedule();
            Console.WriteLine($"{toddler1.Name}  {toddler1.Age} года.");
            Console.WriteLine($"{toddler1.Name} имеет {toddler1.NumberOfToys} игрушек.");
            //Создание объекта класса Preshooler
            Preshooler preschooler1 = new Preshooler("Алиса", 5, "Блоки", "Цветные книги", "Голубой", "Раскрашивать");
            // Вызов методов для дошкольника
            preschooler1.AttendClass();
            preschooler1.Play();
            preschooler1.EatSnack();
            preschooler1.TakeNap();
            preschooler1.DisplayShedule();
            // Создание объекта класса Teacher
            Teacher teacher1 = new Teacher("Наталья", 28, "Воспитатель", 5);
            teacher1.SuperviseChildren();
            teacher1.EngageInActivities();
            teacher1.CommunicateWithParents();
            teacher1.HandleBehavioralIssues();
            teacher1.IntroduceYourself();
        }
    }
}
