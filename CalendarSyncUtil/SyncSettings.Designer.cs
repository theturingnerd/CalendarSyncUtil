namespace CalendarSyncUtil
{
    partial class SyncSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyncSettings));
            this.pairList = new System.Windows.Forms.ListBox();
            this.addPair = new System.Windows.Forms.Button();
            this.RemovePair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceId = new System.Windows.Forms.TextBox();
            this.targetId = new System.Windows.Forms.TextBox();
            this.pickSource = new System.Windows.Forms.LinkLabel();
            this.pickTarget = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cleanCalButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.isMaskedTargetCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pairList
            // 
            this.pairList.FormattingEnabled = true;
            this.pairList.Location = new System.Drawing.Point(2, 156);
            this.pairList.Name = "pairList";
            this.pairList.Size = new System.Drawing.Size(879, 290);
            this.pairList.TabIndex = 0;
            // 
            // addPair
            // 
            this.addPair.Location = new System.Drawing.Point(757, 34);
            this.addPair.Name = "addPair";
            this.addPair.Size = new System.Drawing.Size(107, 23);
            this.addPair.TabIndex = 2;
            this.addPair.Text = "Add Pair";
            this.addPair.UseVisualStyleBackColor = true;
            this.addPair.Click += new System.EventHandler(this.addPair_Click);
            // 
            // RemovePair
            // 
            this.RemovePair.Location = new System.Drawing.Point(757, 127);
            this.RemovePair.Name = "RemovePair";
            this.RemovePair.Size = new System.Drawing.Size(107, 23);
            this.RemovePair.TabIndex = 4;
            this.RemovePair.Text = "Remove Pair";
            this.RemovePair.UseVisualStyleBackColor = true;
            this.RemovePair.Click += new System.EventHandler(this.RemovePair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Target:";
            // 
            // sourceId
            // 
            this.sourceId.Enabled = false;
            this.sourceId.Location = new System.Drawing.Point(72, 20);
            this.sourceId.Name = "sourceId";
            this.sourceId.Size = new System.Drawing.Size(613, 20);
            this.sourceId.TabIndex = 7;
            // 
            // targetId
            // 
            this.targetId.Enabled = false;
            this.targetId.Location = new System.Drawing.Point(72, 52);
            this.targetId.Name = "targetId";
            this.targetId.Size = new System.Drawing.Size(613, 20);
            this.targetId.TabIndex = 8;
            // 
            // pickSource
            // 
            this.pickSource.AutoSize = true;
            this.pickSource.Location = new System.Drawing.Point(691, 23);
            this.pickSource.Name = "pickSource";
            this.pickSource.Size = new System.Drawing.Size(37, 13);
            this.pickSource.TabIndex = 9;
            this.pickSource.TabStop = true;
            this.pickSource.Text = "Pick...";
            this.pickSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pickSource_LinkClicked);
            // 
            // pickTarget
            // 
            this.pickTarget.AutoSize = true;
            this.pickTarget.Location = new System.Drawing.Point(691, 56);
            this.pickTarget.Name = "pickTarget";
            this.pickTarget.Size = new System.Drawing.Size(37, 13);
            this.pickTarget.TabIndex = 10;
            this.pickTarget.TabStop = true;
            this.pickTarget.Text = "Pick...";
            this.pickTarget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pickTarget_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(631, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "To add a new pair, choose a source and target, then click \"Add Pair\". To delete a" +
    " pair, highlight it in the list and click \"Remove Pair\"";
            // 
            // cleanCalButton
            // 
            this.cleanCalButton.ForeColor = System.Drawing.Color.Red;
            this.cleanCalButton.Location = new System.Drawing.Point(2, 127);
            this.cleanCalButton.Name = "cleanCalButton";
            this.cleanCalButton.Size = new System.Drawing.Size(119, 23);
            this.cleanCalButton.TabIndex = 12;
            this.cleanCalButton.Text = "CLEAN Calendar";
            this.cleanCalButton.UseVisualStyleBackColor = true;
            this.cleanCalButton.Click += new System.EventHandler(this.cleanCalButton_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(127, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Prefix CLEAN Calendar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isMaskedTargetCheckBox
            // 
            this.isMaskedTargetCheckBox.AutoSize = true;
            this.isMaskedTargetCheckBox.Location = new System.Drawing.Point(648, 78);
            this.isMaskedTargetCheckBox.Name = "isMaskedTargetCheckBox";
            this.isMaskedTargetCheckBox.Size = new System.Drawing.Size(92, 17);
            this.isMaskedTargetCheckBox.TabIndex = 14;
            this.isMaskedTargetCheckBox.Text = "Mask Target?";
            this.isMaskedTargetCheckBox.UseVisualStyleBackColor = true;
            // 
            // SyncSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.isMaskedTargetCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cleanCalButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pickTarget);
            this.Controls.Add(this.pickSource);
            this.Controls.Add(this.targetId);
            this.Controls.Add(this.sourceId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemovePair);
            this.Controls.Add(this.addPair);
            this.Controls.Add(this.pairList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SyncSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sync Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SyncSettings_FormClosing);
            this.Load += new System.EventHandler(this.SyncSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pairList;
        private System.Windows.Forms.Button addPair;
        private System.Windows.Forms.Button RemovePair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sourceId;
        private System.Windows.Forms.TextBox targetId;
        private System.Windows.Forms.LinkLabel pickSource;
        private System.Windows.Forms.LinkLabel pickTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cleanCalButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox isMaskedTargetCheckBox;
    }
}