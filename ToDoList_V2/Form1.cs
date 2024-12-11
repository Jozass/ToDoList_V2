using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_V2
{
    public partial class Form1 : Form
    {
        
        List<Model> modelOfTodoList = new List<Model>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           Program.sendMail();

            int id = GetNewId();
            dataList.ClearSelection();

            if (!String.IsNullOrWhiteSpace(todoEingabe.Text))
            {
                Program.WriteToModel(false, todoEingabe.Text, DateTime.Now.ToString("dd.MM.yyyy"), deadlineTimePicker.Value.ToString("dd.MM.yyyy"), txtBoxNotes.Text, id, modelOfTodoList);
                LoadModelToGridView();
                CheckForDeadline();
            }

        }

        private void LoadModelToGridView()
        {
            dataList.Rows.Clear();
            Program.LoadToDoListSQL(modelOfTodoList);
            foreach (Model model in modelOfTodoList)
            {
                dataList.Rows.Add(model.Erledigt,model.Aufgabe,model.Erstellungsdatum,model.Deadline,model.Notizen,model.ToDoID,model.UserID);
            }

        }
        
        private int GetNewId()
        {
            int maxToDoID = 0;

            foreach (DataGridViewRow row in dataList.Rows)
            {
                if (row.Cells["ToDos_ID"].Value != null && int.TryParse(row.Cells["ToDos_ID"].Value.ToString(), out int id))
                {
                    if (id > maxToDoID)
                    {
                        maxToDoID = id;
                    }
                }
            }


            return maxToDoID + 1;
        }
       


        private void Form1_Load(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin(dataList, modelOfTodoList, this);
            userLogin.ShowDialog();
            LoadModelToGridView();
            CheckForDeadline();
            dataList.ClearSelection();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dataList.SelectedRows != null)
            {
                foreach (DataGridViewRow row in dataList.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["ToDos_ID"].Value);
                    var toDeleteModel = modelOfTodoList.FirstOrDefault(m => m.ToDoID == id);

                    if (toDeleteModel != null)
                    {
                       
                        modelOfTodoList.Remove(toDeleteModel);
                    }
                }
            }
            Program.UpdateModel(Convert.ToBoolean(dataList.CurrentRow.Cells["colCheckBox"].Value), Convert.ToString(dataList.CurrentRow.Cells["colToDo"].Value), Convert.ToString(dataList.CurrentRow.Cells["colCreated"].Value), Convert.ToString(dataList.CurrentRow.Cells["colDeadline"].Value), Convert.ToString(dataList.CurrentRow.Cells["colNotes"].Value), Convert.ToInt32(dataList.CurrentRow.Cells["ToDos_ID"].Value), modelOfTodoList);
            Program.SaveToDoListSQL(modelOfTodoList);
            LoadModelToGridView();
            CheckForDeadline();
        }
        


        public void CheckForDeadline()
        {
            foreach (DataGridViewRow row in dataList.Rows)
            {
                DataGridViewCell deadlineDateCell = row.Cells["colDeadline"];

                if (deadlineDateCell.Value != null && !string.IsNullOrWhiteSpace(deadlineDateCell.Value.ToString()))
                {
                    string deadlineDate = deadlineDateCell.Value.ToString();
                    Program.CheckDate(deadlineDate, row);
                }
                else
                {
                }
            }
        }



        private void tableToDoList_SelectionChanged(object sender, EventArgs e)
        {

            if (dataList.SelectedCells.Count > 0)
            {
                lblID.Text = dataList.CurrentRow.Cells["colToDO"].Value?.ToString() + " ID Nr.: " + dataList.CurrentRow.Cells["ToDos_ID"].Value.ToString();
                todoEingabe.ReadOnly = true; 
              
                txtBoxNotes.ReadOnly = true;
                dataList.CurrentRow.Selected = true;
                btDel.Enabled = true;
                btAdd.Enabled = false;
                
                txtBoxNotes.Text = dataList.CurrentRow.Cells["colNotes"].Value?.ToString();
                todoEingabe.Text = dataList.CurrentRow.Cells["colToDO"].Value?.ToString();
                deadlineTimePicker.Value = DateTime.Parse(dataList.CurrentRow.Cells["colDeadline"].Value?.ToString());
            }
            else
            {
                lblID.Text = string.Empty;
                todoEingabe.ReadOnly = false;
                btAdd.Enabled = true;
                txtBoxNotes.ReadOnly = false;
                btDel.Enabled = false;
                
                txtBoxNotes.Text = string.Empty;
                todoEingabe.Text = string.Empty;
                deadlineTimePicker.Value = DateTime.Now;
            }
        }

        private void tableToDoList_DoubleClick(object sender, EventArgs e)
        {
            Edit settingsForm = new Edit(dataList, modelOfTodoList, this); 
            settingsForm.ShowDialog();
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            dataList.ClearSelection();
        }

        private void btDeleteCompleted_Click(object sender, EventArgs e)
        {
            for (int i = dataList.Rows.Count - 1; i >= 0; i--)
            {

                DataGridViewRow row = dataList.Rows[i];
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells[0];
                int id = Convert.ToInt32(row.Cells["ToDos_ID"].Value);
                var toDeleteModel = modelOfTodoList.FirstOrDefault(m => m.ToDoID == id);
                if (checkBoxCell.Value != null && (bool)checkBoxCell.Value == true && toDeleteModel != null)
                {
                    modelOfTodoList.Remove(toDeleteModel);
                    dataList.Rows.RemoveAt(i);
                }
            }
            if (dataList.Rows.Count > 0)
            {
                Program.UpdateModel(Convert.ToBoolean(dataList.CurrentRow.Cells["colCheckBox"].Value), Convert.ToString(dataList.CurrentRow.Cells["colToDo"].Value), Convert.ToString(dataList.CurrentRow.Cells["colCreated"].Value), Convert.ToString(dataList.CurrentRow.Cells["colDeadline"].Value), Convert.ToString(dataList.CurrentRow.Cells["colNotes"].Value), Convert.ToInt32(dataList.CurrentRow.Cells["ToDos_ID"].Value), modelOfTodoList);
                Program.SaveToDoListSQL(modelOfTodoList);
                LoadModelToGridView();
                CheckForDeadline();
            }
            
            dataList.ClearSelection();
        }

        private void dataList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Color leichtGrün = ColorTranslator.FromHtml("#ABEFA4");
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.ColumnIndex >= dataList.ColumnCount || e.RowIndex >= dataList.RowCount)
            {
                CheckForDeadline();
                return;
            }

            if (e.ColumnIndex == 0)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                DataGridViewRow row = dataList.Rows[e.RowIndex];
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells[0];

                if (checkBoxCell.Value != null && checkBoxCell.Value.Equals(true))
                {
                    style.BackColor = leichtGrün;
                    row.DefaultCellStyle = style;
                    dataList.ClearSelection();
                }
                else
                {
                    CheckForDeadline();
                    dataList.ClearSelection();
                }


            }
        }

        private void dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataList.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
