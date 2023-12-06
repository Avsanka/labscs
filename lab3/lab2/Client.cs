using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Client : Person, ICloneable
    {

        private int loyaltyLevel;

        public int LoyaltyLevel
        {
            get { return loyaltyLevel; }

            set
            {
                if (value < 0)
                    loyaltyLevel = 0;
                else if (value > 10)
                    loyaltyLevel = 10;
                else loyaltyLevel = value;
            }

        }
        public Client(string name, string surname, string patronymic, string birthdate, int loyalty)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.BirthDate = birthdate;
            this.LoyaltyLevel = loyalty;
        }

        public object Clone()
        {
            return new Client(Name, Surname, Patronymic, BirthDate, LoyaltyLevel);
        }

    }
}
