namespace animouse
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.runDVDSetShortcut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.boxHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.boxWidth = new System.Windows.Forms.NumericUpDown();
            this.whitelistOpen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.speedY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.speedX = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.framerateNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addWhitelistSetShortcut = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.speedRandomMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.speedRandomMin = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxWidth)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedX)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.framerateNumeric)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedRandomMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedRandomMin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.runDVDSetShortcut);
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DVD mouse animation";
            // 
            // runDVDSetShortcut
            // 
            this.runDVDSetShortcut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runDVDSetShortcut.Location = new System.Drawing.Point(3, 16);
            this.runDVDSetShortcut.Name = "runDVDSetShortcut";
            this.runDVDSetShortcut.Size = new System.Drawing.Size(253, 33);
            this.runDVDSetShortcut.TabIndex = 0;
            this.runDVDSetShortcut.Text = "<Shortcut>";
            this.runDVDSetShortcut.UseVisualStyleBackColor = true;
            this.runDVDSetShortcut.Click += new System.EventHandler(this.RunDVDSetShortcut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(13, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bounds";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.Controls.Add(this.boxHeight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.boxWidth, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(247, 26);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // boxHeight
            // 
            this.boxHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxHeight.Location = new System.Drawing.Point(139, 3);
            this.boxHeight.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.boxHeight.Name = "boxHeight";
            this.boxHeight.Size = new System.Drawing.Size(105, 20);
            this.boxHeight.TabIndex = 3;
            this.boxHeight.ValueChanged += new System.EventHandler(this.BoxHeight_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(112, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxWidth
            // 
            this.boxWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxWidth.Location = new System.Drawing.Point(3, 3);
            this.boxWidth.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(103, 20);
            this.boxWidth.TabIndex = 2;
            this.boxWidth.ValueChanged += new System.EventHandler(this.BoxWidth_ValueChanged);
            // 
            // whitelistOpen
            // 
            this.whitelistOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.whitelistOpen.Location = new System.Drawing.Point(198, 391);
            this.whitelistOpen.Name = "whitelistOpen";
            this.whitelistOpen.Size = new System.Drawing.Size(75, 23);
            this.whitelistOpen.TabIndex = 100;
            this.whitelistOpen.Text = "Whitelist";
            this.whitelistOpen.UseVisualStyleBackColor = true;
            this.whitelistOpen.Click += new System.EventHandler(this.WhitelistOpen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(13, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speed";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel2.Controls.Add(this.speedY, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.speedX, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 26);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // speedY
            // 
            this.speedY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedY.Location = new System.Drawing.Point(139, 3);
            this.speedY.Name = "speedY";
            this.speedY.Size = new System.Drawing.Size(105, 20);
            this.speedY.TabIndex = 3;
            this.speedY.ValueChanged += new System.EventHandler(this.SpeedY_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(112, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedX
            // 
            this.speedX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedX.Location = new System.Drawing.Point(3, 3);
            this.speedX.Name = "speedX";
            this.speedX.Size = new System.Drawing.Size(103, 20);
            this.speedX.TabIndex = 2;
            this.speedX.ValueChanged += new System.EventHandler(this.SpeedX_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Location = new System.Drawing.Point(13, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 52);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Framerate";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel3.Controls.Add(this.framerateNumeric, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(247, 26);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // framerateNumeric
            // 
            this.framerateNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.framerateNumeric.Location = new System.Drawing.Point(3, 3);
            this.framerateNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.framerateNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.framerateNumeric.Name = "framerateNumeric";
            this.framerateNumeric.Size = new System.Drawing.Size(241, 20);
            this.framerateNumeric.TabIndex = 2;
            this.framerateNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.framerateNumeric.ValueChanged += new System.EventHandler(this.FramerateNumeric_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.addWhitelistSetShortcut);
            this.groupBox5.Location = new System.Drawing.Point(13, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 52);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add focus to the whitelist";
            // 
            // addWhitelistSetShortcut
            // 
            this.addWhitelistSetShortcut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addWhitelistSetShortcut.Location = new System.Drawing.Point(3, 16);
            this.addWhitelistSetShortcut.Name = "addWhitelistSetShortcut";
            this.addWhitelistSetShortcut.Size = new System.Drawing.Size(253, 33);
            this.addWhitelistSetShortcut.TabIndex = 0;
            this.addWhitelistSetShortcut.Text = "<Shortcut>";
            this.addWhitelistSetShortcut.UseVisualStyleBackColor = true;
            this.addWhitelistSetShortcut.Click += new System.EventHandler(this.AddWhitelistSetShortcut_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.tableLayoutPanel4);
            this.groupBox6.Location = new System.Drawing.Point(13, 273);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(259, 52);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Speed bouncing random";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel4.Controls.Add(this.speedRandomMax, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.speedRandomMin, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(247, 26);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // speedRandomMax
            // 
            this.speedRandomMax.DecimalPlaces = 2;
            this.speedRandomMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedRandomMax.Location = new System.Drawing.Point(139, 3);
            this.speedRandomMax.Name = "speedRandomMax";
            this.speedRandomMax.Size = new System.Drawing.Size(105, 20);
            this.speedRandomMax.TabIndex = 3;
            this.speedRandomMax.ValueChanged += new System.EventHandler(this.SpeedRandomMax_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(112, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedRandomMin
            // 
            this.speedRandomMin.DecimalPlaces = 2;
            this.speedRandomMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedRandomMin.Location = new System.Drawing.Point(3, 3);
            this.speedRandomMin.Name = "speedRandomMin";
            this.speedRandomMin.Size = new System.Drawing.Size(103, 20);
            this.speedRandomMin.TabIndex = 2;
            this.speedRandomMin.ValueChanged += new System.EventHandler(this.SpeedRandomMin_ValueChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 426);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.whitelistOpen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(300, 465);
            this.Name = "FormMain";
            this.Text = "Animouse - DVD mouse animation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxWidth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.framerateNumeric)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedRandomMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedRandomMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown boxWidth;
        private System.Windows.Forms.NumericUpDown boxHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runDVDSetShortcut;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button whitelistOpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown speedY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown speedX;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown framerateNumeric;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button addWhitelistSetShortcut;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown speedRandomMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown speedRandomMin;
    }
}

