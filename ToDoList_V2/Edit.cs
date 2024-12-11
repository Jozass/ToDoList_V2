using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ToDoList_V2
{
    public partial class Edit : Form
    {
        private Form1 form1; 

        private DataGridView tableToDoList;
        private List<Model> modelOfTodoList;

        public Edit(DataGridView tableToDoList, List<Model> modelOfTodoList, Form1 form1)
        {
            InitializeComponent();
            this.tableToDoList = tableToDoList;
            this.modelOfTodoList = modelOfTodoList;
            this.form1 = form1; 
        }
        private void Edit_Load(object sender, EventArgs e)
        {
            if (tableToDoList.SelectedCells.Count > 0)
            {
                tableToDoList.CurrentRow.Selected = true;



                txtBoxNotesEdit.Text = tableToDoList.CurrentRow.Cells["colNotes"].Value?.ToString();
                todoEingabeEdit.Text = tableToDoList.CurrentRow.Cells["colToDO"].Value?.ToString();
                deadlineTimePickerEdit.Value = DateTime.Parse(tableToDoList.CurrentRow.Cells["colDeadline"].Value?.ToString());
            }
        }



        private void btRefresh_Click_1(object sender, EventArgs e)
        {
            tableToDoList.CurrentRow.Cells["colNotes"].Value = txtBoxNotesEdit.Text;
            tableToDoList.CurrentRow.Cells["colDeadline"].Value = deadlineTimePickerEdit.Text;
            tableToDoList.CurrentRow.Cells["colToDo"].Value = todoEingabeEdit.Text;

            Program.UpdateModel(Convert.ToBoolean(tableToDoList.CurrentRow.Cells["colCheckBox"].Value), todoEingabeEdit.Text, Convert.ToString(tableToDoList.CurrentRow.Cells["colCreated"].Value), deadlineTimePickerEdit.Text, txtBoxNotesEdit.Text, Convert.ToInt32(tableToDoList.CurrentRow.Cells["ToDos_ID"].Value), modelOfTodoList);
            Program.SaveToDoListSQL(modelOfTodoList);

            
            form1.CheckForDeadline();
            this.Close();
        }
    }
}
