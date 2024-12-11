using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList_V2;

namespace ToDoList_V2
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string userID = Login.UserID;
        }
        
        

        public static void WriteToModel(bool erledigt, string aufgabe, string erstellungsdatum, string deadline, string notizen, int id,  List<Model> toDoList)
        {
            Model toDoListModel = new Model
            {
                Erledigt = erledigt,
                Aufgabe = aufgabe,
                Erstellungsdatum = erstellungsdatum,
                Deadline = deadline,
                Notizen = notizen,
                ToDoID = id,
                UserID = Login.UserID
            };
            toDoList.Add(toDoListModel);

            SaveToDoListSQL(toDoList);
        }
        public static void WriteToUserData(string name, string email, string passwort, int userIDm, List<UserData> userDatas)
        {
            UserData modelUserData = new UserData
            {
                Benutzername = name,
                Email = email,
                Passwort = passwort,
                User_ID = userIDm,
                
            };
            userDatas.Add(modelUserData);
       
            
        }

        public static void sendMail()
        {
            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("sendtodoreminder@gmail.com", "fgts fhwe hgmn jmkv");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("sendtodoreminder@gmail.com"),
                Subject = "Kurze Erinnerung",
                Body = "Einer deiner Aufgaben läuft bald ab, \nsiehe nach was du Erledigen musst." ,
                IsBodyHtml = false,
            };

            mailMessage.To.Add(Login.Email);

            smtpClient.Send(mailMessage);
        }

        public static int GetLastUserId()
        {
            int id = 0;
            SQLiteConnection connection = new SQLiteConnection("Data Source=Datenbank.db");

            connection.Open();

            SQLiteCommand command = new SQLiteCommand("select max(User_ID) from User", connection);

            var objectResult = command.ExecuteScalar();

            Int32.TryParse(objectResult.ToString(),out id);

            return id;
        }


        public static void SaveUserDatatoSQL(UserData userDatas)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=Datenbank.db");
           
            {
                connection.Open();


                 using (SQLiteCommand command = new SQLiteCommand("INSERT INTO User (UserName, EMail, Passwort, User_ID) VALUES (@UserName, @Email, @Passwort, @User_ID)", connection))
                 {
                        command.Parameters.AddWithValue("@UserName", userDatas.Benutzername);
                        command.Parameters.AddWithValue("@Email", userDatas.Email);
                        command.Parameters.AddWithValue("@Passwort", userDatas.Passwort);
                        command.Parameters.AddWithValue("@User_ID", userDatas.User_ID);



                        command.ExecuteNonQuery();
                 }
                
                connection.Close();
                
            }
        }
        

        public static void LoadUserDataSQL(List<UserData> userDatas)
        {
            

            SQLiteConnection connection = new SQLiteConnection("Data Source=Datenbank.db");

            connection.Open();

            SQLiteCommand command = new SQLiteCommand("select UserName, EMail, Passwort, User_ID from User", connection);

            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserData userDataModel = new UserData();
                    userDataModel.Benutzername = reader["UserName"].ToString();
                    userDataModel.Email = reader["EMail"].ToString();
                    userDataModel.Passwort = reader["Passwort"].ToString();
                    userDataModel.User_ID = Convert.ToInt32(reader["User_ID"].ToString());
               
                    
                }
                reader.Close();
            }
        }
        



        public static void LoadToDoListSQL(List<Model> toDoList)
        {
            toDoList.Clear();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=Datenbank.db"))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("SELECT ToDos_ID, Aufgabe, Erledigt, Deadline, Erstellungsdatum, Notizen, User_ID FROM ToDos WHERE User_ID = @Id", connection);
                command.Parameters.AddWithValue("@Id", Login.UserID);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Model toDoListModel = new Model();

                        if (int.TryParse(reader["ToDos_ID"].ToString(), out int toDoID))
                        {
                            toDoListModel.ToDoID = toDoID;
                        }
                        else
                        {

                            continue; 
                        }
                        byte[] aufgabeBytes = (byte[])reader["Aufgabe"];

                        toDoListModel.Aufgabe = Encoding.UTF8.GetString(aufgabeBytes);
                        toDoListModel.Erledigt = Convert.ToBoolean(reader["Erledigt"]);

                        if (DateTime.TryParse(reader["Deadline"].ToString(), out DateTime deadline))
                        {
                            toDoListModel.Deadline = deadline.ToString("dd.MM.yyyy");
                        }
                        else
                        {

                            toDoListModel.Deadline = string.Empty;
                        }

                        if (DateTime.TryParse(reader["Erstellungsdatum"].ToString(), out DateTime erstellungsdatum))
                        {
                            toDoListModel.Erstellungsdatum = erstellungsdatum.ToString("dd.MM.yyyy");
                        }
                        else
                        {

                            toDoListModel.Erstellungsdatum = string.Empty;
                        }

                        toDoListModel.Notizen = reader["Notizen"].ToString();
                        toDoListModel.UserID = reader["User_ID"].ToString();

                        toDoList.Add(toDoListModel);
                    }
                }
            }
    }

 



    public static void SaveToDoListSQL(List<Model> toDoList)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=Datenbank.db"))
            {
                connection.Open();

                using (SQLiteCommand command2 = new SQLiteCommand("DELETE FROM ToDos where User_ID = @UserID", connection))
                {
                    command2.Parameters.AddWithValue("@UserID", Login.UserID);
                    command2.ExecuteNonQuery();
                }

                foreach (Model toDo in toDoList)
                {
                    using (SQLiteCommand command = new SQLiteCommand("INSERT INTO ToDos (ToDos_ID, Aufgabe, Erledigt, Deadline, Erstellungsdatum, Notizen, User_ID) VALUES (@Id, @Aufgabe, @Erledigt, @Deadline, @Erstellungsdatum, @Notizen, @UserID)", connection))
                    {
                        command.Parameters.AddWithValue("@Id", toDo.ToDoID);
                        command.Parameters.AddWithValue("@Aufgabe", toDo.Aufgabe);
                        command.Parameters.AddWithValue("@Erledigt", toDo.Erledigt);
                        command.Parameters.AddWithValue("@Deadline", toDo.Deadline);
                        command.Parameters.AddWithValue("@Erstellungsdatum", toDo.Erstellungsdatum);
                        command.Parameters.AddWithValue("@Notizen", toDo.Notizen);
                        command.Parameters.AddWithValue("@UserID", toDo.UserID);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void UpdateModel(bool erledigt, string aufgabe, string Erstellungsdatum, string deadline, string notizen, int id, List<Model> toDoList)
        {
            foreach (var todo in toDoList)
            {
                if (todo.ToDoID == id)
                {
                    todo.Aufgabe = aufgabe;
                    todo.Deadline = deadline;
                    todo.Notizen = notizen;
                    todo.Erledigt = erledigt;
                }
            }
        }


        public static string ConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            {
      
                builder.DataSource = "Datenbank.db";
             
            }

            return builder.ToString();
        }
        public static void CheckDate(string deadlineDate, DataGridViewRow row)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells[0];

            Color Rot = ColorTranslator.FromHtml("#F00901");
            Color leichtGelb = ColorTranslator.FromHtml("#F0E792");
            Color leichtOrange = ColorTranslator.FromHtml("#F0AF5F");

            Color leichtRot = ColorTranslator.FromHtml("#EB7B70");

            DateTime deadlineDateTime = DateTime.ParseExact(deadlineDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            DateTime heute = DateTime.Now;
            DateTime morgen = heute.AddDays(1);
            DateTime übermorgen = heute.AddDays(2);

            if (morgen.ToString("dd.MM.yyyy") == deadlineDate && (bool)checkBoxCell.Value == false)
            {

                style.BackColor = leichtOrange;
                row.DefaultCellStyle = style;
            }
            else if (DateTime.Today > deadlineDateTime && (bool)checkBoxCell.Value == false)
            {


                style.BackColor = Rot;
                row.DefaultCellStyle = style;
            }

            else if (übermorgen.ToString("dd.MM.yyyy") == deadlineDate && (bool)checkBoxCell.Value == false)
            {

                style.BackColor = leichtGelb;
                row.DefaultCellStyle = style;
            }
            else if (heute.ToString("dd.MM.yyyy") == deadlineDate && (bool)checkBoxCell.Value == false)
            {

                style.BackColor = leichtRot;
                row.DefaultCellStyle = style;
            }
        }
    }
}
