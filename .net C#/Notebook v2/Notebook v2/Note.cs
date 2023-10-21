using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook_v2
{
    public class Note
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime Created { get; set; }
        
        public string NoteInfo
        {
            get
            {
                return ($"{Title}      {Created.Day}/{Created.Month}/{Created.Year}");
            }
        }
    }
}
