using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class WebSite : SubscriptionCreator
    {
        public override ISubscription CreateSubscription(string subscriptionType)
        {
            Console.WriteLine("Creating subscription through Website...");
            Console.WriteLine("Applying online discount of 5%...");

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

        protected override void SendConfirmation(ISubscription subscription)
        {
            Console.WriteLine("Sending email confirmation...");
            Console.WriteLine("Email sent successfully!");
        }
    }
}
