using System;
using System.Linq.Expressions;
using MobilePhone.Base.Components.HeadSets;
using MobilePhone.Base.MobilePhones;
using MobilePhone.Base.Components.Chargers;
using MobilePhone.Base.Components.Screens;
using MobilePhone.Base.Components.Speakers;

namespace MobilePhone.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var console = new ConsoleOutput();

                MobilePhoneBase myNokia1100 = new Nokia1100(777);

                Console.WriteLine("Select playback component:");
                Console.WriteLine("1 - iPhoneHeadset");
                Console.WriteLine("2 - SamsungHeadset");
                Console.WriteLine("3 - UnofficialiPhoneHeadset");
                Console.WriteLine("4 - PhoneSpeaker");
                int playbackNumber = readNumber();
                myNokia1100.PlaybackComponent = HeadsetFactory.GetHeadset((Headsets)playbackNumber, console);
                myNokia1100.PlaybackComponent.Play("Hi");

                Console.WriteLine();

                Console.WriteLine("Select charger component:");
                Console.WriteLine("1 - FastCharge");
                Console.WriteLine("2 - UsualCharge");
                int chargerNumber = readNumber();
                myNokia1100.ChargerComponent = ChargeFactory.GetCharge((Charges)chargerNumber, myNokia1100.Battery, console);
                myNokia1100.Charge();

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
        public static int readNumber()
        {
            while (true)
            {
                string key = Console.ReadLine();
                int result;
                if (int.TryParse(key, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Value must be integer, from list above!");
                }
            }
        }
    }
}
