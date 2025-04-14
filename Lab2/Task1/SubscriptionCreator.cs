using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class SubscriptionCreator
    {
        public abstract ISubscription CreateSubscription(string subscriptionType);

        public ISubscription PurchaseSubscription(string subscriptionType)
        {
            Console.WriteLine($"Attempting to purchase {subscriptionType} subscription through {GetType().Name}...");

            ISubscription subscription = CreateSubscription(subscriptionType);

            ProcessPayment(subscription);
            SendConfirmation(subscription);

            return subscription;
        }

        protected virtual void ProcessPayment(ISubscription subscription)
        {
            Console.WriteLine($"Processing payment of ${subscription.MonthlyFee} for {subscription.MinimumPeriodMonths} month(s)...");
            Console.WriteLine("Payment processed successfully!");
        }

        protected virtual void SendConfirmation(ISubscription subscription)
        {
            Console.WriteLine("Sending confirmation...");
            Console.WriteLine("Confirmation sent successfully!");
        }
    }
}
