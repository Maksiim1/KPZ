using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ManagerCall : SubscriptionCreator
    {
        public override ISubscription CreateSubscription(string subscriptionType)
        {
            Console.WriteLine("Creating subscription through Manager Call...");
            Console.WriteLine("Checking customer eligibility for special offers...");

            switch (subscriptionType.ToLower())
            {
                case "domestic":
                    return new DomesticSubscription();
                case "educational":
                    return new EducationalSubscription();
                case "premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Invalid subscription type");
            }
        }

        protected override void ProcessPayment(ISubscription subscription)
        {
            Console.WriteLine("Offering payment options: Credit Card, Bank Transfer, or Monthly Installments");
            Console.WriteLine($"Processing payment of ${subscription.MonthlyFee} for {subscription.MinimumPeriodMonths} month(s)...");
            Console.WriteLine("Payment processed successfully!");
        }

        protected override void SendConfirmation(ISubscription subscription)
        {
            Console.WriteLine("Sending confirmation via phone call and follow-up email...");
            Console.WriteLine("Confirmation call completed and email sent!");
        }
    }
}
