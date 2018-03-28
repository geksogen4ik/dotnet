using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMaschine
{
    public interface IDisplay
    {
        void Log_in();
        int CurrentSum { get; } //вывести текущий баланс на экран
        void Put(int sum); //положить баблишко
        void Withdraw(int sum); //снять баблишко
        void DeleteUsers(); //удалить юзера
    }
    
    
}
