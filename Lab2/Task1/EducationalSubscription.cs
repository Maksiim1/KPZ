using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class EducationalSubscription : ISubscription
    {
        public double MonthlyFee => 4.99;
        public int MinimumPeriodMonths => 6;
        public List<string> Channels { get; } = new List<string>
        {
            "Discovery Channel",
            "History Channel",
            "National Geographic",
            "Learning Hub"
        };

        public List<string> AdditionalFeatures { get; } = new List<string>
        {
            "HD Quality",
            "Offline Downloads",
            "No Ads",
            "Student Discount"
        };

        public void DisplayDetails()
        {
            Console.WriteLine("Educational Subscription Details:");
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
