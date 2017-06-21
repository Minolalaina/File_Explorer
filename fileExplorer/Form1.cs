using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            float formWidth=1;
            float formHeight=2;
            float panWidth = (10 * formWidth) / 100;
            float panHeight = (10 * formHeight) / 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
