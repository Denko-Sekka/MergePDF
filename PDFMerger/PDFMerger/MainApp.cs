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

            // grab all the DLLs available in the plugins forlder
            ICollection<IPlugin> plugins = PluginLoader.LoadPlugin(System.IO.Path.GetFullPath(@"..\..\Plugin"));
            
            // Add each User control to the main form
            foreach (var item in plugins)
            {
                _plugins.Add(item.PluginName, item);
                flpMain.Controls.Add((UserControl)item.UC);
            }
        }
    }
}
