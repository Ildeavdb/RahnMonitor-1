using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RahnMonitor
{
    public partial class rahnMatchForm : Form
    {
        public rahnMatchForm() //Initializes the rahnMatchForm
        {
            InitializeComponent();
        }

        private void rahnMatchForm_Deactivate(object sender, EventArgs e)
        {
            viewMoreInfoTextBox.Clear();
        }

    }
}
