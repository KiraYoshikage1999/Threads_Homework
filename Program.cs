using System.Diagnostics;

namespace Threads_Homework
{

    internal class Program
    {
       
        static void Main(string[] args)
        {

            //Task 1 
            /*
            User user1 = new User { name = "sss" };
            User user2 = new User { name = "sss" };
            User user3 = new User { name = "sss" };
            User user4 = new User { name = "sss" };
            User user5 = new User { name = "sss" };

            List<User> users = new List<User> { user1, user2, user3, user4, user5 };
            Thread thread = new Thread(() => ThreadMethod(users));*/

            //Task 2
            /*
            Bank bank1 = new Bank { Name = "Alpha", Money = 1000, Percent = 5 };
            Bank bank2 = new Bank { Name = "Beta", Money = 2000, Percent = 7 };
            Bank bank3 = new Bank { Name = "Gamma", Money = 3000, Percent = 10 };

            List<Bank> banks = new List<Bank> { bank1, bank2, bank3 };

            Thread thread = new Thread(() => ThreadMethod(banks));
            thread.Start();
            thread.Join();
            */
            //Task 3
            Random random = new Random();

            Console.WriteLine("Game 'Time - no time'");
            Console.WriteLine("When you see signal 'Now', enter of key you want");
            //Console.WriteLine("Enter to start");
            while (true)
            {
                
                int delay = random.Next(2000, 5000); 
                Thread.Sleep(delay);

                Console.WriteLine("NOW!");

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                Console.ReadKey(); 
                stopwatch.Stop();

                Console.WriteLine($"Time of your reaction: {stopwatch.ElapsedMilliseconds} ms");

                Console.WriteLine("Try again? (y/n)");
                string answer = Console.ReadLine()?.ToLower();

                if (answer != "y")
                {
                    Console.WriteLine("Thanks for game!");
                    break;
                }  
            }
        }



        public static void ThreadMethod(List<User> users)
        {

            foreach (User user in users)
            {
                user.ToString();
            }
        }

        public static void ThreadMethod(List<Bank> banks)
        {
            foreach (Bank bank in banks)
            {
                Console.WriteLine(bank.ToString());

                
                bank.Money += 500;
                bank.Percent += 1;
            }
        }
    }
}
