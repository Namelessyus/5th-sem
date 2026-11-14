using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4
{
    public delegate void DelegateExample(string alert);

    static class Thermometer
    {
        public static void CheckTemperature(int temperature, DelegateExample Delegate)
        {
            if (temperature > 40)
            {
                Delegate("Temperature is more than 40");
            }
            else
            {
                Console.WriteLine("Temperature is below 40");
            }
        }
    }

    
    internal class DelegateTemperatureMonitor
    {
        public void DisplayAlert(string alert)
        {
            Console.WriteLine(alert);
        }
        public static void Main()
        {
            DelegateTemperatureMonitor monitor = new DelegateTemperatureMonitor();
            Thermometer.CheckTemperature(45, monitor.DisplayAlert);
        }

    }
}
