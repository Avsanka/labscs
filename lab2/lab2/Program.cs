using System;

namespace lab2
{
    class Program
    {      
        static void Main(string[] args)
        {
            Client client = new Client("Nikita", "Adaev", "Evgenevich", "09.03.2003", 143213);

            Console.WriteLine(client.Name + " " + client.Surname + " " + client.Patronymic + " " + client.BirthDate + " " + client.LoyaltyLevel);


            Engineer engineer = new Engineer("Nikita", "Adaev", "Evgenevich", "09.03.2003", 100000, "Начальник отдела разработок", 3);

            Console.WriteLine(engineer.Name + " " + engineer.Surname + " " + engineer.Patronymic + " " + engineer.BirthDate + " " + engineer.Salary + " " + engineer.Post + " " + engineer.EngineerClass);
            Console.ReadLine();



        }
    }
}
