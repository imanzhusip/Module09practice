using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module09practice
{
    class Program
    {
        static void Main()
        {
            Storage[] devices = new Storage[]
            {
            new Flash("Флэшка1", "Kingston", 3.0, 64),
            new DVD("DVD1", "Sony", 2.0, "Single"),
            new HDD("HDD1", "Seagate", 2.0, 2, 500),
            };

            //Расчет общего количества памяти всех устройств
            double totalMemory = CalculateTotalMemory(devices);
            Console.WriteLine($"Общая память: {totalMemory} ГБ");

            //Копирование информации на устройства
            CopyDataToDevice(devices, 565);

            //Расчет времени необходимого для копирования
            double copyTime = CalculateCopyTime(devices, 565);
            Console.WriteLine($"Расчетное время копирования: {copyTime} часов");

            //Расчет необходимого количества носителей информации для переноса
            int requiredDevices = CalculateRequiredDevices(devices, 565);
            Console.WriteLine($"Необходимые устройства: {requiredDevices}");
            Console.ReadKey();
        }
        static double CalculateTotalMemory(Storage[] devices)
        {
            double totalMemory = 0;
            foreach (var device in devices)
            {
                totalMemory += device.GetMemoryVolume();
            }
            return totalMemory;
        }
        static void CopyDataToDevice(Storage[] devices, double dataSize)
        {
            foreach (var device in devices)
            {
                device.CopyData(dataSize);
            }
        }
        static double CalculateCopyTime(Storage[] devices, double dataSize)
        {
            double copySpeed = 50; // ГБ/час
            double totalMemory = CalculateTotalMemory(devices);
            return totalMemory / copySpeed;
        }
        static int CalculateRequiredDevices(Storage[] devices, double dataSize)
        {
            double totalMemory = CalculateTotalMemory(devices);
            return (int)Math.Ceiling(dataSize / totalMemory);
        }
    }
}
