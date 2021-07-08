using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleEngine;

namespace ExampleGUI
{
    public partial class ExampleGUI : Form
    {
        private IEngine Engine;

        public ExampleGUI()
        {
            InitializeComponent();

            Engine = new MyEngineAdapter();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Engine.StartApplication();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Engine.QuitApplication();
        }
    }
}
