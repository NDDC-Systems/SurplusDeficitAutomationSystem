using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Areas
{
    public class Formulas
    {
        public static double CalculateExpenditureRate(double YTDExpenditures, double contractAmount)
        {
            return YTDExpenditures / contractAmount;
        }

        public static double IdealRate(double contractMonth)
        {
            return (1 / 12) * contractMonth;
        }

        public static double PercentOfWhatSpendingShouldBe(double expenditureRate, double idealRate)
        {
            return expenditureRate / idealRate;
        }

        public static double ProjectedAnnualExpendituresBasedOnStraightLineProjection(double YTDexpenditures, double contractMonth)
        {
            return (YTDexpenditures / contractMonth) * 12;
        }

        public static double ProjectSurplusDeficitBasedOnStraightLineProjection(double contractAmount, double projectedAnnualExpenditures, double levelRate)
        {
            return contractAmount - projectedAnnualExpenditures * levelRate;
        }

        public static double ProjectSurplusDeficitBasedOnMonthlySpending(double contractAmount, double YTDExpenditures, double thisMonthsSpending, double contractMonth)
        {
            return contractAmount - YTDExpenditures - (thisMonthsSpending * (12 - contractMonth));
        }

        public static double ProjectedSurplusDeficitBasedOnAverageMonthlySpending(double contractAmount, double YTDexpenditures, double averageMonthlySpending, double contractMonth)
        {
            return contractAmount - YTDexpenditures - (averageMonthlySpending * (12 - contractMonth));
        }
    }
}
