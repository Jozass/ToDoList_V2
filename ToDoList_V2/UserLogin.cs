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
    public partial class UserLogin : Form
    {
        private Form1 form1;
        private DataGridView tableToDoList;
        private List<Model> modelOfTodoList;
        public static bool permissionSignIn;
        private bool isExiting = false;

        public UserLogin(DataGridView tableToDoList, List<Model> modelOfTodoList, Form1 form1)
        {
            InitializeComponent();
            this.tableToDoList = tableToDoList;
            this.modelOfTodoList = modelOfTodoList;
            this.form1 = form1;
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            permissionSignIn = false;
        }

        private void anmelden1_Load(object sender, EventArgs e)
        {
        }

        private void register1_Load(object sender, EventArgs e)
        {
        }

        private void anmelden1_Load_1(object sender, EventArgs e)
        {
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            login1.Visible = true;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            register1.Visible = true;
        }

        private void UserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!permissionSignIn && !isExiting)
            {
                DialogResult result = MessageBox.Show("Möchten Sie das Programm wirklich schließen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    isExiting = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
