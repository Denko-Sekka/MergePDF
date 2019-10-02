using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plugin;

namespace PDFPlugin
{
    public class PDFMultiMerge : IPlugin
    {
        private static PDFMultiMergeUC _pdfuc;
        private readonly string _name = "PDFMerger";
        public string PluginName => _name;

        public UserControl UC
        {
            get
            {
                if (_pdfuc == null)
                {
                    _pdfuc = new PDFMultiMergeUC();
                }

                return _pdfuc;
            }
        }
    }
}
