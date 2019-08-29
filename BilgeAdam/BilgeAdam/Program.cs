using System;

namespace BilgeAdam
{
    class Program
    {
        public static readonly Data.Interface.IBilgeAdam channel = Helper.WcfHelper.Wcf<Data.Interface.IBilgeAdam>.Channel("http://10.11.202.64:145/Service1");
        static void Main(string[] args)
        {
            Helper.WcfHelper.Run<Service.BilgeAdam, Data.Interface.IBilgeAdam>("10.11.202.63", 145, "Service1");
            //Data.Interface.IBilgeAdam channel = Helper.WcfHelper.Wcf<Data.Interface.IBilgeAdam>.Channel("http://10.11.202.64:145/Service1");
            //channel.MyName("Ufuk Özer");
            Console.ReadLine();
        }
    }
}
