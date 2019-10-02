using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFPlugin
{
    public partial class PDFMultiMergeHelp : Form
    {
        public PDFMultiMergeHelp()
        {
            InitializeComponent();
            richTextBox1.Text =
                "Hello there! Developer here, this is a free application that that lets you easily merge pdf files." +
                "I did this as a personal project to help me learn and grow as a developer. This application is free, if you paid for this app, you're getting ripped off!" +
                "\n\n" +
                "You can use the UP/DOWN arrow to manually sort your files for your folder A/B";
        }
    }
}
