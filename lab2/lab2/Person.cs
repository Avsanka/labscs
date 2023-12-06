using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Person
    {
        private string name;

        public string Name { get { return name; } set { name = value; } }

        private string surname;

        public string Surname { get { return surname; } set { surname = value; } }

        private string patronymic;

        public string Patronymic { get { return patronymic; } set { patronymic = value; } }

        private DateTime birthDate;

        public string BirthDate
        {
            get
            {
                return birthDate.ToString("dd MM yyyy");
            }
            set { birthDate = Convert.ToDateTime(value); }
        }
    }

   
}
