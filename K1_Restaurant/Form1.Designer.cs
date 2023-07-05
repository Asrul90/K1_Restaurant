namespace K1_Restaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dATA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATA2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATA3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATA4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATA5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(0, 28);
            this.toolStripButton1.Text = "DATA MASTER";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dATA1ToolStripMenuItem,
            this.dATA2ToolStripMenuItem,
            this.dATA3ToolStripMenuItem,
            this.dATA4ToolStripMenuItem,
            this.dATA5ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // dATA1ToolStripMenuItem
            // 
            this.dATA1ToolStripMenuItem.Name = "dATA1ToolStripMenuItem";
            this.dATA1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dATA1ToolStripMenuItem.Text = "DATA 1";
            // 
            // dATA2ToolStripMenuItem
            // 
            this.dATA2ToolStripMenuItem.Name = "dATA2ToolStripMenuItem";
            this.dATA2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dATA2ToolStripMenuItem.Text = "DATA 2";
            // 
            // dATA3ToolStripMenuItem
            // 
            this.dATA3ToolStripMenuItem.Name = "dATA3ToolStripMenuItem";
            this.dATA3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dATA3ToolStripMenuItem.Text = "DATA 3";
            // 
            // dATA4ToolStripMenuItem
            // 
            this.dATA4ToolStripMenuItem.Name = "dATA4ToolStripMenuItem";
            this.dATA4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dATA4ToolStripMenuItem.Text = "DATA 4";
            // 
            // dATA5ToolStripMenuItem
            // 
            this.dATA5ToolStripMenuItem.Name = "dATA5ToolStripMenuItem";
            this.dATA5ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dATA5ToolStripMenuItem.Text = "DATA 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "DATA MASTER";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dATA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATA2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATA3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATA4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATA5ToolStripMenuItem;
    }
}

