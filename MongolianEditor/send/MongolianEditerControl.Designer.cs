namespace MongolianEditer
{
    partial class MongolianEditerControl
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
            this.textBoxEditor = new System.Windows.Forms.TextBox();
            this.checkBoxSwitch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonSet
            // 
            this.buttonSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSet.Location = new System.Drawing.Point(184, 33);
            this.buttonSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(28, 31);
            this.buttonSet.TabIndex = 6;
            this.buttonSet.Text = "►";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxEditor
            // 
            this.textBoxEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxEditor.Location = new System.Drawing.Point(11, 13);
            this.textBoxEditor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEditor.Multiline = true;
            this.textBoxEditor.Name = "textBoxEditor";
            this.textBoxEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEditor.Size = new System.Drawing.Size(170, 199);
            this.textBoxEditor.TabIndex = 4;
            // 
            // checkBoxSwitch
            // 
            this.checkBoxSwitch.AutoSize = true;
            this.checkBoxSwitch.Location = new System.Drawing.Point(184, 15);
            this.checkBoxSwitch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSwitch.Name = "checkBoxSwitch";
            this.checkBoxSwitch.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSwitch.TabIndex = 8;
            this.checkBoxSwitch.UseVisualStyleBackColor = true;
            this.checkBoxSwitch.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MongolianEditerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxSwitch);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.textBoxEditor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MongolianEditerControl";
            this.Size = new System.Drawing.Size(235, 224);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.TextBox textBoxEditor;
        private System.Windows.Forms.CheckBox checkBoxSwitch;

    }
}
