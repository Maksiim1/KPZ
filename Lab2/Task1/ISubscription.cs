using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface ISubscription
    {
        double MonthlyFee { get; }
        int MinimumPeriodMonths { get; }
        List<string> Channels { get; }
        List<string> AdditionalFeatures { get; }
        void DisplayDetails();
    }
}
