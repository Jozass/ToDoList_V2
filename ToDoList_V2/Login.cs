using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_V2
{
    public partial class Login : UserControl
    {
        List<UserData> userDataModel = new List<UserData>();
        
        public static string UserID { get; private set; }
        public static string Email { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void CloseParentForm()
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        public void btLoginDone_Click(object sender, EventArgs e)
        {
            string lowerEmail = emailEingabeLogin.Text.ToLower();
            string eMail = "";
            string passwort = "";
            string userID = "";
            SQLiteConnection connection = new SQLiteConnection("Data Source=Datenbank.db");

            connection.Open();

            SQLiteCommand command = new SQLiteCommand("select EMail,Passwort,User_ID from User where Email = @Email", connection);
            command.Parameters.AddWithValue("@Email", lowerEmail);

            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    eMail = reader["EMail"].ToString();
                    passwort = reader["Passwort"].ToString();
                    userID = reader["User_ID"].ToString();
                }
                reader.Close();
            }

            if (passwort == passwortEingabe.Text && eMail == lowerEmail)
            {
                UserLogin.permissionSignIn = true;
                UserID = userID;
                Email = lowerEmail;
                
                CloseParentForm();
            }
        }

        private void passwortEingabe_Enter(object sender, EventArgs e)
        {
            passwortEingabe.UseSystemPasswordChar = true;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Visible =false;
        }

        private void btShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            passwortEingabe.UseSystemPasswordChar = true;
        }

        private void btShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            passwortEingabe.UseSystemPasswordChar = false;
        }
    }
}
