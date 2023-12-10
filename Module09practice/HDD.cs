using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module09practice
{
    class HDD : Storage
    {
        private double usbSpeed;
        private int partitions;
        private double partitionVolume;
        public HDD(string name, string model, double usbSpeed, int partitions, double partitionVolume)
            : base(name, model)
        {
            this.usbSpeed = usbSpeed;
            this.partitions = partitions;
            this.partitionVolume = partitionVolume;
        }
        public override double GetMemoryVolume()
        {
            return partitions * partitionVolume;
        }
        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Копирование {dataSize} ГБ на съемный жесткий диск...");
        }
        public override double GetFreeMemory()
        {
            return partitions * partitionVolume / 2;
        }
        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Removable HDD: {name}, Model: {model}, USB Speed: {usbSpeed} GB/s, Partitions: {partitions}");
        }
    }
}
