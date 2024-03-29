﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{

    interface ISalary
    {
        void increaseSalary(int num);
        void decreaseSalary(int num);
    }
    class Employee : Person, ISalary
    {
        private int salary;
        public int Salary { get { return salary; } set { salary = value; } }

        private string post;
        public string Post { get { return post; } set { post = value; } }

        public void increaseSalary(int num)
        {
            salary += num;
        }

        public void decreaseSalary(int num)
        {
            salary -= num;
        }
    }

}
