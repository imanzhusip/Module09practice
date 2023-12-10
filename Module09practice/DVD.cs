using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module09practice
{
    public class DVD : Storage
    {
        private double readWriteSpeed;
        private string type;

        public DVD(string name, string model, double readWriteSpeed, string type)
            : base(name, model)
        {
            this.readWriteSpeed = readWriteSpeed;
            this.type = type;
        }

        public override double GetMemoryVolume()
        {
            return (type == "Single") ? 4.7 : 9;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying {dataSize} GB to DVD...");
        }

        public override double GetFreeMemory()
        {
            // Предположим, что DVD-диск одноразовый и всегда свободен
            return GetMemoryVolume();
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"DVD: {name}, Model: {model}, Read/Write Speed: {readWriteSpeed} GB/s, Type: {type}");
        }
    }

}
