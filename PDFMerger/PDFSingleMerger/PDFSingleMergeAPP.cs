using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFSingleMerger
{
    public partial class PDFSingleMergeApp : Form
    {
        private static OpenFileDialog _ofd;
        private static string _path;
        public PDFSingleMergeApp()
        {
            InitializeComponent();
        }

        // TODO 2: Implement method that adds pdf files into lbItems
        private void pDFFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (_ofd = new OpenFileDialog())
            {
                _ofd.Filter = "PDF (*.pdf) | *.pdf";
                _ofd.Title = "Select Files to grab";
                _ofd.Multiselect = true;
                if (_ofd.ShowDialog() == DialogResult.OK)
                {
                    lbItem.Items.Clear();
                    var token = _ofd.FileNames[0];
                    _path = token.Replace(_ofd.SafeFileNames[0], "");
                    lbItem.Items.AddRange(_ofd.SafeFileNames);
                }
            }
        }

        // TODO 3: Implement sort button
        private void btnSortItem_Click(object sender, EventArgs e)
        {
            var lst = lbItem.Items.Cast<dynamic>().ToList();
            lst.Sort();
            for (int i = 0; i < lst.Count; i++)
            {
                lbItem.Items[i] = lst.ElementAt(i);
            }
        }
        // TODO 4: Implement remove button
        // TODO 5: Implement merge button
        // TODO 6: Implement a way to allow users to move file orders by dragging files
    }
}
