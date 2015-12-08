using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core8080.Memory;

namespace Gui8080
{
    public partial class MemoryTooli8080 : Form
    {
        IMemory8080 memory;

        public MemoryTooli8080()
        {
            InitializeComponent();
            
            memory = Memory8080.Instance;
            memory.Changed += new IMemory8080.ChangedEventMemory(MemoryChanged);


            memory.ResetMemory();

        }


        public void ReloadMemoryView() 
        {
            dataGridView_memory.DataSource = memory.PhisicalMemory.ToList().Select(s => new { Value = s.ToString()}).ToList();
            
            //I'm not sure if it is neccesary to refresh...
            dataGridView_memory.Refresh();
            dataGridView_memory.Parent.Refresh();
        }


        private void MemoryChanged(object sender, EventArgs e)
        {
            ReloadMemoryView();
        }

        private void numeric_mempos_ValueChanged(object sender, EventArgs e)
        {
            if(numeric_mempos.Value >= 0 && numeric_mempos.Value < 65535)
                dataGridView_memory.CurrentCell = dataGridView_memory.Rows[(int)numeric_mempos.Value].Cells[0];
        }

        

    }
}
