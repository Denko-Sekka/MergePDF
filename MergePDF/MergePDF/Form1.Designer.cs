namespace MergePDF
{
    partial class Form1
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
            this.tlpB = new System.Windows.Forms.TableLayoutPanel();
            this.tlpA = new System.Windows.Forms.TableLayoutPanel();
            this.tlpC = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpMain.Controls.Add(this.tlpC, 4, 0);
            this.tlpMain.Controls.Add(this.tlpA, 0, 0);
            this.tlpMain.Controls.Add(this.tlpB, 2, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(983, 523);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpB
            // 
            this.tlpB.ColumnCount = 1;
            this.tlpB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpB.Location = new System.Drawing.Point(350, 3);
            this.tlpB.Name = "tlpB";
            this.tlpB.RowCount = 2;
            this.tlpB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpB.Size = new System.Drawing.Size(281, 517);
            this.tlpB.TabIndex = 0;
            // 
            // tlpA
            // 
            this.tlpA.ColumnCount = 1;
            this.tlpA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpA.Location = new System.Drawing.Point(3, 3);
            this.tlpA.Name = "tlpA";
            this.tlpA.RowCount = 2;
            this.tlpA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpA.Size = new System.Drawing.Size(281, 517);
            this.tlpA.TabIndex = 1;
            // 
            // tlpC
            // 
            this.tlpC.ColumnCount = 1;
            this.tlpC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpC.Location = new System.Drawing.Point(697, 3);
            this.tlpC.Name = "tlpC";
            this.tlpC.RowCount = 2;
            this.tlpC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpC.Size = new System.Drawing.Size(283, 517);
            this.tlpC.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 523);
            this.Controls.Add(this.tlpMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpC;
        private System.Windows.Forms.TableLayoutPanel tlpA;
        private System.Windows.Forms.TableLayoutPanel tlpB;
    }
}

