using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core8080.Memory
{
    interface IMemory8080
    {
        //8080 Memory
        Byte[] _phisicalMemory;

        public IMemory8080 getInstance();
        
        public Byte[] ReadAdress(int address, int count);
        public Byte[] WriteAdress(byte data, int address);
    }
}
