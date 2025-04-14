using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DomesticSubscription : ISubscription
    {
        public double MonthlyFee => 9.99;
        public int MinimumPeriodMonths => 1;
        public List<string> Channels { get; } = new List<string>
        {
            "Local News",
            "Basic Entertainment",
            "Local Sports"
        };

        public List<string> AdditionalFeatures { get; } = new List<string>
        {
            "SD Quality",
            "Single Device"
        };

        public void DisplayDetails()
        {
            Console.WriteLine("Domestic Subscription Details:");
            Console.WriteLine($"Monthly Fee: ${MonthlyFee}");
            Console.WriteLine($"Minimum Period: {MinimumPeriodMonths} month(s)");
            Console.WriteLine("Channels:");
            foreach (var channel in Channels)
            {
                Console.WriteLine($" - {channel}");
            }
            Console.WriteLine("Additional Features:");
            foreach (var feature in AdditionalFeatures)
            {
                Console.WriteLine($" - {feature}");
            }
        }
    }
}
