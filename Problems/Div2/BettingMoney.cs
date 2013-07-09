using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Div1
{
    class BettingMoney
    {
        public int moneyMade(int[] amounts, int[] centsPerDollar, int finalResult)
        {
            int totalCount = 0;
            for (int i = 0; i < amounts.Length; i++)
            {
                if (i != finalResult)
                {
                    totalCount += amounts[i] * 100;
                }
            }

            if (finalResult < amounts.Length)
            {
                totalCount -= amounts[finalResult] * centsPerDollar[finalResult];
            }

            return totalCount;
        }
    }
}
