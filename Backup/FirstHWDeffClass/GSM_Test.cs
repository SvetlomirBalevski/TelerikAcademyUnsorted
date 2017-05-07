using System;

namespace FirstHWDeffClass
{
    class GSM_Test
    {
        public GSM[] familyPhones;
        
        private GSM_Test()
        {
            GSM nokia = new GSM("3310", "Nokia", "Grandpa", new Battery(Battery.BatteryType.AAA), new Display(), 20);
            GSM samsung = new GSM("Some Samsung model", "Samsung", "My wife", new Battery(Battery.BatteryType.LiON, 0, 0), new Display(480, 500));
            GSM evolveo = new GSM("Some waterproof phone", "Evolveo", "me", new Battery(Battery.BatteryType.LiON, 0, 0), new Display(100, 100));

            familyPhones = new GSM[] {
                nokia,
                samsung,
                evolveo
            };
    }

       public static void ExecuteTests()
        {
            GSM_Test instance = new GSM_Test();
            for (int i = 0; i < instance.familyPhones.Length; i++)
            {
                Console.WriteLine(instance.familyPhones[i].ToString());
                Console.WriteLine();
                Console.WriteLine(GSM.Iphone4.ToString());
                Console.WriteLine();
            }
        }

    }
}
