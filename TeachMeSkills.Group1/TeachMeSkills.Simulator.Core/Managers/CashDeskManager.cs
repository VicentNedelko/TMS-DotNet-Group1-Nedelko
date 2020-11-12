using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.Simulator.Core.Managers
{
    public class CashDeskManager
    {
        public List<CashDesk> cashDeskList { get; set; }
        public CashDeskManager(int number)
        {
            cashDeskList = new List<CashDesk>();
            for (int i = 0; i < number; i++)
            {
                cashDeskList.Add(new CashDesk());
            }
        }
    }
}
