using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VIDEO PROVIDER SUBSCRIPTION SYSTEM\n");

            Console.WriteLine("WEBSITE SUBSCRIPTION CREATION");
            SubscriptionCreator websiteCreator = new WebSite();
            ISubscription domesticFromWebsite = websiteCreator.PurchaseSubscription("domestic");
            domesticFromWebsite.DisplayDetails();
            Console.WriteLine();

            Console.WriteLine("MOBILE APP SUBSCRIPTION CREATION");
            SubscriptionCreator mobileAppCreator = new MobileApp();
            ISubscription educationalFromMobileApp = mobileAppCreator.PurchaseSubscription("educational");
            educationalFromMobileApp.DisplayDetails();
            Console.WriteLine();

            Console.WriteLine("MANAGER CALL SUBSCRIPTION CREATION");
            SubscriptionCreator managerCallCreator = new ManagerCall();
            ISubscription premiumFromManagerCall = managerCallCreator.PurchaseSubscription("premium");
            premiumFromManagerCall.DisplayDetails();

            Console.WriteLine("\nEND OF DEMONSTRATION");
        }
    }
}