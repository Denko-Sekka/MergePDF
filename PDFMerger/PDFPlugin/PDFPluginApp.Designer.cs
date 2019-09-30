namespace PDFPlugin
{
    partial class PDFPluginApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.flp3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpItem1Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSortItem1 = new System.Windows.Forms.Button();
            this.btnRemoveItem1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbItem2 = new System.Windows.Forms.ListBox();
            this.flpItem2Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSortItem2 = new System.Windows.Forms.Button();
            this.btnRemoveItem2 = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProcessResults = new System.Windows.Forms.Button();
            this.lbItem1 = new System.Windows.Forms.ListBox();
            this.tlpMain.SuspendLayout();
            this.flp3.SuspendLayout();
            this.flp2.SuspendLayout();
            this.flp1.SuspendLayout();
            this.flpItem1Buttons.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flpItem2Buttons.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.Controls.Add(this.flp3, 4, 0);
            this.tlpMain.Controls.Add(this.flp2, 2, 0);
            this.tlpMain.Controls.Add(this.flp1, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 24);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1001, 345);
            this.tlpMain.TabIndex = 0;
            // 
            // flp3
            // 
            this.flp3.BackColor = System.Drawing.SystemColors.Control;
            this.flp3.Controls.Add(this.flowLayoutPanel1);
            this.flp3.Controls.Add(this.lbResults);
            this.flp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp3.Location = new System.Drawing.Point(703, 3);
            this.flp3.Name = "flp3";
            this.flp3.Size = new System.Drawing.Size(295, 339);
            this.flp3.TabIndex = 3;
            // 
            // flp2
            // 
            this.flp2.BackColor = System.Drawing.SystemColors.Control;
            this.flp2.Controls.Add(this.flpItem2Buttons);
            this.flp2.Controls.Add(this.lbItem2);
            this.flp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp2.Location = new System.Drawing.Point(353, 3);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(294, 339);
            this.flp2.TabIndex = 2;
            // 
            // flp1
            // 
            this.flp1.BackColor = System.Drawing.SystemColors.Control;
            this.flp1.Controls.Add(this.flpItem1Buttons);
            this.flp1.Controls.Add(this.lbItem1);
            this.flp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp1.Location = new System.Drawing.Point(3, 3);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(294, 339);
            this.flp1.TabIndex = 1;
            // 
            // flpItem1Buttons
            // 
            this.flpItem1Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpItem1Buttons.BackColor = System.Drawing.SystemColors.Highlight;
            this.flpItem1Buttons.Controls.Add(this.btnSortItem1);
            this.flpItem1Buttons.Controls.Add(this.btnRemoveItem1);
            this.flpItem1Buttons.Location = new System.Drawing.Point(3, 3);
            this.flpItem1Buttons.Name = "flpItem1Buttons";
            this.flpItem1Buttons.Size = new System.Drawing.Size(283, 34);
            this.flpItem1Buttons.TabIndex = 1;
            // 
            // btnSortItem1
            // 
            this.btnSortItem1.Location = new System.Drawing.Point(3, 3);
            this.btnSortItem1.Name = "btnSortItem1";
            this.btnSortItem1.Size = new System.Drawing.Size(75, 23);
            this.btnSortItem1.TabIndex = 0;
            this.btnSortItem1.Text = "Sort";
            this.btnSortItem1.UseVisualStyleBackColor = true;
            this.btnSortItem1.Click += new System.EventHandler(this.btnSortItem_Click);
            // 
            // btnRemoveItem1
            // 
            this.btnRemoveItem1.Location = new System.Drawing.Point(84, 3);
            this.btnRemoveItem1.Name = "btnRemoveItem1";
            this.btnRemoveItem1.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem1.TabIndex = 3;
            this.btnRemoveItem1.Text = "Remove";
            this.btnRemoveItem1.UseVisualStyleBackColor = true;
            this.btnRemoveItem1.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderAToolStripMenuItem,
            this.folderBToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // folderAToolStripMenuItem
            // 
            this.folderAToolStripMenuItem.Name = "folderAToolStripMenuItem";
            this.folderAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.folderAToolStripMenuItem.Text = "Folder A";
            this.folderAToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // folderBToolStripMenuItem
            // 
            this.folderBToolStripMenuItem.Name = "folderBToolStripMenuItem";
            this.folderBToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.folderBToolStripMenuItem.Text = "Folder B";
            this.folderBToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // lbItem2
            // 
            this.lbItem2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbItem2.FormattingEnabled = true;
            this.lbItem2.Location = new System.Drawing.Point(3, 43);
            this.lbItem2.Name = "lbItem2";
            this.lbItem2.ScrollAlwaysVisible = true;
            this.lbItem2.Size = new System.Drawing.Size(283, 290);
            this.lbItem2.TabIndex = 2;
            // 
            // flpItem2Buttons
            // 
            this.flpItem2Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpItem2Buttons.BackColor = System.Drawing.SystemColors.Highlight;
            this.flpItem2Buttons.Controls.Add(this.btnSortItem2);
            this.flpItem2Buttons.Controls.Add(this.btnRemoveItem2);
            this.flpItem2Buttons.Location = new System.Drawing.Point(3, 3);
            this.flpItem2Buttons.Name = "flpItem2Buttons";
            this.flpItem2Buttons.Size = new System.Drawing.Size(283, 34);
            this.flpItem2Buttons.TabIndex = 3;
            // 
            // btnSortItem2
            // 
            this.btnSortItem2.Location = new System.Drawing.Point(3, 3);
            this.btnSortItem2.Name = "btnSortItem2";
            this.btnSortItem2.Size = new System.Drawing.Size(75, 23);
            this.btnSortItem2.TabIndex = 1;
            this.btnSortItem2.Text = "Sort";
            this.btnSortItem2.UseVisualStyleBackColor = true;
            this.btnSortItem2.Click += new System.EventHandler(this.btnSortItem_Click);
            // 
            // btnRemoveItem2
            // 
            this.btnRemoveItem2.Location = new System.Drawing.Point(84, 3);
            this.btnRemoveItem2.Name = "btnRemoveItem2";
            this.btnRemoveItem2.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem2.TabIndex = 2;
            this.btnRemoveItem2.Text = "Remove";
            this.btnRemoveItem2.UseVisualStyleBackColor = true;
            this.btnRemoveItem2.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lbResults
            // 
            this.lbResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(3, 43);
            this.lbResults.Name = "lbResults";
            this.lbResults.ScrollAlwaysVisible = true;
            this.lbResults.Size = new System.Drawing.Size(249, 290);
            this.lbResults.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Controls.Add(this.btnProcessResults);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 34);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnProcessResults
            // 
            this.btnProcessResults.Location = new System.Drawing.Point(3, 3);
            this.btnProcessResults.Name = "btnProcessResults";
            this.btnProcessResults.Size = new System.Drawing.Size(75, 23);
            this.btnProcessResults.TabIndex = 1;
            this.btnProcessResults.Text = "Process";
            this.btnProcessResults.UseVisualStyleBackColor = true;
            this.btnProcessResults.Click += new System.EventHandler(this.btnProcessResults_Click);
            // 
            // lbItem1
            // 
            this.lbItem1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbItem1.FormattingEnabled = true;
            this.lbItem1.Location = new System.Drawing.Point(3, 43);
            this.lbItem1.Name = "lbItem1";
            this.lbItem1.ScrollAlwaysVisible = true;
            this.lbItem1.Size = new System.Drawing.Size(283, 290);
            this.lbItem1.TabIndex = 1;
            // 
            // PDFPluginApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1001, 369);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PDFPluginApp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PDFPluginApp";
            this.tlpMain.ResumeLayout(false);
            this.flp3.ResumeLayout(false);
            this.flp2.ResumeLayout(false);
            this.flp1.ResumeLayout(false);
            this.flpItem1Buttons.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flpItem2Buttons.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flp3;
        private System.Windows.Forms.FlowLayoutPanel flp2;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.Button btnSortItem1;
        private System.Windows.Forms.FlowLayoutPanel flpItem1Buttons;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderBToolStripMenuItem;
        private System.Windows.Forms.Button btnRemoveItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnProcessResults;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.FlowLayoutPanel flpItem2Buttons;
        private System.Windows.Forms.Button btnSortItem2;
        private System.Windows.Forms.Button btnRemoveItem2;
        private System.Windows.Forms.ListBox lbItem2;
        private System.Windows.Forms.ListBox lbItem1;
    }
}