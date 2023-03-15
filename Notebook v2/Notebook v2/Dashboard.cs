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
        public Dashboard()
        {
            InitializeComponent();    
            updateBinding();         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void notesListBox_DoubleClick(object sender, EventArgs e)
        {
            tbTitle.Text = notes[Helper.GetNoteIndex(notesListBox)].Title;
            tbContent.Text = notes[Helper.GetNoteIndex(notesListBox)].Contents;  
        }

        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            tbContent.Text = string.Empty; 
            tbTitle.Text = string.Empty;
        }

        private void saveNoteBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.saveNote(tbTitle.Text, tbContent.Text);
            tbContent.Text = string.Empty;
            tbTitle.Text = string.Empty;
            updateBinding();
        }
        private void updateBinding()
        {
            DataAccess db = new DataAccess();
            notes = db.GetNotes();
            notesListBox.DataSource = notes;
            notesListBox.DisplayMember = "Title";
        }
    }
}

