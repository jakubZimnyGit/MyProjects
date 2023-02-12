using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class Notebook : Form
    {
        DataTable CurrentClass = null;
        int SelectedClassToSaveTo;
        int SelectedClassToLoadFrom;
        static List<DataTable> classes = new List<DataTable>();
        public List<string> classNames = new List<string>();
        private bool editing;
        public Notebook()
        {
            InitializeComponent();
        }

        private void Notebook_Load(object sender, EventArgs e)
        {
            editing = false;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            SelectedClassToSaveTo = classNames.IndexOf(saveToDirectory.Text);
            if (classes.Count != 0 && saveToDirectory.Text != string.Empty) 
            {
                CurrentClass = classes[SelectedClassToSaveTo];
                if (CurrentClass != null && !editing)
                {
                    CurrentClass.Rows.Add(tbTitle.Text, tbNote.Text);              
                }
                if (editing)
                {
                    CurrentClass.Rows[previosNotes.CurrentCell.RowIndex]["Title"] = tbTitle.Text;
                    CurrentClass.Rows[previosNotes.CurrentCell.RowIndex]["Note"] = tbNote.Text;
                    tbTitle.Text = "";
                    tbNote.Text = "";
                }
                
            }       
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (CurrentClass != null && previosNotes.CurrentCell != null)
            {
                CurrentClass.Rows[previosNotes.CurrentCell.RowIndex].Delete();
            }
        }

        private void AddNewClassBtn(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    saveToDirectory.Items.Add(form2.GivenClassName);
                    loadFromDirectory.Items.Add(form2.GivenClassName);
                    classNames.Add(form2.GivenClassName);
                    DataTable newClass = NowyPrzedmiot();
                    classes.Add(newClass);
                }   
            }
            
        }
        private DataTable NowyPrzedmiot()
        {
            DataTable przedmiot = new DataTable();
            przedmiot.Columns.Add("Title");
            przedmiot.Columns.Add("Note");
            return przedmiot;
        }

        private void loadFromDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedClassToLoadFrom = classNames.IndexOf(loadFromDirectory.Text);
            previosNotes.DataSource = classes[SelectedClassToLoadFrom];
        }

        private void NewNoteBtn_Click(object sender, EventArgs e)
        {
            tbTitle.Text = "";
            tbNote.Text = "";
            editing = false;
        }

        private void previosNotes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedClassToLoadFrom = classNames.IndexOf(loadFromDirectory.Text);
            CurrentClass = classes[SelectedClassToLoadFrom];
            tbTitle.Text = CurrentClass.Rows[previosNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            tbNote.Text = CurrentClass.Rows[previosNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
