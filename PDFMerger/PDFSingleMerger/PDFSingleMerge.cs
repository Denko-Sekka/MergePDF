using Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFSingleMerger
{
    public class PDFSingleMerge : IPlugin
    {
        private readonly string _name = "PDF Single Merge";
        private static PDFSingleMergeUC _app;
        public string PluginName => _name;

        public UserControl UC
        {
            get
            {
                if (_app == null || _app.IsDisposed)
                {
                    _app = new PDFSingleMergeUC();
                }

                return _app;
            }
        }
    }
}
