using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{

    interface IEngClassable 
    {
        public void changeClass(int newClass);
    }
    class Engineer : Employee, IEngClassable
    {
        public delegate void EngineerHandler(string message);
        public event EngineerHandler? Notify;


        private int engineerClass;

        public int EngineerClass { get { return engineerClass; } 
            set 
            {   if (value < 1)
                    engineerClass = 1;
                else if (value > 3)
                    engineerClass = 3;
                else
                    engineerClass = value;
            } 
        }

        public Engineer(string name, string surname, string patronymic, string birthdate, int salary, string post, int engclass) {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.BirthDate = birthdate;
            this.Salary = salary;
            this.Post = post;
            this.EngineerClass = engclass;
        }

        public void changeClass(int newClass)
        {
            if (newClass > 0 && newClass < 4)
            {
                EngineerClass = newClass;
                Notify?.Invoke("Class changed");
            }
            else
                Notify.Invoke("Class has to be between 1 and 3");
        }
    }
}
