using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {        
        ListOfCriminals criminalDirectory = new ListOfCriminals();
        ListOfCriminalGroup criminalGroupDirectory = new ListOfCriminalGroup();
        AddCriminal AddForm;
        SearchForm Search;
        public MainForm()
        {
            InitializeComponent();            
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            TitleForm.Title.Close();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm = new AddCriminal();
            try
            {
                if (AddForm.ShowDialog() == DialogResult.OK)
                {
                    AddForm.criminal.Index = criminalDirectory.Data.Count + 1;
                    Controller.AddColumns(AddForm.criminal, criminalTable);
                    criminalDirectory.Data.Add(AddForm.criminal);
                    Controller.InitializeFullGroupSystem(criminalDirectory, groupChooseComboBox, criminalGroupDirectory);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.SaveData(criminalDirectory);
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.LoadData(criminalDirectory);
            Controller.InintializeTable(criminalDirectory, criminalTable, criminalGroupDirectory);
            Controller.InitializeFullGroupSystem(criminalDirectory, groupChooseComboBox, criminalGroupDirectory);
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && criminalTable.Focused)
            {
                columnTool.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.DeleteColumns(Convert.ToInt32(criminalTable.Items[criminalTable.SelectedIndices[0]].SubItems[0].Text) - 1, criminalTable, criminalDirectory, criminalGroupDirectory);
            Controller.InintializeTable(criminalDirectory, criminalTable, criminalGroupDirectory);
            Controller.InitializeComboBox(criminalGroupDirectory, groupChooseComboBox);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCriminal edit = new EditCriminal(criminalTable.Items[criminalTable.SelectedIndices[0]]);
            try
            {
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    Controller.EditColumns(edit.criminal, criminalDirectory, Convert.ToInt32(criminalTable.Items[criminalTable.SelectedIndices[0]].SubItems[0].Text) - 1, criminalTable, criminalGroupDirectory);
                    Controller.InintializeTable(criminalDirectory, criminalTable, criminalGroupDirectory);
                    Controller.InitializeFullGroupSystem(criminalDirectory, groupChooseComboBox, criminalGroupDirectory);
                                        
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupChooseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupTable.Items.Clear();
            foreach (Criminal criminal in criminalGroupDirectory.criminalGroupData[groupChooseComboBox.SelectedIndex].member)
            {
                Controller.AddColumns(criminal, groupTable);
            }
        }

        private void поАлфивитуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search = new SearchForm();
            if (Search.ShowDialog() == DialogResult.OK)
            {
                Controller.Search(criminalDirectory, Search, criminalTable);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.InintializeTable(criminalDirectory, criminalTable, criminalGroupDirectory);
        }
    }
}
