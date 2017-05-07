using System;
using System.Linq;

namespace FirstHWDeffClass
{
    class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            GSM myPhone = new GSM("Ancient", "Panasonic");
            myPhone.AddCall(new Call(20, DateTime.Now));
            myPhone.AddCall(new Call(40, DateTime.Now));
            myPhone.AddCall(new Call(220, DateTime.Now));

            foreach (var item in myPhone.CallHistory)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            double pricePerCall = 0.37;

            Console.WriteLine($"Your bill is {myPhone.CalculateCallPrice(pricePerCall)} euro");
            
            var longestCall = myPhone.CallHistory.OrderBy(p => p.callDuration).Last();
            myPhone.RemoveCall(longestCall);
            Console.WriteLine();
            Console.WriteLine($"Your new bill is {myPhone.CalculateCallPrice(pricePerCall)} euro");
            myPhone.ClearHistory();

            foreach (var item in myPhone.CallHistory)
            {
                Console.WriteLine(item.ToString());
            }

        }
       
    }
}
