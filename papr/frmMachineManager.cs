using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freeze_uk
{
    public partial class frmMachineManager : Form
    {
        public frmMachineManager()
        {
            InitializeComponent();

            StringCollection CurrentMachines = Properties.Settings.Default.Machines;
            machineBox.Items.Clear();

            CurrentMachines =
            foreach (string CurrentMachine in CurrentMachines)
            {
                machineBox.Items.Add(CurrentMachine.ToString());
            }
        }

        private void machineBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
