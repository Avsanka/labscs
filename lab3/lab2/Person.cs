using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{

    interface IAgeable
    {
        string age();
    }

    class PeopleComparer : IComparer<Person>
    {
        public int Compare(Person? p1, Person? p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Некорректное значение параметра");
            return p1.Name.Length - p2.Name.Length;
        }
    }

    class Person : IAgeable, IComparable
    {

        public delegate void PersonHandler(string message);
        public event PersonHandler? Notify;

        public void Rename(string newName, string newSurname, string newPatronymic)
        {
            this.Name = newName;
            this.Surname = newSurname;
            this.Patronymic = newPatronymic;
            Notify?.Invoke("Data changed");
        }

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

        public string age()
        {
            return (DateTime.Now.Year - birthDate.Year).ToString();
        }

        public int CompareTo(object? o)
        {
            if (o is Person person)
                return Convert.ToInt32(age()) - Convert.ToInt32(person.age());
            else
                throw new ArgumentException("Something is went wrong");
        }


    }

   
}
