using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFPlugin
{
    public partial class PDFPluginApp : Form
    {
        private string _resultsPath;
        private OpenFileDialog _ofd;
        public PDFPluginApp()
        {
            InitializeComponent();
        }

        // TODO 1a: implement function to sort items in lbItems1 DONE
        private void btnSortItem1_Click(object sender, EventArgs e)
        {
            var items = lbItem1.Items.Cast<dynamic>().ToList();
            items.Sort();
            lbItem1.Items.Clear();
            foreach (var item in items)
            {
                lbItem1.Items.Add(item);
            }
        }
        // TODO 1b: imeplement function to sort items in lbItems2 DONE
        private void btnSortItem2_Click(object sender, EventArgs e)
        {
            var items = lbItem2.Items.Cast<dynamic>().ToList();
            items.Sort();
            lbItem2.Items.Clear();
            foreach (var item in items)
            {
                lbItem2.Items.AddRange(item);
            }
        }

        // TODO 2a: Implement function for load items to items1, DONE
        private void folderAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (_ofd = new OpenFileDialog())
            {
                _ofd.Filter = "PDF (*.pdf) | *.pdf";
                _ofd.FileName = "";
                _ofd.Title = "Select Files to grab";
                _ofd.Multiselect = true;
                if (_ofd.ShowDialog() == DialogResult.OK)
                {
                    lbItem1.Items.AddRange(_ofd.FileNames);
                }
            }
        }
        // TODO 2b: Implement function for load items to items2, DONE
        private void folderBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (_ofd = new OpenFileDialog())
            {
                _ofd.Filter = "PDF (*.pdf) | *.pdf";
                _ofd.FileName = "";
                _ofd.Title = "Select Files to grab";
                _ofd.Multiselect = true;
                if (_ofd.ShowDialog() == DialogResult.OK)
                {
                    lbItem2.Items.AddRange(_ofd.FileNames);
                }
            }

        // TODO 8: Implement a way to drag files into lbItems1
        // TODO 9: Implement a way to drag files into lbItems2
        }
        // TODO 3a: Implement function for remove items from items1. DONE
        private void btnRemoveItem1_Click(object sender, EventArgs e)
        {
            if (lbItem1.SelectedItem != null)
            {
                lbItem1.Items.Remove(lbItem1.SelectedItem);
            }
        }

        // TODO 3b: impelment function for remove items from items2 DONE
        private void btnRemoveItem2_Click(object sender, EventArgs e)
        {
            if (lbItem2.SelectedItem != null)
            {
                lbItem2.Items.Remove(lbItem2.SelectedItem);
            }
        }

        // TODO 4: implement function for process button
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
                MessageBox.Show(
                    "The number of items between the two boxes do not match, items with no matching partner will be ignored!");

            }
        }
        // TODO 5 optional: implement function to sort different ways
        // TODO 6: create a method to update all the items
        // TODO 7: create a method to update the UI
    }
}
