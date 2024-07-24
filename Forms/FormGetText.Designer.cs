namespace mouseutil
{
    partial class FormGetText
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
            this.input = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.noteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Location = new System.Drawing.Point(12, 31);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(210, 20);
            this.input.TabIndex = 0;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(183, 56);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(39, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(9, 9);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(74, 13);
            this.noteLabel.TabIndex = 9;
            this.noteLabel.Text = "Add new item:";
            // 
            // FormGetText
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 91);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.input);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(250, 130);
            this.MinimumSize = new System.Drawing.Size(250, 130);
            this.Name = "FormGetText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label noteLabel;
    }
}