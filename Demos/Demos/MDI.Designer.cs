namespace Demos
{
    partial class MDI
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
            this.btn_RadioButton = new System.Windows.Forms.Button();
            this.btn_CheckBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_RadioButton
            // 
            this.btn_RadioButton.Location = new System.Drawing.Point(12, 12);
            this.btn_RadioButton.Name = "btn_RadioButton";
            this.btn_RadioButton.Size = new System.Drawing.Size(247, 57);
            this.btn_RadioButton.TabIndex = 0;
            this.btn_RadioButton.Text = "RadioButton_Demo";
            this.btn_RadioButton.UseVisualStyleBackColor = true;
            this.btn_RadioButton.Click += new System.EventHandler(this.btn_RadioButton_Click);
            // 
            // btn_CheckBox
            // 
            this.btn_CheckBox.Location = new System.Drawing.Point(285, 12);
            this.btn_CheckBox.Name = "btn_CheckBox";
            this.btn_CheckBox.Size = new System.Drawing.Size(247, 57);
            this.btn_CheckBox.TabIndex = 1;
            this.btn_CheckBox.Text = "CheckBox_Demo";
            this.btn_CheckBox.UseVisualStyleBackColor = true;
            this.btn_CheckBox.Click += new System.EventHandler(this.btn_CheckBox_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1061, 763);
            this.Controls.Add(this.btn_CheckBox);
            this.Controls.Add(this.btn_RadioButton);
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RadioButton;
        private System.Windows.Forms.Button btn_CheckBox;
    }
}