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
            DataAccess db = new DataAccess();
            notes = db.GetNotes();
            notesListBox.DataSource= notes;
            notesListBox.DisplayMember = "Title";
            tbContent.Text = notesListBox.SelectedIndex.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

