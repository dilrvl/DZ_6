using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test
{   //Абстрактный класс "Child"
    public abstract class Child
    {
        public string Name { get; set; }
        public int Age {  get; set; }
        public abstract void AttendClass();
        public abstract void Play();
        public abstract void EatSnack();
        public abstract void TakeNap();
        public abstract void DisplayShedule();
    }
}
