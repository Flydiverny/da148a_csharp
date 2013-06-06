using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Cellphone
    {
        private const double usbChargeRate = 1.1, wallChargeRate = 1.2, batteryDecayRate = 0.02;

        private double batteryPercent;
        private int batteryCapacity;
        private bool poweredOn;

        private bool usbCharge;

        private int chargingTime;

        private double chargedBattery;
        private double chargeRate;

        public void Start()
        {
            ReadInput();

            CalculateBatteryCharge();

            PrintBatteryStatus();
        }

        private void ReadInput()
        {
            batteryPercent = ReadBatteryPercentage();
            batteryCapacity = ReadBatteryCapacity();
            poweredOn = ReadPowerdOnState();

            usbCharge = ReadChargingType();

            chargingTime = ReadChargingTime();
        }

        private void CalculateBatteryCharge()
        {
            var startingValue = batteryCapacity*batteryPercent;

            var time = chargingTime/60d;

            var decay = (poweredOn ? batteryDecayRate : 0);
            var chargePower = (usbCharge ? usbChargeRate : wallChargeRate);

            chargeRate = batteryCapacity * (chargePower - decay) - batteryCapacity;

            chargedBattery = startingValue + chargeRate * time;

            chargedBattery = chargedBattery > batteryCapacity ? batteryCapacity : chargedBattery;
        }

        private void PrintBatteryStatus()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Battery status " + batteryPercent*batteryCapacity + "/" + batteryCapacity + " (" + batteryPercent*100 + "%)");
            Console.WriteLine("Powered on: " + poweredOn);
            Console.WriteLine("USB Charge: " + usbCharge);
            Console.WriteLine("Charging time " + chargingTime + " minutes");
            Console.WriteLine("Charge rate: " + chargeRate + " mAh");
            Console.WriteLine("Battery status after charge: " + chargedBattery);
        }

        private static double ReadBatteryPercentage()
        {
            return int.Parse(GetInput("Enter current battery %"))/100d;
        }

        private static int ReadBatteryCapacity()
        {
            return int.Parse(GetInput("Enter battery capacity (mAh)"));
        }

        private static bool ReadPowerdOnState()
        {
            return GetBoolean("Is the device powered on");
        }

        private static bool ReadChargingType()
        {
            return GetBoolean("Is the device being charged over USB");
        }

        private static int ReadChargingTime()
        {
            return int.Parse(GetInput("Charging time in minutes"));
        }

        private static bool GetBoolean(String txt)
        {
            var response = char.Parse(GetInput(txt + " (y/n)"));

            return ((response == 'y') || (response == 'Y'));
        }

        private static String GetInput(String txt)
        {
            Console.Write(txt + ": ");
            return Console.ReadLine();
        }
    }
}
