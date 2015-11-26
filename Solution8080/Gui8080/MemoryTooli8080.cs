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
        public MemoryTooli8080()
        {
            InitializeComponent();
            IMemory8080 memory = Memory8080.Instance;
            memory.ResetMemory();
            dataGridView_memory.DataSource = memory.PhisicalMemory;
            dataGridView_memory.Refresh();
        }
    }
}
