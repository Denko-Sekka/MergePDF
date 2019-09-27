using Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFMerger
{
    public partial class MainApp : Form
    {
        private readonly Dictionary<string, IPlugin> _plugins;
        public MainApp()
        {
            InitializeComponent();
            _plugins = new Dictionary<string, IPlugin>();
            

        }
        // TODO - the main app and plugin contract has been added. add a way to read the plugins from a path
    }
}
