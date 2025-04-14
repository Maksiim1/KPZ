using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class PremiumSubscription : ISubscription
    {
        public double MonthlyFee => 19.99;
        public int MinimumPeriodMonths => 12;
        public List<string> Channels { get; } = new List<string>
        {
            "HBO",
            "Showtime",
            "Netflix",
            "Disney+",
            "Sports Premium",
            "All Local Channels"
        };

        public List<string> AdditionalFeatures { get; } = new List<string>
        {
            "4K Quality",
            "Multiple Devices (up to 4)",
            "Unlimited Downloads",
            "No Ads",
            "Exclusive Content"
        };

        public void DisplayDetails()
        {
            Console.WriteLine("Premium Subscription Details:");
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
