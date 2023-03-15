namespace Notebook_v2
{
    partial class Dashboard
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
            this.tbContent = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.newNoteBtn = new System.Windows.Forms.Button();
            this.saveNoteBtn = new System.Windows.Forms.Button();
            this.delNoteBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(344, 104);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(352, 486);
            this.tbContent.TabIndex = 0;
            this.tbContent.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(344, 41);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(352, 20);
            this.tbTitle.TabIndex = 2;
            // 
            // notesListBox
            // 
            this.notesListBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.ItemHeight = 33;
            this.notesListBox.Location = new System.Drawing.Point(12, 41);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(300, 334);
            this.notesListBox.TabIndex = 3;
            this.notesListBox.DoubleClick += new System.EventHandler(this.notesListBox_DoubleClick);
            // 
            // newNoteBtn
            // 
            this.newNoteBtn.Location = new System.Drawing.Point(12, 425);
            this.newNoteBtn.Name = "newNoteBtn";
            this.newNoteBtn.Size = new System.Drawing.Size(137, 76);
            this.newNoteBtn.TabIndex = 4;
            this.newNoteBtn.Text = "New note";
            this.newNoteBtn.UseVisualStyleBackColor = true;
            this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
            // 
            // saveNoteBtn
            // 
            this.saveNoteBtn.Location = new System.Drawing.Point(174, 425);
            this.saveNoteBtn.Name = "saveNoteBtn";
            this.saveNoteBtn.Size = new System.Drawing.Size(137, 76);
            this.saveNoteBtn.TabIndex = 5;
            this.saveNoteBtn.Text = "Save note";
            this.saveNoteBtn.UseVisualStyleBackColor = true;
            this.saveNoteBtn.Click += new System.EventHandler(this.saveNoteBtn_Click);
            // 
            // delNoteBtn
            // 
            this.delNoteBtn.Location = new System.Drawing.Point(12, 525);
            this.delNoteBtn.Name = "delNoteBtn";
            this.delNoteBtn.Size = new System.Drawing.Size(137, 76);
            this.delNoteBtn.TabIndex = 6;
            this.delNoteBtn.Text = "Delete note";
            this.delNoteBtn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 525);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 76);
            this.button4.TabIndex = 7;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 668);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.delNoteBtn);
            this.Controls.Add(this.saveNoteBtn);
            this.Controls.Add(this.newNoteBtn);
            this.Controls.Add(this.notesListBox);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbContent);
            this.Name = "Dashboard";
            this.Text = "Notebook v2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.ListBox notesListBox;
        private System.Windows.Forms.Button newNoteBtn;
        private System.Windows.Forms.Button saveNoteBtn;
        private System.Windows.Forms.Button delNoteBtn;
        private System.Windows.Forms.Button button4;
    }
}

