using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Employee : Person
    {
        private int salary;
        public int Salary { get { return salary; } set { salary = value; } }

        private string post;
        public string Post { get { return post; } set { post = value; } }

    }

}
