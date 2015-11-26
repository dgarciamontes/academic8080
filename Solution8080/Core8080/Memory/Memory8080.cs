using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core8080.Memory
{
    public sealed class Memory8080 : IMemory8080
    {
        private static readonly Memory8080 instance = new Memory8080();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Memory8080()
        {
        }

        private Memory8080()
        {
        }

        public static Memory8080 Instance
        {
            get
            {
                return instance;
            }
        }

        public override byte[] ReadAdress(int address, int count)
        {
            throw new NotImplementedException();
        }




        public override byte[] WriteAdress(byte data, int address)
        {
            throw new NotImplementedException();
        }
    }
}

