using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFPlugin
{
    public partial class PDFMultiMergeApp : Form
    {
        private string _resultsPath;
        private OpenFileDialog _ofd1;
        private OpenFileDialog _ofd2;
        private string _pathA;
        private string _pathB;
        public PDFMultiMergeApp()
        {
            InitializeComponent();
            _pathA = "";
            _pathB = "";
            lbPreview.Items.Add("Preview");
        }
        // TODO 1a: implement function to sort items in lbItems1 DONE
        // TODO 1b: imeplement function to sort items in lbItems2 DONE
        private void btnSortItem_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == btnSortItem1.Name && lbItem1.Items.Count > 0)
            {
                var items = lbItem1.Items.Cast<dynamic>().ToList();
                items.Sort();
                lbItem1.Items.Clear();
                foreach (var item in items)
                {
                    lbItem1.Items.Add(item);
                }
            }

            if ((sender as Button).Name == btnSortItem2.Name && lbItem2.Items.Count > 0)
            {
                var items = lbItem2.Items.Cast<dynamic>().ToList();
                items.Sort();
                lbItem2.Items.Clear();
                foreach (var item in items)
                {
                    lbItem2.Items.Add(item);
                }
            }
        }
        // TODO 2a: Implement function for load items to items1, DONE
        // TODO 2b: Implement function for load items to items2, DONE
        // TODO 8: Implement a way to drag files into lbItems1
        // TODO 9: Implement a way to drag files into lbItems2
        // TODO 12: Implement a way to store path(FileNames) and safenames from _ofd
        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // originally the idea was to use a switch case to check the name of the sender
            // It doesn't seem to work as limitations in switch cases give 'a constant value is expected' error.
            // calling indices is too annoying so i
            if ((sender as ToolStripItem).Name == folderAToolStripMenuItem.Name)
            {
                using (_ofd1 = new OpenFileDialog())
                {
                    _ofd1.Filter = "PDF (*.pdf) | *.pdf";
                    _ofd1.Title = "Select Files to grab";
                    _ofd1.Multiselect = true;
                    if (_ofd1.ShowDialog() == DialogResult.OK)
                    {
                        lbItem1.Items.Clear();
                        string token = _ofd1.SafeFileNames[0];
                        _pathA = _ofd1.FileNames[0].Replace(token, "");
                        lbItem1.Items.AddRange(_ofd1.SafeFileNames);
                    }
                }
            }

            if ((sender as ToolStripItem).Name == folderBToolStripMenuItem.Name)
            {
                using (_ofd2 = new OpenFileDialog())
                {
                    _ofd2.Filter = "PDF (*.pdf) | *.pdf";
                    _ofd2.Title = "Select Files to grab";
                    _ofd2.Multiselect = true;
                    if (_ofd2.ShowDialog() == DialogResult.OK)
                    {
                        lbItem2.Items.Clear();
                        string token = _ofd2.SafeFileNames[0];
                        _pathB = _ofd2.FileNames[0].Replace(token, "");
                        lbItem2.Items.AddRange(_ofd2.SafeFileNames);
                    }
                }
            }
            PreviewFiles();
        }

        // TODO 3a: Implement function for remove items from items1. DONE
        // TODO 3b: impelment function for remove items from items2 DONE
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lbItem1.SelectedItem != null && (sender as Button).Name == btnRemoveItem1.Name)
            {
                lbItem1.Items.Remove(lbItem1.SelectedItem);
            }

            if (lbItem2.SelectedItem != null && (sender as Button).Name == btnRemoveItem2.Name)
            {
                lbItem2.Items.Remove(lbItem2.SelectedItem);
            }
            PreviewFiles();
        }

        // TODO 4: implement function for process button DONE
        private void btnProcessResults_Click(object sender, EventArgs e)
        {
            // obtain the path for the resource folder
            string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Results");
            _resultsPath = filePath;
            if (lbItem1.Items.Count <= 0 || lbItem2.Items.Count <= 0)
            {
                MessageBox.Show("No items in one of the boxes!");
                return;
            }

            if (lbItem1.Items.Count != lbItem2.Items.Count)
            {
                DialogResult result = MessageBox.Show("The number of items do not match, only files with a matching partner will be matched! Are you sure you want to continue?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            int count = Math.Min(lbItem1.Items.Count, lbItem2.Items.Count);
            var lstA = lbItem1.Items;
            var lstB = lbItem2.Items;
            for (int i = 0; i < count; i++)
            {
                using (PdfDocument one = PdfReader.Open($"{_pathA}\\{lstA[i]}", PdfDocumentOpenMode.Import))
                using (PdfDocument two = PdfReader.Open($"{_pathB}\\{lstB[i]}", PdfDocumentOpenMode.Import))
                {
                    foreach (var twoPage in two.Pages)
                    {
                        one.AddPage(twoPage);
                    }

                    string outName = _resultsPath + $"\\{lstA[i].ToString().Split('.')[0]}-{lstB[i].ToString().Split('.')[0]}.pdf";
                    // Save the file
                    one.Save(outName);
                    // Open the folder using the path
                    Process.Start("explorer.exe",_resultsPath);
                }
            }
        }
        // TODO 7: create a method to update the UI DONE?
        private void PreviewFiles()
        {
            lbPreview.Items.Clear();
            lbPreview.Items.Add("Preview");
            int count = Math.Min(lbItem1.Items.Count, lbItem2.Items.Count);
            for (int i = 0; i < count; i++)
            {
                string nameA = lbItem1.Items[i].ToString().Split('\\').Last().Split('.')[0];
                string nameB = lbItem2.Items[i].ToString().Split('\\').Last().Split('.')[0];
                lbPreview.Items.Add($"{nameA}-{nameB}.pdf");
            }
        }

        private void lbItem_Click(object sender, EventArgs e)
        {
            if ((sender as ListBox).Name == lbItem1.Name)
            {

            }

            if ((sender as ListBox).Name == lbItem2.Name)
            {

            }
        }
        // TODO 5 optional: implement function to sort different ways
        // TODO 6 optional: create a method to update all storage items items
        // TODO 10: Get the project into an executable
        // https://social.msdn.microsoft.com/Forums/vstudio/en-US/03deaf3d-2dd7-4d3e-a337-084eeb38e791/how-to-generate-exe-file-of-c-windows-forms-app-net-framework-in-visual-studio-2017?forum=winforms
        // TODO 11: When the mouse hovers over selecteditem, show the full item path.
    }
}
