using System;
//using System.Collections.Generic;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person nikita = new Person();
            nikita.Name = "Nikita";
            nikita.Surname = "Adaev";
            nikita.Patronymic = "Evgenevich";
            nikita.BirthDate = "09.03.1999";

            Person andrey = new Person();
            andrey.Name = "Andryuxa";
            andrey.Surname = "Petrov";
            andrey.Patronymic = "Andreevich";
            andrey.BirthDate = "01.01.2001";

            Person ivan = new Person();
            ivan.Name = "Ivan";
            ivan.Surname = "Sidorov";
            ivan.Patronymic = "Petrovich";
            ivan.BirthDate = "01.02.2000";

            Person[] people = { nikita, andrey, ivan };
            Array.Sort(people, new PeopleComparer());

            foreach (Person p in people)
            {
                Console.WriteLine("{0} {1} {2}, Дата рождения: {3}({4} лет)", p.Name, p.Surname, p.Patronymic, p.BirthDate, p.age());
            }

            Console.WriteLine();

            Client client1 = new Client("Nikita", "Adaev", "Evgenevich", "09.03.2003", 3);
            Client client2 = new Client("Andrey", "Petrov", "Petrovich", "10.01.2008", 5);
            Client client3 = new Client("Ivan", "Ivanov", "Alexandrovich", "09.01.1999", 8);
            Client client4 = new Client("Oleg", "Sidorov", "Ivanovich", "15.10.2002", 1);
            Client client5 = new Client("Alexandr", "Morozov", "Alexeevich", "11.12.1995", 2);

            Client[] clients = { client1, client2, client3, client4, client5 };
            Array.Sort(clients);

            foreach (Client cl in clients)
            {
                showClient(cl);
            }

            Console.ReadKey();

            /////
            ///

            Console.Clear();




            Engineer engineer1 = new Engineer("Ivan", "Petrov", "Petrovich", "09.03.2001", 20000, "Worker", 1);
            Engineer engineer2 = new Engineer("Georgiy", "Petrosyan", "Sergeevich", "19.05.2000", 30000, "Worker", 2);
            Engineer engineer3 = new Engineer("Violetta", "Kotova", "Alexeevna", "13.11.2004", 50000, "Worker", 3);
            Engineer engineer4 = new Engineer("Viktor", "Maligyn", "Alexeevich", "11.01.1990", 40000, "Worker", 2);
            Engineer engineer5 = new Engineer("Adelaida", "Ivanova", "Alexandrovna", "10.07.2004", 120000, "Worker", 3);

            MyList<Engineer> myList = new MyList<Engineer>();

            myList.Add(engineer1);
            myList.Add(engineer2);
            myList.Add(engineer4);
            myList.Add(engineer5);
            myList.Display("Список: ");

            myList.Insert(2, engineer3);
            myList.Display("Вставка инженера: ");

            myList.Sort(new PeopleComparer());
            myList.Display("Сортировка по длине имени");

            myList.Remove(engineer3);
            myList.Remove(engineer4);
            myList.Display("Удаление 2 инженеров");

            myList.Clear();
            myList.Display("Он пустой");

            Console.ReadKey();
            
            ////
            ///

            
            
            Console.Clear();

            Person newPerson = new Person();
            newPerson.Name = "Name";
            newPerson.Surname = "Surname";
            newPerson.Patronymic = "Patronymic";
            newPerson.BirthDate = "09.03.2003";

            Console.WriteLine("{0} {1} {2}, Дата рождения: {3}({4} лет) \n", newPerson.Name, newPerson.Surname, newPerson.Patronymic, newPerson.BirthDate, newPerson.age());


            newPerson.Notify += DisplayMessage;
            newPerson.Rename("Имя", "Фамилия", "Отчество");

            Console.WriteLine("\n{0} {1} {2}, Дата рождения: {3}({4} лет)", newPerson.Name, newPerson.Surname, newPerson.Patronymic, newPerson.BirthDate, newPerson.age());

            Console.ReadKey();




            Console.Clear();

            Client client = new Client("Name", "Surname", "Patronymic", "09.03.2003", 8);
            client.Notify += DisplayMessage;
            showClient(client);

            Console.WriteLine();

            client.IncreaseLoyalty();
            showClient(client);

            Console.WriteLine();

            client.IncreaseLoyalty();
            showClient(client);

            Console.WriteLine();
            
            client.IncreaseLoyalty();
            showClient(client);




            Console.ReadKey();
            Console.Clear();

            engineer1.Notify += DisplayMessage;
            showEngineer(engineer1);
            Console.WriteLine();

            engineer1.changeClass(2);

            showEngineer(engineer1);
            Console.WriteLine();

            engineer1.changeClass(5);
            showEngineer(engineer1);

            Console.ReadKey();
            Console.Clear();





            Employee emp = new Employee();
            emp.Name = "name";
            emp.Surname = "surname";
            emp.Patronymic = "patronymic";
            emp.BirthDate = "09.03.2000";
            emp.Post = "Worker";
            emp.Salary = 20000;

            emp.Notify += DisplayMessage;


            emp.increaseSalary(10000);
            emp.decreaseSalary(5000);

        }





        public static void showClient(Client cl)
        {
            Console.WriteLine("{0} {1} {2}, {3}({5} лет), Уровень доверия:{4}", cl.Name, cl.Surname, cl.Patronymic, cl.BirthDate, cl.LoyaltyLevel, cl.age());
        }

        public static void showEngineer(Engineer engineer)
        {
            Console.WriteLine("{0} {1} {2}, {3}({4} лет), Зарплата: {5}, Должность: {6}, Класс: {7}", engineer.Name,
                engineer.Surname, engineer.Patronymic, engineer.BirthDate, engineer.age(), engineer.Salary, engineer.Post, engineer.EngineerClass);
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
