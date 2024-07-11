namespace animouse
{
    partial class FormGetShortcut
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
            this.okButton = new System.Windows.Forms.Button();
            this.noteLabel = new System.Windows.Forms.Label();
            this.shortcutValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(183, 56);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(39, 23);
            this.okButton.TabIndex = 1;
            this.okButton.TabStop = false;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.UpdateShortcutLabel);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(9, 9);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(149, 13);
            this.noteLabel.TabIndex = 9;
            this.noteLabel.Text = "Press keys to set the shortcut:";
            // 
            // shortcutValue
            // 
            this.shortcutValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shortcutValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.shortcutValue.Location = new System.Drawing.Point(12, 28);
            this.shortcutValue.Name = "shortcutValue";
            this.shortcutValue.Size = new System.Drawing.Size(210, 25);
            this.shortcutValue.TabIndex = 0;
            this.shortcutValue.Text = "<Shortcut>";
            this.shortcutValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGetShortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 91);
            this.Controls.Add(this.shortcutValue);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(250, 130);
            this.MinimumSize = new System.Drawing.Size(250, 130);
            this.Name = "FormGetShortcut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New shortcut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label shortcutValue;
    }
}