using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Preshooler : Child
    {
        //Свойства 
        public string FavoriteToy { get; set; }
        public string FavoriteBook { get; set; }
        public string FavoriteColor { get; set; }
        public string FavoriteActivity { get; set; }
        //Конструктор с инициализацией свойств
        public Preshooler(string name, int age, string favoriteToy, string favoriteBook, string favoriteColor, string favoriteActivity)
        {
            Name = name;
            Age = age;
            FavoriteToy = favoriteToy;
            FavoriteBook = favoriteBook;
            FavoriteColor = favoriteColor;
            FavoriteActivity = favoriteActivity;
        }
        //Конструктор с изменением одного свойства
        public Preshooler(string name, int age, string favoriteToy, string favoriteColor, string favoriteActivity)
        {
            Name = name;
            Age = age;
            FavoriteToy = favoriteToy;
            FavoriteBook = "ABC BOOK";
            FavoriteColor = favoriteColor;
            FavoriteActivity = favoriteActivity;
        }
        //Методы 
        public void ReadBook()
        {
            Console.WriteLine($"{Name} любить читать книгу {FavoriteBook}");
        }
        public void DrawPicture()
        {
            Console.WriteLine($"{Name} любит рисовать {FavoriteColor} карандашом. ");
        }
        public void Havesnack()
        {
            Console.WriteLine($"{Name} ест полезный снэк во время еды. ");
        }
        public void ShareToys(Preshooler friend)
        {
            Console.WriteLine($"{Name} делится игрушками с {friend.Name}");
        }
        //Переопрделенные методы
        public override void AttendClass()
        {
            Console.WriteLine($"{Name} относится к дошкольникам");
        }
        public override void Play()
        {
            Console.WriteLine($"{Name} любит играть и узнавать новые вещи.");
        }
        public override void EatSnack()
        {
            Console.WriteLine($"{Name} любит есть с друзьями. ");
        }
        public override void TakeNap()
        {
            Console.WriteLine($" У {Name} короткий сон после обеда. ");
        }
        public override void DisplayShedule()
        {
            Console.WriteLine($" У {Name} eсть ежедневное расписание: посещение занятий, игры, перекус, сон. ");
        }
    }
}
