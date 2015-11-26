using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core8080.Memory
{
    public abstract class IMemory8080
    {
        //Memory size in BYTES
        static readonly int SIZE = 65535;
        private Byte[] _physicalMemory = new Byte[SIZE];
        //8080 Memory
        public Byte[] PhisicalMemory
        {
            get { return _physicalMemory; } 
        }

        
        public abstract Byte[] ReadAdress(int address, int count);
        public abstract Byte[] WriteAdress(byte data, int address);
        

        public void ResetMemory()
        {
            for (int i = 0; i < SIZE; i++)
            {
                _physicalMemory[i] = 0;
            }
        }
    }
}
