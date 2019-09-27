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
    public partial class PDFPluginApp : Form
    {
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
        // TODO 1b: imeplement function to sort items in lbItems2

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
        }
        // TODO 3: Implement function for remove items from items1
        // TODO 4: impelment function for remove items from items2
        // TODO 5: implement function for process button
        // TODO 6 optional: implement function to sort different ways
        // TODO 7: create a method to update all the items
        // TODO 8: create a method to update the UI
    }
}
