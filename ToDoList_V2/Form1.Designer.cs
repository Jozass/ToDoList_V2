using System.Drawing;

namespace ToDoList_V2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataList = new System.Windows.Forms.DataGridView();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colToDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDos_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxNotes = new System.Windows.Forms.RichTextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.todoEingabe = new System.Windows.Forms.TextBox();
            this.deadlineTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDeadlineChoose = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMainTitel = new System.Windows.Forms.Label();
            this.lblAufgabe = new System.Windows.Forms.Label();
            this.btDeleteCompleted = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataList
            // 
            this.dataList.AllowUserToAddRows = false;
            this.dataList.AllowUserToOrderColumns = true;
            this.dataList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.colToDo,
            this.colCreated,
            this.colDeadline,
            this.colNotes,
            this.ToDos_ID,
            this.colUserID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataList.GridColor = System.Drawing.Color.LightGray;
            this.dataList.Location = new System.Drawing.Point(8, 55);
            this.dataList.MultiSelect = false;
            this.dataList.Name = "dataList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataList.RowHeadersVisible = false;
            this.dataList.RowHeadersWidth = 72;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.dataList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataList.Size = new System.Drawing.Size(422, 371);
            this.dataList.TabIndex = 19;
            this.dataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataList_CellContentClick);
            this.dataList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataList_CellValueChanged);
            this.dataList.SelectionChanged += new System.EventHandler(this.tableToDoList_SelectionChanged);
            this.dataList.DoubleClick += new System.EventHandler(this.tableToDoList_DoubleClick);
            // 
            // colCheckBox
            // 
            this.colCheckBox.HeaderText = "Erledigt";
            this.colCheckBox.MinimumWidth = 9;
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCheckBox.Width = 45;
            // 
            // colToDo
            // 
            this.colToDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colToDo.HeaderText = "To-Do";
            this.colToDo.MinimumWidth = 9;
            this.colToDo.Name = "colToDo";
            this.colToDo.ReadOnly = true;
            // 
            // colCreated
            // 
            this.colCreated.HeaderText = "Erstellt am";
            this.colCreated.MinimumWidth = 9;
            this.colCreated.Name = "colCreated";
            this.colCreated.ReadOnly = true;
            this.colCreated.Width = 65;
            // 
            // colDeadline
            // 
            this.colDeadline.HeaderText = "Deadline";
            this.colDeadline.MinimumWidth = 9;
            this.colDeadline.Name = "colDeadline";
            this.colDeadline.ReadOnly = true;
            this.colDeadline.Width = 65;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "Notizen";
            this.colNotes.MinimumWidth = 9;
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            this.colNotes.Visible = false;
            this.colNotes.Width = 175;
            // 
            // ToDos_ID
            // 
            this.ToDos_ID.HeaderText = "ToDo ID\'s ";
            this.ToDos_ID.MinimumWidth = 8;
            this.ToDos_ID.Name = "ToDos_ID";
            this.ToDos_ID.Visible = false;
            this.ToDos_ID.Width = 150;
            // 
            // colUserID
            // 
            this.colUserID.HeaderText = "User ID\'s";
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = false;
            // 
            // txtBoxNotes
            // 
            this.txtBoxNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtBoxNotes.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtBoxNotes.Location = new System.Drawing.Point(465, 164);
            this.txtBoxNotes.Name = "txtBoxNotes";
            this.txtBoxNotes.Size = new System.Drawing.Size(391, 96);
            this.txtBoxNotes.TabIndex = 20;
            this.txtBoxNotes.Text = "";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAdd.Location = new System.Drawing.Point(716, 76);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(140, 23);
            this.btAdd.TabIndex = 21;
            this.btAdd.Text = "Hinzufügen";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // todoEingabe
            // 
            this.todoEingabe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.todoEingabe.ForeColor = System.Drawing.SystemColors.Window;
            this.todoEingabe.Location = new System.Drawing.Point(464, 75);
            this.todoEingabe.Name = "todoEingabe";
            this.todoEingabe.Size = new System.Drawing.Size(243, 20);
            this.todoEingabe.TabIndex = 22;
            // 
            // deadlineTimePicker
            // 
            this.deadlineTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineTimePicker.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deadlineTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.deadlineTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deadlineTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deadlineTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.deadlineTimePicker.CustomFormat = "";
            this.deadlineTimePicker.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deadlineTimePicker.Location = new System.Drawing.Point(465, 120);
            this.deadlineTimePicker.Name = "deadlineTimePicker";
            this.deadlineTimePicker.Size = new System.Drawing.Size(242, 22);
            this.deadlineTimePicker.TabIndex = 23;
            // 
            // lblDeadlineChoose
            // 
            this.lblDeadlineChoose.AutoSize = true;
            this.lblDeadlineChoose.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineChoose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDeadlineChoose.Location = new System.Drawing.Point(462, 102);
            this.lblDeadlineChoose.Name = "lblDeadlineChoose";
            this.lblDeadlineChoose.Size = new System.Drawing.Size(49, 13);
            this.lblDeadlineChoose.TabIndex = 24;
            this.lblDeadlineChoose.Text = "Deadline:";
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btDel.Enabled = false;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDel.Location = new System.Drawing.Point(716, 105);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(140, 23);
            this.btDel.TabIndex = 25;
            this.btDel.Text = "Entfernen";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblID.Location = new System.Drawing.Point(12, 429);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "ID Nr.:";
            // 
            // lblMainTitel
            // 
            this.lblMainTitel.AutoSize = true;
            this.lblMainTitel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMainTitel.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMainTitel.Location = new System.Drawing.Point(0, 0);
            this.lblMainTitel.Name = "lblMainTitel";
            this.lblMainTitel.Size = new System.Drawing.Size(300, 46);
            this.lblMainTitel.TabIndex = 28;
            this.lblMainTitel.Text = "Aufgaben Planer";
            // 
            // lblAufgabe
            // 
            this.lblAufgabe.AutoSize = true;
            this.lblAufgabe.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAufgabe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAufgabe.Location = new System.Drawing.Point(462, 54);
            this.lblAufgabe.Name = "lblAufgabe";
            this.lblAufgabe.Size = new System.Drawing.Size(48, 13);
            this.lblAufgabe.TabIndex = 30;
            this.lblAufgabe.Text = "Aufgabe:";
            // 
            // btDeleteCompleted
            // 
            this.btDeleteCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btDeleteCompleted.FlatAppearance.BorderSize = 0;
            this.btDeleteCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteCompleted.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteCompleted.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDeleteCompleted.Location = new System.Drawing.Point(716, 135);
            this.btDeleteCompleted.Name = "btDeleteCompleted";
            this.btDeleteCompleted.Size = new System.Drawing.Size(140, 23);
            this.btDeleteCompleted.TabIndex = 31;
            this.btDeleteCompleted.Text = "Erledigte Löschen";
            this.btDeleteCompleted.UseVisualStyleBackColor = false;
            this.btDeleteCompleted.Click += new System.EventHandler(this.btDeleteCompleted_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNotes.Location = new System.Drawing.Point(462, 148);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(45, 13);
            this.lblNotes.TabIndex = 32;
            this.lblNotes.Text = "Notizen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btDeleteCompleted);
            this.Controls.Add(this.lblAufgabe);
            this.Controls.Add(this.lblMainTitel);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.lblDeadlineChoose);
            this.Controls.Add(this.deadlineTimePicker);
            this.Controls.Add(this.todoEingabe);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtBoxNotes);
            this.Controls.Add(this.dataList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aufgaben Planer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.RichTextBox txtBoxNotes;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox todoEingabe;
        private System.Windows.Forms.DateTimePicker deadlineTimePicker;
        private System.Windows.Forms.Label lblDeadlineChoose;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMainTitel;
        private System.Windows.Forms.Label lblAufgabe;
        private System.Windows.Forms.Button btDeleteCompleted;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDos_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
    }
}

