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
using System.IO;

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
            DirectoryInfo di;
            try
            {
                di = new DirectoryInfo(".//Notes");
                if(!di.Exists) 
                {
                    di.Create();
                }
            }
            catch (Exception)
            {

                throw;
            }
            string[] files = new string[(di.GetDirectories().Length)];
            files = converToStringArray(di.GetDirectories());
            classNames = files.ToList();
            classes = LoadDataTables(files);
            saveToDirectory.Items.AddRange(files);
            loadFromDirectory.Items.AddRange(files);
            loadNotes();
        }

        private string[] converToStringArray(DirectoryInfo[] directoryInfos)
        {
            string[] strings = new string[directoryInfos.Length];
            for(int i = 0; i < directoryInfos.Length; i++)
            {
                strings[i] = directoryInfos[i].Name.ToString();
            }
            return strings;
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
                    StreamWriter sw = new StreamWriter($".//Notes//{saveToDirectory.Text}//{tbTitle.Text}.txt");
                    sw.Write(tbNote.Text);
                    sw.Close();
                    tbTitle.Text = "";
                    tbNote.Text = "";
                }
                if (editing)
                {
                    CurrentClass.Rows[previosNotes.CurrentCell.RowIndex]["Title"] = tbTitle.Text;
                    CurrentClass.Rows[previosNotes.CurrentCell.RowIndex]["Note"] = tbNote.Text;
                    tbTitle.Text = "";
                    tbNote.Text = "";
                    editing = false;
                }
                
            }       
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (CurrentClass != null && previosNotes.CurrentCell != null)
            {
                CurrentClass.Rows[previosNotes.CurrentCell.RowIndex].Delete();
                tbNote.Text = "";
                tbTitle.Text = "";
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
                    DirectoryInfo di = new DirectoryInfo($".//Notes//{form2.GivenClassName}");
                    if (!di.Exists)
                    {
                        di.Create();
                    }
                }   
            }
            
        }
        private static DataTable NowyPrzedmiot()
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
        private List<DataTable> LoadDataTables(string[] files)
        {
            List<DataTable> dataTable = new List<DataTable>();
            for (int i = 0; i < files.Length; i++)
            {
                DataTable przedmiot = NowyPrzedmiot();
                dataTable.Add(przedmiot);
            }
            return dataTable;
        }
        private void loadNotes()
        {
            DirectoryInfo di = new DirectoryInfo(".//Notes");
            DirectoryInfo[] przedmioty = di.GetDirectories();
            int i = 0;
            foreach (DirectoryInfo przedmiot in przedmioty)
            {       
                FileInfo[] notes = przedmiot.GetFiles();
                foreach(FileInfo note in notes)
                {
                                      
                    StreamReader sr = new StreamReader(note.FullName);
                    string title = note.Name;
                    string tekst = sr.ReadToEnd();
                    classes[i].Rows.Add(title,tekst);
                    i++;
                }
                

            }
        }
        
    }
}
