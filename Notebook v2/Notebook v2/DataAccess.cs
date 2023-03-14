using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Notebook_v2
{
    public class DataAccess
    {
        public List<Note> GetNotes()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NoteDB")))
            {
                var output =  connection.Query<Note>("select * from Note").ToList();
                return output;
   
            }
        }
    }
}
