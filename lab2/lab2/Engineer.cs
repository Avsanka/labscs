using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Engineer : Employee
    {
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
    }
}
