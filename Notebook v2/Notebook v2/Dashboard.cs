using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook_v2
{
    public partial class Dashboard : Form
    {
        List<Note> notes;
        bool editing = false;
        public Dashboard()
        {
            InitializeComponent();    
            updateBinding();
            saveNoteBtn.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void notesListBox_DoubleClick(object sender, EventArgs e)
        {
            tbTitle.Text = notes[Helper.GetNoteIndex(notesListBox)].Title;
            tbContent.Text = notes[Helper.GetNoteIndex(notesListBox)].Contents;
            editing= true;
        }
        private void ClearText()
        {
            tbContent.Text = string.Empty;
            tbTitle.Text = string.Empty;
        }
        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            editing = false;
        }

        private void saveNoteBtn_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                editNote();
            }
            else
            {
                saveNote();
            }
        }
        private void updateBinding()
        {
            DataAccess db = new DataAccess();
            notes = db.GetNotes();
            notesListBox.DataSource = notes;
            notesListBox.DisplayMember = "Title";
        }

        private void delNoteBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int noteToDeleteIndex = db.GetNoteId(notesListBox);
            Note noteToDelete = notes[noteToDeleteIndex];
            db.DeleteNote(noteToDelete);
            updateBinding();
            ClearText();
        }
        private void saveNote()
        {
            DataAccess db = new DataAccess();
            db.saveNote(tbTitle.Text, tbContent.Text);
            ClearText();
            updateBinding();
        }
        private void editNote()
        {
            string newTitle = tbTitle.Text;
            string newContents = tbContent.Text;
            DataAccess db = new DataAccess();
            int noteToEditIndex = db.GetNoteId(notesListBox);
            Note noteToEdit = notes[noteToEditIndex];
            db.EditNote(noteToEdit, newTitle, newContents);
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            if (tbTitle.Text == string.Empty) 
            {
                saveNoteBtn.Enabled = false;
            }
            else
            {
                saveNoteBtn.Enabled = true;
            }
        }
    }
}

