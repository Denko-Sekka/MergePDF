namespace PDFSingleMerger
{
    partial class PDFSingleMergeUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSingleMergeUC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSingleMergeUC
            // 
            this.btnSingleMergeUC.Location = new System.Drawing.Point(3, 3);
            this.btnSingleMergeUC.Name = "btnSingleMergeUC";
            this.btnSingleMergeUC.Size = new System.Drawing.Size(109, 37);
            this.btnSingleMergeUC.TabIndex = 0;
            this.btnSingleMergeUC.Text = "Single PDF Merge";
            this.btnSingleMergeUC.UseVisualStyleBackColor = true;
            this.btnSingleMergeUC.Click += new System.EventHandler(this.btnSingleMergeUC_Click);
            // 
            // PDFSingleMergeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnSingleMergeUC);
            this.Name = "PDFSingleMergeUC";
            this.Size = new System.Drawing.Size(115, 41);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingleMergeUC;
    }
}
