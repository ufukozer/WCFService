using System;
using System.Threading;

namespace BilgeAdam.Service
{
    class BilgeAdam : Data.Interface.IBilgeAdam
    {
        public static DateTime LastDate = new DateTime();
        public void MyName(string name, DateTime myDate)
        {
            var diff = (myDate - LastDate).TotalMilliseconds;
            Console.WriteLine(diff + "" + myDate + " - " + name);
            new Thread(new ThreadStart(SendMessage)).Start();  
        }
        public void SendMessage()
        {
            LastDate = DateTime.UtcNow;
            Program.channel.MyName("Ufuk", LastDate);

        }
        public void Test1()
        {
            Console.WriteLine("Test1");
        }
    }
}
