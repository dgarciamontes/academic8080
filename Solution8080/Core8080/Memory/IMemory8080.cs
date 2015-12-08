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
                _physicalMemory[i] = Convert.ToByte(i % 8);//0x02; //Convert.ToByte((int)i % 8);// 0x01;
            }
            //Launch event
            OnChanged(EventArgs.Empty);
        }



        //Changed Event
        public delegate void ChangedEventMemory(object sender, EventArgs e);
        public event ChangedEventMemory Changed;
        // Invoke the Changed event; called whenever list changes
        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

    }



    //public class LogicalByte 
    //{
    //    Byte _value=0x01;
    //    public Byte GetByte { get {return _value;} set {_value = value;}}
    //    public Boolean Bit0 { get { return (_value & 0x01) > 0; } }
    //    public Boolean Bit1 { get { return (_value & 0x02) > 0; } }
    //    public Boolean Bit2 { get { return (_value & 0x04) > 0; } }
    //    public Boolean Bit3 { get { return (_value & 0x08) > 0; } }
    //    public Boolean Bit4 { get { return (_value & 0x10) > 0; } }
    //    public Boolean Bit5 { get { return (_value & 0x20) > 0; } }
    //    public Boolean Bit6 { get { return (_value & 0x40) > 0; } }
    //    public Boolean Bit7 { get { return (_value & 0x80) > 0; } }
    //}
}
