using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{   //Класс "Toddler" - наследник класса "Child"
    public class Toddler : Child
    {
        //Свойства 
        public string FavoriteToy { get; set; }
        public string FavoriteColor { get; set; }
        public string FavoriteActivity { get; set; }
        public int NumberOfToys { get; set; }
        //Конструктор с инициализацией по умолчанию свойства NumberOfToys
        public Toddler(string name, int age, string favoriteToy, string favoriteColor, string favoriteActivity) {
            Name = name;
            Age = age;
            FavoriteToy = favoriteToy;
            FavoriteColor = favoriteColor;
            FavoriteActivity = favoriteActivity;
            NumberOfToys = 5; //  Инициализация свойства NumberOfToys
        }
        //Конструктор с указанием числа игрушек
        public Toddler( string name, int age, string favoriteToy, string favoriteColor, string favoriteActivity, int numberOfToys) {
            Name = name;
            Age = age;
            FavoriteToy = favoriteToy;
            FavoriteColor = favoriteColor;
            FavoriteActivity = favoriteActivity;
            NumberOfToys = numberOfToys; // Инициализация свойства NumberOfToys
        }
        //Методы
        public void PlayWithToy()
        {
            Console.WriteLine($"{Name} играет с {FavoriteToy}."); 
        }
        public void ExploreColors()
        {
            Console.WriteLine($"{Name} исследует различные цвета, включяя {FavoriteActivity}.");
        }
        public void EnjoyActivity()
        {
            Console.WriteLine($"{Name} нравится {FavoriteActivity}. ");
        }
        public void HaveSnack()
        {
            Console.WriteLine($"{Name} решил перекусить. ");
        }
        public void ShareToys(Toddler friend)
        {
            Console.WriteLine($"{Name} делится игрушкой с {friend.Name}");                  
        }
        //Переопрделенные методы абстрактного класса 
        public override void AttendClass()
        {
            Console.WriteLine($"{Name} относоится в подготовительную группу");
        }
        public override void Play()
        {
            Console.WriteLine($"{Name} любит играть и веселиться");
        }
        public override void EatSnack()
        {
            Console.WriteLine($"{Name} любит кушать. ");
        }
        public override void TakeNap()
        {
            Console.WriteLine($"{Name} может вздремнуть после игры.");
        }
        public override void DisplayShedule()
        {
            Console.WriteLine($" У {Name} есть ежедневное расписание: посещение занятий, игры, перекус, сон. ");
        }
    }
}
