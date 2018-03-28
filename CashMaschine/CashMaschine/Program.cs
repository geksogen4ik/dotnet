using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMaschine
{
    class Program 
  
    {
       
        static void Main(string[] args)
        {
            AdminMenu admin = new AdminMenu();
            Menu user = new Menu();
            admin.AdminMenuStart();
            user.MenuStart();
            
        }
    }
}
