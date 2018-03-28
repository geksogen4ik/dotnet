using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMaschine
{
    public class AdminMenu : Admin
    {
        public void AdminMenuStart()
        {
            Console.WriteLine("If you want check your score - enter [1]. If ypu want put cash on your score - enter [2]. If you want withdraw your cash - enter [3]. If you want delete user - enter [4]");
            Int32.TryParse(Console.ReadLine(), out int execute);

            switch (execute)
            {
                case 1:
                    base.CurrentSum();
                    break;
                    Console.WriteLine("If you want check your score - enter [1]. If ypu want put cash on your score - enter [2]. If you want withdraw your cash - enter - [3]");
                case 2:
                    base.Put();
                    break;
                    Console.WriteLine("If you want check your score - enter [1]. If ypu want put cash on your score - enter [2]. If you want withdraw your cash - enter - [3]");
                case 3:
                    base.Withdraw();
                    Console.WriteLine("If you want check your score - enter [1]. If ypu want put cash on your score - enter [2]. If you want withdraw your cash - enter - [3]");
                    break;
                case 4:
                    base.DeleteUsers();
                    Console.WriteLine("If you want check your score - enter [1]. If ypu want put cash on your score - enter [2]. If you want withdraw your cash - enter - [3]");
                    break;
            }
        }
    }
}
