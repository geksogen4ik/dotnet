using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMaschine
{
   public class Menu : Users
    {
      public void MenuStart()
        {
           
            base.Log_in();
            Console.WriteLine("If you want check your score - enter [1]. If you want put cash on your score - enter [2]. If you want withdraw your cash - enter - [3]");
            Int32.TryParse(Console.ReadLine(), out int execute);

            switch (execute)
            {
                case 1:
                    base.CurrentSum();
                    break;
                    Console.WriteLine("If you want check your score - enter [1]. If you want put cash on your score - enter [2]. If you want withdraw your cash - enter - [3]");
                case 2:
                    base.Put();
                    break;
                    Console.WriteLine("If you want check your score - enter [1]. If you want put cash on your score - enter [2]. If you want withdraw your cash - enter - [3]");
                case 3:
                    base.Withdraw();
                    Console.WriteLine("If you want check your score - enter [1]. If you want put cash on your score - enter [2]. If you want withdraw your cash - enter - [3]");
                    break;
            }

        }

    }
}
