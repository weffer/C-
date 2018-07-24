using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitableButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // The following does not compile. Implement await support
            // for the Button class to make it compile and run.

            await button1;

            button1.Enabled = false;
            button2.Enabled = true;

            await button2;
            await button2;

            MessageBox.Show("Hello!");
        }
    }
}
