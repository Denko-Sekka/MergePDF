using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFSingleMerger
{
    public partial class PDFSingleMergeUC : UserControl
    {
        private static PDFSingleMergeApp _pdfApp;
        public PDFSingleMergeUC()
        {
            InitializeComponent();
        }
        // TODO 1: Implement a button user control button event that launches a new form DONE
        private void btnSingleMergeUC_Click(object sender, EventArgs e)
        {
            if (_pdfApp == null || _pdfApp.IsDisposed)
            {
                _pdfApp = new PDFSingleMergeApp();
                _pdfApp.Show();
            }
            else
            {
                _pdfApp.BringToFront();
            }
        }
    }
}
