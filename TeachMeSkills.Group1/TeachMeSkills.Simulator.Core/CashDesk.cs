using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TeachMeSkills.Simulator.Core.Enums;

namespace TeachMeSkills.Simulator.Core
{
    public class CashDesk
    {
        public Speed Speed { get; set; }
        private static Semaphore semaphore = new Semaphore(0, 5);
        private int _count;
        public CashDesk()
        {
            Thread thread = new Thread(Service);
            switch(new Random().Next(1, 3))
            {
                case 1:
                    Speed = Speed.Slow;
                    break;
                case 2:
                    Speed = Speed.Normal;
                    break;
                case 3:
                    Speed = Speed.Fast;
                    break;
            }
        }
        public void Service()
        {

        }
    }
}
