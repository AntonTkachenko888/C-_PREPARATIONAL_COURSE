using System;
using MobilePhone.Base.MobilePhones;
using MobilePhone.Base.Components.Screens;
using MobilePhone.Base.Components.Dynamics;

namespace MobilePhone.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MobilePhoneBase myNokia1100 = new Nokia1100(777);
                myNokia1100.SimCardAdd(888);
                Console.WriteLine(myNokia1100.GetDescription());
                Console.WriteLine();
                Console.WriteLine(myNokia1100.Screen.Show(new SmileImage()));
                Console.WriteLine();
                Console.WriteLine(myNokia1100.Dynamic.MakeSound(new HiSound()));
                Console.WriteLine();
                Console.WriteLine(myNokia1100.Microphone.GetSound());
                Console.WriteLine();
                Console.WriteLine(myNokia1100.Call(555));
                Console.WriteLine();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        } 
    }
}
