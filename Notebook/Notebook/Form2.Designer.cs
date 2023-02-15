namespace Notebook
{
    partial class Form2
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbNewClassName = new System.Windows.Forms.TextBox();
            this.saveClassBtn = new System.Windows.Forms.Button();
            this.CancelSavingClassBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNewClassName
            // 
            this.tbNewClassName.Location = new System.Drawing.Point(21, 30);
            this.tbNewClassName.Multiline = true;
            this.tbNewClassName.Name = "tbNewClassName";
            this.tbNewClassName.Size = new System.Drawing.Size(304, 45);
            this.tbNewClassName.TabIndex = 0;
            // 
            // saveClassBtn
            // 
            this.saveClassBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveClassBtn.Location = new System.Drawing.Point(217, 119);
            this.saveClassBtn.Name = "saveClassBtn";
            this.saveClassBtn.Size = new System.Drawing.Size(108, 45);
            this.saveClassBtn.TabIndex = 1;
            this.saveClassBtn.Text = "Save";
            this.saveClassBtn.UseVisualStyleBackColor = true;
            this.saveClassBtn.Click += new System.EventHandler(this.saveClassBtn_Click);
            // 
            // CancelSavingClassBtn
            // 
            this.CancelSavingClassBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelSavingClassBtn.Location = new System.Drawing.Point(21, 119);
            this.CancelSavingClassBtn.Name = "CancelSavingClassBtn";
            this.CancelSavingClassBtn.Size = new System.Drawing.Size(108, 45);
            this.CancelSavingClassBtn.TabIndex = 2;
            this.CancelSavingClassBtn.Text = "Cancel";
            this.CancelSavingClassBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "New topic:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelSavingClassBtn);
            this.Controls.Add(this.saveClassBtn);
            this.Controls.Add(this.tbNewClassName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox tbNewClassName;
        private System.Windows.Forms.Button saveClassBtn;
        private System.Windows.Forms.Button CancelSavingClassBtn;
        private System.Windows.Forms.Label label1;
    }
}