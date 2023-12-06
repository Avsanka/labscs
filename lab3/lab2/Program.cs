using System;

namespace lab2
{
    class Program
    {      
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "Никита";
            person.Surname = "Адаев";
            person.Patronymic = "Евгеньевич";
            person.BirthDate = "09.03.2003";
            Console.WriteLine("{0} {1} {2}, Дата рождения: {3}({4} лет)", person.Name, person.Surname, person.Patronymic, person.BirthDate, person.age());
            Console.WriteLine();
            /////



            Client client1 = new Client("Адаев", "Никита", "Евгеньевич", "09.03.2003", 10);

            var client2 = (Client)client1.Clone();
            var client3 = (Client)client2.Clone();

            showClient(client1);
            showClient(client2);
            showClient(client3);
            Console.WriteLine();

            //можно было бы и так:
            //var client = client1;
            //но классы имеют ссылочную структуру
            ///////


            Engineer engineer = new Engineer("Никита", "Адаев", "Евгеньевич", "09.03.1998", 20000, "Мастер производства", 1);
            showEngineer(engineer);

            engineer.increaseSalary(5000);
            showEngineer(engineer);
            engineer.decreaseSalary(2000);
            showEngineer(engineer);
            engineer.changeClass(3);
            showEngineer(engineer);

            Console.ReadLine();

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

    }
}
