namespace Notebook
{
    partial class Notebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notebook));
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.previosNotes = new System.Windows.Forms.DataGridView();
            this.saveToDirectory = new System.Windows.Forms.ComboBox();
            this.loadFromDirectory = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NewNoteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previosNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(234, 68);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(403, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(234, 114);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(403, 440);
            this.tbNote.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(30, 298);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(163, 120);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // previosNotes
            // 
            this.previosNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previosNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previosNotes.Location = new System.Drawing.Point(676, 284);
            this.previosNotes.MultiSelect = false;
            this.previosNotes.Name = "previosNotes";
            this.previosNotes.ReadOnly = true;
            this.previosNotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.previosNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.previosNotes.Size = new System.Drawing.Size(240, 270);
            this.previosNotes.TabIndex = 5;
            
            this.previosNotes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previosNotes_CellContentDoubleClick);
            // 
            // saveToDirectory
            // 
            this.saveToDirectory.FormattingEnabled = true;
            this.saveToDirectory.Location = new System.Drawing.Point(30, 114);
            this.saveToDirectory.Name = "saveToDirectory";
            this.saveToDirectory.Size = new System.Drawing.Size(163, 21);
            this.saveToDirectory.TabIndex = 6;
            // 
            // loadFromDirectory
            // 
            this.loadFromDirectory.FormattingEnabled = true;
            this.loadFromDirectory.Location = new System.Drawing.Point(676, 235);
            this.loadFromDirectory.Name = "loadFromDirectory";
            this.loadFromDirectory.Size = new System.Drawing.Size(233, 21);
            this.loadFromDirectory.TabIndex = 7;
            this.loadFromDirectory.SelectedIndexChanged += new System.EventHandler(this.loadFromDirectory_SelectedIndexChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(30, 434);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(163, 120);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(231, 47);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(35, 18);
            this.Title.TabIndex = 9;
            this.Title.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(231, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose the catalog to save note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(673, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Choose the catalog to find the Note";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add new class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddNewClassBtn);
            // 
            // NewNoteBtn
            // 
            this.NewNoteBtn.Location = new System.Drawing.Point(30, 164);
            this.NewNoteBtn.Name = "NewNoteBtn";
            this.NewNoteBtn.Size = new System.Drawing.Size(163, 120);
            this.NewNoteBtn.TabIndex = 14;
            this.NewNoteBtn.Text = "New Note";
            this.NewNoteBtn.UseVisualStyleBackColor = true;
            this.NewNoteBtn.Click += new System.EventHandler(this.NewNoteBtn_Click);
            // 
            // Notebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 587);
            this.Controls.Add(this.NewNoteBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.loadFromDirectory);
            this.Controls.Add(this.saveToDirectory);
            this.Controls.Add(this.previosNotes);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notebook";
            this.Text = "Notebook";
            this.Load += new System.EventHandler(this.Notebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previosNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView previosNotes;
        private System.Windows.Forms.ComboBox saveToDirectory;
        private System.Windows.Forms.ComboBox loadFromDirectory;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NewNoteBtn;
    }
}

