using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tumakov.Information;

namespace tumakov
{
    // Класс для описания здания
    public class Building
    {
        private int Number; // Уникальный номер здания
        private double height; // Высота здания
        private int floors; // Этажность
        private int totalApartments; // Общее количество квартир
        private int entrances; // Количество подъездов
        private static int lastNumber = 1; // Последний использованный номер здания
        // Конструктор класса для заполнения полей здания
        public Building(double height, int floors, int totalApartments, int entrances)
        {
            Number = GenerateBuildingNumber();
            this.height = height;
            this.floors = floors;
            this.totalApartments = totalApartments;
            this.entrances = entrances;
        }
        // Приватный метод для генерации уникального номера здания
        private int GenerateBuildingNumber()
        {
            return lastNumber++;
        }
        // Метод для вывода информации о здании
        public void GetBuildingInfo()
        {
            Console.WriteLine("Номер здания:  " + Number);
            Console.WriteLine("Высота " + height + " метров");
            Console.WriteLine("Этажи: " + floors);
            Console.WriteLine("Всего квартир: " + totalApartments);
            Console.WriteLine("Подъездов: " + entrances);
        }
        // Метод для вычисления высоты одного этажа
        public double CalculateFloorHeight()
        {
            return height / floors;
        }
        // Метод для вычисления количества квартир в одном подъезде
        public int CalculateApartmentsEntrance()
        {
            return totalApartments / entrances;
        }
        // Метод для вычисления количества квартир на одном этаже
        public int CalculateApartmentsPerFloor()
        {
            return totalApartments / floors;
        }
    }
    //Создание перечисления для видов банковского счет
    public enum Type
    {
        Current,  // Текущий счет
        Savings   // Сберегательный счет
    }
    // Класс "Information" для счета в банке
    public class Information
    {
        private int AccountNumber; // Номер счета
        private Type Type;      // Тип счета
        private double Balance;         // Баланс счета

        // Метод для заполнения данных о счете
        public void AccountDetails(int AccountNumber, double Balance, Type Type)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
            this.Type = Type;
        }
        // Метод для отображения информации о счете
        public void Display()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}");
            Console.WriteLine($"Тип счета: {Type}");
            Console.WriteLine($"Баланс: {Balance}");
        }
        //создание класса для второго упражнения
        public class Information1
        {
            private int AccountNumber; // Номер счета
            private double Balance; // Баланс
            private Type Type; // Тип банковского счета
            private static int nextAccountNumber = 1; // Статическая переменная для генерации уникального номера
            // Конструктор класса для генерации уникального номера счета
            public Information1(double initialBalance, Type type)
            {
                AccountNumber = GenerateAccountNumber();
                Balance = initialBalance;
                Type = type;
            }
            // Приватный метод для генерации уникального номера счета
            private int GenerateAccountNumber()
            {
                return nextAccountNumber++;
            }
            // Метод для отображения информации о счете
            public void Display1()
            {
                Console.WriteLine($"Номер счета: {AccountNumber}");
                Console.WriteLine($"Тип счета: {Type}");
                Console.WriteLine($"Баланс: {Balance}");
            }
        }
        // создание класса для третьего упражнения 
        public class Information2
        {
            private int AccountNumber; // Номер счета
            private double Balance; // Баланс
            private Type Type; // Тип банковского счета
            private static int nextAccountNumber = 1; // Статическая переменная для генерации уникального номера счета

            // Конструктор класса для генерации уникального номера счета
            public Information2(double initialBalance, Type type)
            {
                AccountNumber = GenerateAccountNumber();
                Balance = initialBalance;
                Type = type;
            }
            // Приватный метод для генерации уникального номера счета
            private int GenerateAccountNumber()
            {
                return nextAccountNumber++;
            }

            // Метод для чтения информации о счете
            public void Display3()
            {
                Console.WriteLine($"Номер счета: {AccountNumber}");
                Console.WriteLine($"Тип счета: {Type}");
                Console.WriteLine($"Баланс: {Balance}");
            }

            // Метод для снятия суммы со счета
            public void Withdraw(double amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Сумма {amount}$ успешно снята со счета.");
                }
                else
                {
                    Console.WriteLine("Недостаточно средств на счете.");
                }
            }

            // Метод для пополнения счета
            public void Deposit(double amount)
            {
                Balance += amount;
                Console.WriteLine($"Сумма {amount}$ успешно зачислена на счет.");
            }
        }
    }
        internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Упражнение 7.1");
            // Создание объекта класса Information
            Information myAccount = new Information();
            // Заполнение данных о счете
            myAccount.AccountDetails(1234567890, 14675.75, Type.Savings);
            // Вывод информации о счете на печать
            myAccount.Display();
        }
        static void Task2()
        {
            Console.WriteLine("Упражнение 7.2");
            // Создание объектов с уникальными номерами счетов
            Information1 account1 = new Information1(1000.50, Type.Savings);
            Information1 account2 = new Information1(5000.75, Type.Current);
            // Вывод информации о счетах
            account1.Display1();
            account2.Display1();
        }
        static void Task3()
        {
            Console.WriteLine("Упражнение 7.3");
            // Создание объекта класса BankAccount
            Information2 myAccount = new Information2(2342.0, Type.Current);
            // Вывод информации о счете
            Console.WriteLine("Исходные детали счета:");
            myAccount.Display3();
            Console.WriteLine();
            // Снятие и пополнение счета
            myAccount.Withdraw(500.0);
            myAccount.Deposit(1000.0);
            // Вывод обновлённой информации о счете
            Console.WriteLine("Обновленные детали счета:");
            myAccount.Display3();
        }
        static void Task4()
        {
            Console.WriteLine("Домашнее задание 7.1");
            // Создание объекта класса Building
            Building myBuilding = new Building(50.5, 10, 50, 2);
            // Вывод информации о здании
            myBuilding.GetBuildingInfo();
            // Вычисление и вывод характеристик здания
            Console.WriteLine("Высота одного этажа: " + myBuilding.CalculateFloorHeight() + " метров");
            Console.WriteLine("Квартир в одном подъезде: " + myBuilding.CalculateApartmentsEntrance());
            Console.WriteLine("Квартир на одном этаже: " + myBuilding.CalculateApartmentsPerFloor());
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}
