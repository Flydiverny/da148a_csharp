// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cellphone.cs" company="Markus Maga">
//   Markus Maga 2013-06-23
// </copyright>
// <summary>
//   The cellphone.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Part2
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// The cellphone.
    /// </summary>
    public class Cellphone
    {
        /// <summary>
        /// Multipliers for battery charge and decay rates.
        /// </summary>
        private const double UsbChargeRate = 1.1, WallChargeRate = 1.2, BatteryDecayRate = 0.02;

        /// <summary>
        /// The battery percent.
        /// </summary>
        private double batteryPercent;

        /// <summary>
        /// The battery capacity.
        /// </summary>
        private int batteryCapacity;

        /// <summary>
        /// The powered on.
        /// </summary>
        private bool poweredOn;

        /// <summary>
        /// The charge type, true for USB false for wall charging.
        /// </summary>
        private bool usbCharge;

        /// <summary>
        /// The charging time.
        /// </summary>
        private int chargingTime;

        /// <summary>
        /// The charged batteries capacity.
        /// </summary>
        private double chargedBattery;

        /// <summary>
        /// The battery percentage after charging.
        /// </summary>
        private double chargedPercentage;

        /// <summary>
        /// The rate at which the battery will be charged, includes battery decay.
        /// </summary>
        private double chargeRate;

        /// <summary>
        /// Starts the Cellphone program.
        /// </summary>
        public void Start()
        {
            this.ReadInput();

            this.CalculateBatteryCharge();

            this.PrintBatteryStatus();
        }

        /// <summary>
        /// Validates user input to see if it can be converted to specified type T.
        /// </summary>
        /// <param name="text">
        /// Text to output before user input.
        /// </param>
        /// <typeparam name="T">
        /// Type to convert input to.
        /// </typeparam>
        /// <returns>
        /// Converted input as type <see cref="T"/>.
        /// </returns>
        private static T ValidateInput<T>(string text) where T : struct
        {
            Console.Write(text + ": ");
            var returnValue = default(T);

            do
            {
                var input = Console.ReadLine();
                try
                {
                    var convertFromString = TypeDescriptor.GetConverter(default(T)).ConvertFromString(input);
                    if (convertFromString != null)
                    {
                        returnValue = (T)convertFromString;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.Write(text);
                }
            }
            while (returnValue.Equals(default(T)));

            return returnValue;
        }

        /// <summary>
        /// Reads integer input from console and converts to decimal form.
        /// </summary>
        /// <returns>
        /// Percentage in decimal form <see cref="double"/>.
        /// </returns>
        private static double ReadBatteryPercentage()
        {
            return ValidateInput<int>("Enter current battery %") / 100d;
        }

        /// <summary>
        /// The read battery capacity.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private static int ReadBatteryCapacity()
        {
            return ValidateInput<int>("Enter battery capacity (mAh)");
        }

        /// <summary>
        /// Asks user if the device is powered on or off.
        /// </summary>
        /// <returns>
        /// <see cref="bool"/>.
        /// </returns>
        private static bool ReadPowerdOnState()
        {
            return GetBoolean("Is the device powered on");
        }

        /// <summary>
        /// Asks user for charging type.
        /// </summary>
        /// <returns>
        /// <see cref="bool"/>.
        /// </returns>
        private static bool ReadChargingType()
        {
            return GetBoolean("Is the device being charged over USB");
        }

        /// <summary>
        /// Asks user for charging duration.
        /// </summary>
        /// <returns>
        /// Charging duration in minutes <see cref="int"/>.
        /// </returns>
        private static int ReadChargingTime()
        {
            return ValidateInput<int>("Charging time in minutes");
        }

        /// <summary>
        /// The get boolean.
        /// </summary>
        /// <param name="txt">
        /// The txt.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private static bool GetBoolean(string txt)
        {
            var response = ValidateInput<char>(txt + " (y/n)");

            return (response == 'y') || (response == 'Y');
        }

        /// <summary>
        /// Reads input from user and assigns fields.
        /// </summary>
        private void ReadInput()
        {
            this.batteryPercent  = ReadBatteryPercentage();
            this.batteryCapacity = ReadBatteryCapacity();
            this.poweredOn       = ReadPowerdOnState();

            this.usbCharge       = ReadChargingType();

            this.chargingTime    = ReadChargingTime();
        }

        /// <summary>
        /// Calculates the battery's capacity after charging according to input data.
        /// </summary>
        private void CalculateBatteryCharge()
        {
            var startingValue = this.batteryCapacity * this.batteryPercent;

            var time = this.chargingTime / 60d;

            var decay = this.poweredOn ? BatteryDecayRate : 0;
            var chargePower = this.usbCharge ? UsbChargeRate : WallChargeRate;

            this.chargeRate = (this.batteryCapacity * (chargePower - decay)) - this.batteryCapacity;

            var capacityCharged = startingValue + (this.chargeRate * time);

            // If the calculated capacity is greater than the battery capacity we are fully charged.
            this.chargedBattery = capacityCharged > this.batteryCapacity ? this.batteryCapacity : capacityCharged;

            this.chargedPercentage = this.chargedBattery / this.batteryCapacity * 100d;
        }

        /// <summary>
        /// Prints the battery status to the console window.
        /// </summary>
        private void PrintBatteryStatus()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Battery status " + (this.batteryPercent * this.batteryCapacity) + "/" + this.batteryCapacity + " (" + (this.batteryPercent * 100) + "%)");
            Console.WriteLine("Powered on: " + this.poweredOn);
            Console.WriteLine("USB Charge: " + this.usbCharge);
            Console.WriteLine("Charging time " + this.chargingTime + " minutes");
            Console.WriteLine("Charge rate: " + this.chargeRate + " mAh");
            Console.WriteLine("Battery status after charge: " + this.chargedBattery + " mAh " + this.chargedPercentage + " %");
        }
    }
}
