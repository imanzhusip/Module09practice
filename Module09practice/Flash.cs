using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module09practice
{
    public class Flash : Storage
    {
        private double usbSpeed;
        private double memoryVolume;
        public Flash(string name, string model, double usbSpeed, double memoryVolume)
            : base(name, model)
        {
            this.usbSpeed = usbSpeed;
            this.memoryVolume = memoryVolume;
        }
        public override double GetMemoryVolume()
        {
            return memoryVolume;
        }
        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Копирование  {dataSize} ГБ на флэш-накопитель...");
        }
        public override double GetFreeMemory()
        {
            return memoryVolume / 2;
        }
        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Флэшка: {name}, модель: {model}, USB скорость: {usbSpeed} ГБ/с");
        }
    }
}
