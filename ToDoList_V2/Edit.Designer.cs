namespace ToDoList_V2
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.editUeberschrift = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.lblDeadlineChoose = new System.Windows.Forms.Label();
            this.deadlineTimePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.todoEingabeEdit = new System.Windows.Forms.TextBox();
            this.txtBoxNotesEdit = new System.Windows.Forms.RichTextBox();
            this.lblAufgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editUeberschrift
            // 
            this.editUeberschrift.AutoSize = true;
            this.editUeberschrift.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUeberschrift.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.editUeberschrift.Location = new System.Drawing.Point(12, 9);
            this.editUeberschrift.Name = "editUeberschrift";
            this.editUeberschrift.Size = new System.Drawing.Size(354, 46);
            this.editUeberschrift.TabIndex = 0;
            this.editUeberschrift.Text = "Aufgabe Bearbeiten";
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btRefresh.FlatAppearance.BorderSize = 0;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRefresh.Location = new System.Drawing.Point(571, 87);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(140, 23);
            this.btRefresh.TabIndex = 20;
            this.btRefresh.Text = "Aktualisieren";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click_1);
            // 
            // lblDeadlineChoose
            // 
            this.lblDeadlineChoose.AutoSize = true;
            this.lblDeadlineChoose.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineChoose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeadlineChoose.Location = new System.Drawing.Point(298, 90);
            this.lblDeadlineChoose.Name = "lblDeadlineChoose";
            this.lblDeadlineChoose.Size = new System.Drawing.Size(49, 13);
            this.lblDeadlineChoose.TabIndex = 28;
            this.lblDeadlineChoose.Text = "Deadline:";
            // 
            // deadlineTimePickerEdit
            // 
            this.deadlineTimePickerEdit.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineTimePickerEdit.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deadlineTimePickerEdit.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.deadlineTimePickerEdit.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.deadlineTimePickerEdit.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deadlineTimePickerEdit.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlLight;
            this.deadlineTimePickerEdit.CustomFormat = "";
            this.deadlineTimePickerEdit.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineTimePickerEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deadlineTimePickerEdit.Location = new System.Drawing.Point(353, 87);
            this.deadlineTimePickerEdit.Name = "deadlineTimePickerEdit";
            this.deadlineTimePickerEdit.Size = new System.Drawing.Size(173, 22);
            this.deadlineTimePickerEdit.TabIndex = 27;
            // 
            // todoEingabeEdit
            // 
            this.todoEingabeEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.todoEingabeEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.todoEingabeEdit.Location = new System.Drawing.Point(94, 87);
            this.todoEingabeEdit.Name = "todoEingabeEdit";
            this.todoEingabeEdit.Size = new System.Drawing.Size(188, 20);
            this.todoEingabeEdit.TabIndex = 26;
            // 
            // txtBoxNotesEdit
            // 
            this.txtBoxNotesEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtBoxNotesEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxNotesEdit.Location = new System.Drawing.Point(40, 127);
            this.txtBoxNotesEdit.Name = "txtBoxNotesEdit";
            this.txtBoxNotesEdit.Size = new System.Drawing.Size(486, 96);
            this.txtBoxNotesEdit.TabIndex = 25;
            this.txtBoxNotesEdit.Text = "";
            // 
            // lblAufgabe
            // 
            this.lblAufgabe.AutoSize = true;
            this.lblAufgabe.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAufgabe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAufgabe.Location = new System.Drawing.Point(40, 90);
            this.lblAufgabe.Name = "lblAufgabe";
            this.lblAufgabe.Size = new System.Drawing.Size(48, 13);
            this.lblAufgabe.TabIndex = 29;
            this.lblAufgabe.Text = "Aufgabe:";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(748, 255);
            this.Controls.Add(this.lblAufgabe);
            this.Controls.Add(this.lblDeadlineChoose);
            this.Controls.Add(this.deadlineTimePickerEdit);
            this.Controls.Add(this.todoEingabeEdit);
            this.Controls.Add(this.txtBoxNotesEdit);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.editUeberschrift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aufgabe Bearbeiten";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editUeberschrift;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label lblDeadlineChoose;
        private System.Windows.Forms.DateTimePicker deadlineTimePickerEdit;
        private System.Windows.Forms.TextBox todoEingabeEdit;
        private System.Windows.Forms.RichTextBox txtBoxNotesEdit;
        private System.Windows.Forms.Label lblAufgabe;
    }
}