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
        // TODO 2: Implement function for load items to items1, DONE
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
        // TODO 3: Implement function for load items to items2, DONE
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
        // TODO 4: Implement function for remove items from items1
        // TODO 5: impelment function for remove items from items2
        // TODO 6: implement function for process button
        // TODO 7 optional: implement function to sort different ways
    }
}
