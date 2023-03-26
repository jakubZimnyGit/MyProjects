using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Notebook_v2
{
    public class DataAccess
    {
        public List<Note> GetNotes()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NoteDB")))
            {
                var output = connection.Query<Note>("dbo.Note_GetAll").ToList();
                return output;
   
            }
        }

        public void saveNote(string Title, string Contents)
        {
            int id = setId();
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NoteDB")))
            {
                List<Note> notes = new List<Note>();
                notes.Add( new Note { id = id,Title = Title, Contents = Contents, Created = DateTime.Now.Date });
                connection.Execute("dbo.Note_Insert @id, @Title, @Contents, @Created", notes);
            }
        }
        public int GetNoteId(ListBox listBox)
        {        
                int noteToDelelteIndex = listBox.SelectedIndex;
                return noteToDelelteIndex;    
        }
        public void DeleteNote(Note noteToDelete)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NoteDB")))
            {
                List<Note> notes = new List<Note>();
                notes.Add(noteToDelete);
                connection.Execute("dbo.Note_Delete @id", notes);
            }
        }
        public void EditNote(Note note, string Title, string Contents)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NoteDB")))
            {
                List<Note> notes = new List<Note>();
                notes.Add(new Note { id = note.id, Title = Title, Contents = Contents });
                connection.Execute("dbo.Note_Edit @id, @Title, @Contents", notes);
            }
        }
        private int setId()
        {
            List<Note> Notes = GetNotes();
            int id = 1;
            if (Notes.Count != 0)
            {
                id = Notes[Notes.Count - 1].id + 1;
            }
            return id;
        }
    }
}
