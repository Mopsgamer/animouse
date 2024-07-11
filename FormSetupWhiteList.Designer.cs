namespace animouse
{
    partial class FormSetupWhiteList
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
            this.components = new System.ComponentModel.Container();
            this.okButton = new System.Windows.Forms.Button();
            this.whitelistContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.runningListBox = new System.Windows.Forms.ListBox();
            this.runningContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableMain3Cols = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.whiteListBox = new System.Windows.Forms.ListBox();
            this.useProcWhitelist = new System.Windows.Forms.CheckBox();
            this.whitelistContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.runningContextMenu.SuspendLayout();
            this.tableMain3Cols.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(333, 181);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(39, 23);
            this.okButton.TabIndex = 7;
            this.okButton.TabStop = false;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // whitelistContextMenu
            // 
            this.whitelistContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.whitelistContextMenu.Name = "contextMenuStrip1";
            this.whitelistContextMenu.Size = new System.Drawing.Size(174, 48);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.runningListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 132);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processes";
            // 
            // runningListBox
            // 
            this.runningListBox.CausesValidation = false;
            this.runningListBox.ContextMenuStrip = this.runningContextMenu;
            this.runningListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runningListBox.Location = new System.Drawing.Point(3, 16);
            this.runningListBox.Name = "runningListBox";
            this.runningListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.runningListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.runningListBox.Size = new System.Drawing.Size(168, 113);
            this.runningListBox.Sorted = true;
            this.runningListBox.TabIndex = 1;
            // 
            // runningContextMenu
            // 
            this.runningContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allowToolStripMenuItem,
            this.rejectToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem});
            this.runningContextMenu.Name = "runningContextMenu";
            this.runningContextMenu.Size = new System.Drawing.Size(187, 76);
            // 
            // allowToolStripMenuItem
            // 
            this.allowToolStripMenuItem.Name = "allowToolStripMenuItem";
            this.allowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.allowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.allowToolStripMenuItem.Text = "Allow";
            this.allowToolStripMenuItem.Click += new System.EventHandler(this.allowToolStripMenuItem_Click);
            // 
            // rejectToolStripMenuItem
            // 
            this.rejectToolStripMenuItem.Name = "rejectToolStripMenuItem";
            this.rejectToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.rejectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.rejectToolStripMenuItem.Text = "Reject";
            this.rejectToolStripMenuItem.Click += new System.EventHandler(this.rejectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // tableMain3Cols
            // 
            this.tableMain3Cols.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain3Cols.ColumnCount = 2;
            this.tableMain3Cols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain3Cols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain3Cols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain3Cols.Controls.Add(this.groupBox3, 0, 0);
            this.tableMain3Cols.Controls.Add(this.groupBox1, 0, 0);
            this.tableMain3Cols.Location = new System.Drawing.Point(12, 12);
            this.tableMain3Cols.Name = "tableMain3Cols";
            this.tableMain3Cols.RowCount = 1;
            this.tableMain3Cols.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain3Cols.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableMain3Cols.Size = new System.Drawing.Size(360, 138);
            this.tableMain3Cols.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.whiteListBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(183, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 132);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Whitelist";
            // 
            // whiteListBox
            // 
            this.whiteListBox.CausesValidation = false;
            this.whiteListBox.ContextMenuStrip = this.whitelistContextMenu;
            this.whiteListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whiteListBox.Location = new System.Drawing.Point(3, 16);
            this.whiteListBox.Name = "whiteListBox";
            this.whiteListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.whiteListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.whiteListBox.Size = new System.Drawing.Size(168, 113);
            this.whiteListBox.Sorted = true;
            this.whiteListBox.TabIndex = 1;
            // 
            // useProcWhitelist
            // 
            this.useProcWhitelist.AutoSize = true;
            this.useProcWhitelist.Location = new System.Drawing.Point(12, 156);
            this.useProcWhitelist.Name = "useProcWhitelist";
            this.useProcWhitelist.Size = new System.Drawing.Size(65, 17);
            this.useProcWhitelist.TabIndex = 11;
            this.useProcWhitelist.Text = "Enabled";
            this.useProcWhitelist.UseVisualStyleBackColor = true;
            this.useProcWhitelist.CheckedChanged += new System.EventHandler(this.useProcWhitelist_CheckedChanged);
            // 
            // FormSetupWhiteList
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 216);
            this.Controls.Add(this.useProcWhitelist);
            this.Controls.Add(this.tableMain3Cols);
            this.Controls.Add(this.okButton);
            this.MaximumSize = new System.Drawing.Size(400, 999999);
            this.MinimumSize = new System.Drawing.Size(400, 255);
            this.Name = "FormSetupWhiteList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Whitelist processes";
            this.whitelistContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.runningContextMenu.ResumeLayout(false);
            this.tableMain3Cols.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox runningListBox;
        private System.Windows.Forms.TableLayoutPanel tableMain3Cols;
        private System.Windows.Forms.ContextMenuStrip whitelistContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip runningContextMenu;
        private System.Windows.Forms.ToolStripMenuItem allowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox whiteListBox;
        private System.Windows.Forms.CheckBox useProcWhitelist;
    }
}