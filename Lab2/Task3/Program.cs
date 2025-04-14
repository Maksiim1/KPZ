using System;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    public sealed class Authenticator
    {
        private static volatile Authenticator _instance;

        private static readonly object _lock = new object();

        public readonly Guid Id;

        private Authenticator()
        {
            Id = Guid.NewGuid();
            Console.WriteLine($"Created new Authenticator instance with Id: {Id}");
        }

        public static Authenticator GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }

            return _instance;
        }

        public bool Authenticate(string username, string password)
        {
            Console.WriteLine($"Authenticator (Id: {Id}) verifying user: {username}");
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }
    }
    public class AuthenticatorClient
    {
        public static Authenticator GetAuthenticatorInstance()
        {
            return Authenticator.GetInstance();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Singleton pattern for Authenticator class\n");

            Console.WriteLine("1. Single thread verification:");
            var auth1 = Authenticator.GetInstance();
            var auth2 = Authenticator.GetInstance();

            Console.WriteLine($"Instance 1 Id: {auth1.Id}");
            Console.WriteLine($"Instance 2 Id: {auth2.Id}");
            Console.WriteLine($"Same instance: {auth1 == auth2}\n");

            Console.WriteLine("2. Client class verification:");
            var clientAuth = AuthenticatorClient.GetAuthenticatorInstance();
            Console.WriteLine($"Client instance Id: {clientAuth.Id}");
            Console.WriteLine($"Same instance: {auth1 == clientAuth}\n");

            Console.WriteLine("3. Multi-thread verification:");
            var tasks = new Task[5];

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    var threadAuth = Authenticator.GetInstance();
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} got Authenticator with Id: {threadAuth.Id}");
                    threadAuth.Authenticate($"user{Thread.CurrentThread.ManagedThreadId}", "password");
                });
            }

            Task.WaitAll(tasks);

            Console.WriteLine("\nAll verifications completed - instance is the same everywhere!");
            Console.ReadKey();
        }
    }
}