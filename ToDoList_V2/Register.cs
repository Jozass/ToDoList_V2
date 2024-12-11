using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Microsoft.Win32;

namespace ToDoList_V2
{
    public partial class Register : UserControl
    {
        
        List<UserData> userDataModel = new List<UserData>();
        public Register()
        {
            InitializeComponent();
            
            
        }
        private int GetNewUserId()
        {
            int maxUserID = 0;

            foreach (var user in userDataModel)
            {
             
                if (user.User_ID > 0)
                {
                    if (user.User_ID > maxUserID)
                    {
                        maxUserID = user.User_ID;
                    }
                }
            }

            return maxUserID + 1;
        }

        

       


        public void btRegisterDone_Click(object sender, EventArgs e)
        {
            string toLowerEmail = emailEingabe.Text.ToLower();
            //int id = GetNewUserId();
            int id = Program.GetLastUserId() + 1;
            if (!String.IsNullOrWhiteSpace(benutzernameEingabe.Text) && !String.IsNullOrWhiteSpace(toLowerEmail) && !String.IsNullOrWhiteSpace(passwortEingabe.Text))
            {
                
                UserData modelUserData = new UserData
                {
                    Benutzername = benutzernameEingabe.Text,
                    Email = toLowerEmail,
                    Passwort = passwortEingabe.Text,
                    User_ID = id,

                };
                Program.SaveUserDatatoSQL(modelUserData);
                this.Visible = false;
                benutzernameEingabe.Text = string.Empty;
                toLowerEmail = string.Empty;
                passwortEingabe.Text = string.Empty;

            }

        }
        private void CloseParentForm()
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void passwortEingabe_Enter(object sender, EventArgs e)
        {
            passwortEingabe.UseSystemPasswordChar = true;
        }

       

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btShowPassword_MouseDown(object sender, MouseEventArgs e)
        {

            passwortEingabe.UseSystemPasswordChar = false;
        }


        private void btShowPassword_MouseUp(object sender, MouseEventArgs e)
        {

            passwortEingabe.UseSystemPasswordChar = true;
        }
    }
}
