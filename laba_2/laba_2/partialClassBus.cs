using System;

namespace laba_2
{
    public partial class partialClassBus : Bus
    {
        public void showDriverInfo()
        {
            Console.WriteLine($"Информация о водителе: {this.Driversurname} {this.DriverIni}");
        }
    }
}