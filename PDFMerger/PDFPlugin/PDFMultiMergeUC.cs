using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFPlugin
{
    public partial class PDFMultiMergeUC : UserControl
    {
        // TODO 1a: Complete the mainform for PDFMerging App. FUNCTIONALLY DONE

        // singleton of pdfmerging app
        private static PDFMultiMergeApp _pdfapp;
        public PDFMultiMergeUC()
        {
            InitializeComponent();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            // if the form has been closed or hasn't been created, make one and show it.
            // if it already exists, bring it the front
            if (_pdfapp == null || _pdfapp.IsDisposed)
            {
                _pdfapp = new PDFMultiMergeApp();
                _pdfapp.Show();
            }
            else
            {
                _pdfapp.BringToFront();
            }
        }
    }
}
