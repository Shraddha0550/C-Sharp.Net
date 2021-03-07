namespace Demos
{
    partial class CheckBox_Demo
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
            this.cb_C = new System.Windows.Forms.CheckBox();
            this.cb_Java = new System.Windows.Forms.CheckBox();
            this.cb_Cpp = new System.Windows.Forms.CheckBox();
            this.cb_Python = new System.Windows.Forms.CheckBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Course = new System.Windows.Forms.GroupBox();
            this.gb_Course.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_C
            // 
            this.cb_C.AutoSize = true;
            this.cb_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_C.Location = new System.Drawing.Point(47, 59);
            this.cb_C.Name = "cb_C";
            this.cb_C.Size = new System.Drawing.Size(49, 29);
            this.cb_C.TabIndex = 0;
            this.cb_C.Text = "C";
            this.cb_C.UseVisualStyleBackColor = true;
            // 
            // cb_Java
            // 
            this.cb_Java.AutoSize = true;
            this.cb_Java.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Java.Location = new System.Drawing.Point(47, 138);
            this.cb_Java.Name = "cb_Java";
            this.cb_Java.Size = new System.Drawing.Size(77, 29);
            this.cb_Java.TabIndex = 1;
            this.cb_Java.Text = "Java";
            this.cb_Java.UseVisualStyleBackColor = true;
            // 
            // cb_Cpp
            // 
            this.cb_Cpp.AutoSize = true;
            this.cb_Cpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Cpp.Location = new System.Drawing.Point(170, 59);
            this.cb_Cpp.Name = "cb_Cpp";
            this.cb_Cpp.Size = new System.Drawing.Size(66, 29);
            this.cb_Cpp.TabIndex = 2;
            this.cb_Cpp.Text = "cpp";
            this.cb_Cpp.UseVisualStyleBackColor = true;
            // 
            // cb_Python
            // 
            this.cb_Python.AutoSize = true;
            this.cb_Python.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Python.Location = new System.Drawing.Point(170, 138);
            this.cb_Python.Name = "cb_Python";
            this.cb_Python.Size = new System.Drawing.Size(95, 29);
            this.cb_Python.TabIndex = 3;
            this.cb_Python.Text = "Python";
            this.cb_Python.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(163, 410);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(151, 57);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gb_Course
            // 
            this.gb_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gb_Course.Controls.Add(this.cb_C);
            this.gb_Course.Controls.Add(this.cb_Cpp);
            this.gb_Course.Controls.Add(this.cb_Python);
            this.gb_Course.Controls.Add(this.cb_Java);
            this.gb_Course.Location = new System.Drawing.Point(90, 95);
            this.gb_Course.Name = "gb_Course";
            this.gb_Course.Size = new System.Drawing.Size(350, 261);
            this.gb_Course.TabIndex = 5;
            this.gb_Course.TabStop = false;
            this.gb_Course.Text = "Select Course : ";
            // 
            // CheckBox_Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 501);
            this.Controls.Add(this.gb_Course);
            this.Controls.Add(this.btn_Save);
            this.Name = "CheckBox_Demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gb_Course.ResumeLayout(false);
            this.gb_Course.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_C;
        private System.Windows.Forms.CheckBox cb_Java;
        private System.Windows.Forms.CheckBox cb_Cpp;
        private System.Windows.Forms.CheckBox cb_Python;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gb_Course;
    }
}