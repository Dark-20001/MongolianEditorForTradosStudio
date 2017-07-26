namespace MongolianEditor
{
    partial class MongolianEditorControl
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
            this.buttonSet = new System.Windows.Forms.Button();
            this.checkBoxSwitch = new System.Windows.Forms.CheckBox();
            this.mnTextView1 = new MongolDotNet.MnTextView();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonSet
            // 
            this.buttonSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSet.Location = new System.Drawing.Point(204, 11);
            this.buttonSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(37, 38);
            this.buttonSet.TabIndex = 6;
            this.buttonSet.Text = "►";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxSwitch
            // 
            this.checkBoxSwitch.AutoSize = true;
            this.checkBoxSwitch.Location = new System.Drawing.Point(16, 9);
            this.checkBoxSwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSwitch.Name = "checkBoxSwitch";
            this.checkBoxSwitch.Size = new System.Drawing.Size(60, 21);
            this.checkBoxSwitch.TabIndex = 8;
            this.checkBoxSwitch.Text = "Start";
            this.checkBoxSwitch.UseVisualStyleBackColor = true;
            this.checkBoxSwitch.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // mnTextView1
            // 
            this.mnTextView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mnTextView1.EditMode = true;
            this.mnTextView1.Location = new System.Drawing.Point(16, 59);
            this.mnTextView1.Multiline = true;
            this.mnTextView1.Name = "mnTextView1";
            this.mnTextView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnTextView1.ShowFocusRect = false;
            this.mnTextView1.Size = new System.Drawing.Size(225, 597);
            this.mnTextView1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(135, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(16, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "RTL";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // MongolianEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mnTextView1);
            this.Controls.Add(this.checkBoxSwitch);
            this.Controls.Add(this.buttonSet);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MongolianEditorControl";
            this.Size = new System.Drawing.Size(261, 669);
            this.Load += new System.EventHandler(this.MongolianEditorControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.CheckBox checkBoxSwitch;
        private MongolDotNet.MnTextView mnTextView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
