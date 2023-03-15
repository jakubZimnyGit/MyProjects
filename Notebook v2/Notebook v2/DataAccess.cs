using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
                var output =  connection.Query<Note>("dbo.Note_GetAll").ToList();
                return output;
   
            }
        }

        public void saveNote(string Title, string Contents)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NoteDB")))
            {
                List<Note> notes = new List<Note>();
                notes.Add( new Note { id = GetNotes().Count + 1,Title = Title, Contents = Contents });
                connection.Execute("dbo.Note_Insert @id, @Title, @Contents", notes);
            }
        }
    }
}
