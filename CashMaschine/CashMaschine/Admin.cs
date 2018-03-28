using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMaschine
{
    public class Admin : IDisplay
    {
        int cash = 10000;
        Users users = new Users();

        public void Log_in()
        {
            string login = "admin";
            string password = "111111";

            Console.WriteLine("Enter your login, please");
            string log = Console.ReadLine();
            Console.WriteLine("Enter your password, please");
            string pass = Console.ReadLine();
            if (log == login && pass == password)
            {
                Console.WriteLine("You are successfuully logged in as admin");
            }
        }


        public void Put()
        {
            Console.WriteLine("Please, enter the sum that you want to put in your score ");
            Int32.TryParse(Console.ReadLine(), out int sum);
            cash = cash + sum;
        }
       // public int CurrentSum { get { return cash; } }
       public void CurrentSum()
        {
            Console.WriteLine($"You have currently {cash}USD at the your score");
        }

        public void Withdraw()
        {
            while (cash > 0)
            {
                Console.WriteLine("Please, enter the sum that you want to withdraw from your score ");
                Int32.TryParse(Console.ReadLine(), out int sum);
                cash = cash - sum;
            }
            if (cash <= 0)
            {
                Console.WriteLine("You have no enough money for withdrow");
            }
        }
        public void DeleteUsers()
        {
            Console.WriteLine("Enter user's ID for deleting");
            Int32.TryParse(Console.ReadLine(), out int ID);
            for(int i = 0; i < users.UsersList.Length; i++)
            {
                 Int32.TryParse(users.UsersList[i, 3], out int cash);
                if (i == ID && cash < 0 )
                {
                    users.UsersList[0, ID] = null;
                    int indx = 0;
                    string[,] New_usersList = new string[3, 5];


                    for (int j = 0; j < New_usersList.Length / 3; j++)
                    {

                        if (!String.IsNullOrEmpty(users.UsersList[1, j]))
                        {

                            New_usersList[0, indx] = users.UsersList[0, j];
                            New_usersList[1, indx] = users.UsersList[1, j];
                            New_usersList[2, indx] = users.UsersList[2, j];

                            indx++;

                        }
                    }
                    users.UsersList = New_usersList;
                }
                else
                {
                    Console.WriteLine("You can not delete user, if he have cash at the score");
                }
            }
        }
    }
}

