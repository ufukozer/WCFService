using System;
using System.Threading;

namespace Server.Service
{
    class Server : BilgeAdam.Data.Interface.IBilgeAdam
    {
        public static DateTime LastDate = new DateTime();
        public void MyName(string name, DateTime myDate)
        {
            var diff = (myDate - LastDate).TotalMilliseconds;
            Console.WriteLine(diff + "" + myDate + " - " + name); 
        }
        public DateTime ServerDate()
        {
            return DateTime.Now;
        }
    }
}
