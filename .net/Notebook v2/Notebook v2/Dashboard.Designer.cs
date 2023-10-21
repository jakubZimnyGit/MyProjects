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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbContent
            // 
            this.tbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContent.Location = new System.Drawing.Point(402, 104);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(352, 486);
            this.tbContent.TabIndex = 0;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(402, 41);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(352, 20);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // notesListBox
            // 
            this.notesListBox.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.ItemHeight = 26;
            this.notesListBox.Location = new System.Drawing.Point(12, 41);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notesListBox.Size = new System.Drawing.Size(368, 316);
            this.notesListBox.TabIndex = 3;
            this.notesListBox.DoubleClick += new System.EventHandler(this.notesListBox_DoubleClick);
            // 
            // newNoteBtn
            // 
            this.newNoteBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newNoteBtn.Location = new System.Drawing.Point(33, 389);
            this.newNoteBtn.Name = "newNoteBtn";
            this.newNoteBtn.Size = new System.Drawing.Size(154, 95);
            this.newNoteBtn.TabIndex = 4;
            this.newNoteBtn.Text = "New note";
            this.newNoteBtn.UseVisualStyleBackColor = true;
            this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
            // 
            // saveNoteBtn
            // 
            this.saveNoteBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveNoteBtn.Location = new System.Drawing.Point(217, 389);
            this.saveNoteBtn.Name = "saveNoteBtn";
            this.saveNoteBtn.Size = new System.Drawing.Size(154, 95);
            this.saveNoteBtn.TabIndex = 5;
            this.saveNoteBtn.Text = "Save note";
            this.saveNoteBtn.UseVisualStyleBackColor = true;
            this.saveNoteBtn.Click += new System.EventHandler(this.saveNoteBtn_Click);
            // 
            // delNoteBtn
            // 
            this.delNoteBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.delNoteBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delNoteBtn.Location = new System.Drawing.Point(33, 508);
            this.delNoteBtn.Name = "delNoteBtn";
            this.delNoteBtn.Size = new System.Drawing.Size(338, 82);
            this.delNoteBtn.TabIndex = 6;
            this.delNoteBtn.Text = "Delete note";
            this.delNoteBtn.UseVisualStyleBackColor = true;
            this.delNoteBtn.Click += new System.EventHandler(this.delNoteBtn_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(397, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(50, 21);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Title";
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.Location = new System.Drawing.Point(397, 76);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(80, 21);
            this.labelContent.TabIndex = 9;
            this.labelContent.Text = "Content";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(783, 668);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.labelTitle);
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
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelContent;
    }
}

