using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.Simulator.Core.Managers
{
    public class CashDeskManager
    {
        public List<CashDesk> cashDeskList { get; set; }
        public CashDeskManager()
        {
            cashDeskList = new List<CashDesk>();
        }
    }
}
