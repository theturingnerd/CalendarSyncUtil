namespace CalendarSyncUtil
{
    partial class SyncProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyncProgress));
            this.syncLogBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // syncLogBox
            // 
            this.syncLogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syncLogBox.FormattingEnabled = true;
            this.syncLogBox.Location = new System.Drawing.Point(0, 0);
            this.syncLogBox.Name = "syncLogBox";
            this.syncLogBox.Size = new System.Drawing.Size(800, 450);
            this.syncLogBox.TabIndex = 0;
            // 
            // SyncProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.syncLogBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SyncProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synchronization in Progress....";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SyncProgress_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox syncLogBox;
    }
}