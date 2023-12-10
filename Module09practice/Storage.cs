using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module09practice
{
    public abstract class Storage
    {
        protected string name;
        protected string model;
        public Storage(string name, string model)
        {
            this.name = name;
            this.model = model;
        }
        public abstract double GetMemoryVolume();
        public abstract void CopyData(double dataSize);
        public abstract double GetFreeMemory();
        public abstract void GetDeviceInfo();
    }

}
