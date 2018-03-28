using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMaschine
{

    public class Users : IDisplay
    {

        // public string[,] users = new string[3, 5];

        // public int cash = 1000;

        public string[,] UsersList = { { "Victor","222222" , "100000" }, { "Boris", "333333", "100000" }, { "Inna", "444444", "100000" }, { "Lisa", "555555", "100000" }, { "Vasya", "666666", "100000" } };
        int cash;



        public void Log_in()
        {
            string login = "";
            string password = "";
            bool Sign_in = true;
            while (Sign_in)
            {
                Console.WriteLine("Enter your login please");
                login = Console.ReadLine();
                for (int i = 0; i < UsersList.Length / 3; i++)
                {
                    if(login == UsersList[i, 1])
                    {
                        Console.WriteLine("Enter your password, please");
                        password = Console.ReadLine();
                        for (int j = 0; j < UsersList.Length / 3; j++)
                        {
                            if (password == UsersList[j, 2])
                            {
                                Console.WriteLine("You are successfully logged in");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect password. Try again");
                                password = Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect login. Try again");
                        login = Console.ReadLine();
                    }
                }
            }
            Sign_in = false;
        }


        public void Put()
        {
            
            Console.WriteLine("Please, enter the users ID");
            Int32.TryParse(Console.ReadLine(), out int ID);
            for (int i = 0; i < UsersList.Length / 3; i++)
            {
                if (ID == i)
                {
                    for (int j = 0; j < UsersList.Length / 3; j++)
                    {
                        Int32.TryParse(UsersList[j, 3], out cash);
                       
                        Console.WriteLine("Please, enter the sum that you want to put in your score");
                        Int32.TryParse(Console.ReadLine(), out int sum);
                        cash = cash + sum;
                        Console.WriteLine($"You just have put {sum}USD on the your personal score");
                    }
                }
            }
   
        }
        public void CurrentSum()
        {
            
                Console.WriteLine("Please, enter the users ID");
                Int32.TryParse(Console.ReadLine(), out int ID);
                for (int i = 0; i < UsersList.Length / 3; i++)
                {
                    if (ID == i)
                    {
                        for (int j = 0; j < UsersList.Length / 3; j++)
                        {
                            Int32.TryParse(UsersList[j, 3], out int cash);
                        }
                    }
                }
            Console.WriteLine($"You have currently {cash}USD at the your score");

            }
        







        public void Withdraw()
        {
            Console.WriteLine("Please, enter the users ID");
            Int32.TryParse(Console.ReadLine(), out int ID);
            for (int i = 0; i < UsersList.Length / 3; i++)
            {
                if (ID == i)
                {
                    for (int j = 0; j < UsersList.Length / 3; j++)
                    {
                        Int32.TryParse(UsersList[j, 3], out int cash);
                        if (cash > 0)
                        {
                            Console.WriteLine("Please, enter the sum that you want to withdraw from your score");
                            Int32.TryParse(Console.ReadLine(), out int sum);
                            cash = cash - sum;
                        }
                        else
                        {
                            Console.WriteLine("You have no enough money for withdrow");
                        }
                    }
                }
            }
        }

         public void DeleteUsers()
        {
            Console.WriteLine("You have not permissions for this action");
        }
    }
}

