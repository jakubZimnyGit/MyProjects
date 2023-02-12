using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class Form2 : Form
    {
        public string GivenClassName { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void saveClassBtn_Click(object sender, EventArgs e)
        {
            GivenClassName = tbNewClassName.Text;
        }
    }
}
