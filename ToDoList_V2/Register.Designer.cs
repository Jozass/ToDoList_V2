namespace ToDoList_V2
{
    partial class Register
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwortEingabe = new System.Windows.Forms.TextBox();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.emailEingabe = new System.Windows.Forms.TextBox();
            this.lblLoginEingabe = new System.Windows.Forms.Label();
            this.lblRegisterTitel = new System.Windows.Forms.Label();
            this.benutzernameEingabe = new System.Windows.Forms.TextBox();
            this.lblBenutzerName = new System.Windows.Forms.Label();
            this.btRegisterDone = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btShowPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwortEingabe
            // 
            this.passwortEingabe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.passwortEingabe.ForeColor = System.Drawing.SystemColors.Window;
            this.passwortEingabe.Location = new System.Drawing.Point(45, 198);
            this.passwortEingabe.Name = "passwortEingabe";
            this.passwortEingabe.Size = new System.Drawing.Size(243, 20);
            this.passwortEingabe.TabIndex = 33;
            this.passwortEingabe.Enter += new System.EventHandler(this.passwortEingabe_Enter);
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPasswort.Location = new System.Drawing.Point(42, 182);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(50, 13);
            this.lblPasswort.TabIndex = 32;
            this.lblPasswort.Text = "Passwort";
            // 
            // emailEingabe
            // 
            this.emailEingabe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.emailEingabe.ForeColor = System.Drawing.SystemColors.Window;
            this.emailEingabe.Location = new System.Drawing.Point(45, 155);
            this.emailEingabe.Name = "emailEingabe";
            this.emailEingabe.Size = new System.Drawing.Size(243, 20);
            this.emailEingabe.TabIndex = 31;
            // 
            // lblLoginEingabe
            // 
            this.lblLoginEingabe.AutoSize = true;
            this.lblLoginEingabe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLoginEingabe.Location = new System.Drawing.Point(42, 139);
            this.lblLoginEingabe.Name = "lblLoginEingabe";
            this.lblLoginEingabe.Size = new System.Drawing.Size(36, 13);
            this.lblLoginEingabe.TabIndex = 30;
            this.lblLoginEingabe.Text = "E-Mail";
            // 
            // lblRegisterTitel
            // 
            this.lblRegisterTitel.AutoSize = true;
            this.lblRegisterTitel.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTitel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRegisterTitel.Location = new System.Drawing.Point(37, 21);
            this.lblRegisterTitel.Name = "lblRegisterTitel";
            this.lblRegisterTitel.Size = new System.Drawing.Size(158, 46);
            this.lblRegisterTitel.TabIndex = 29;
            this.lblRegisterTitel.Text = "Register";
            this.lblRegisterTitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // benutzernameEingabe
            // 
            this.benutzernameEingabe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.benutzernameEingabe.ForeColor = System.Drawing.SystemColors.Window;
            this.benutzernameEingabe.Location = new System.Drawing.Point(45, 109);
            this.benutzernameEingabe.Name = "benutzernameEingabe";
            this.benutzernameEingabe.Size = new System.Drawing.Size(243, 20);
            this.benutzernameEingabe.TabIndex = 35;
            // 
            // lblBenutzerName
            // 
            this.lblBenutzerName.AutoSize = true;
            this.lblBenutzerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBenutzerName.Location = new System.Drawing.Point(42, 93);
            this.lblBenutzerName.Name = "lblBenutzerName";
            this.lblBenutzerName.Size = new System.Drawing.Size(75, 13);
            this.lblBenutzerName.TabIndex = 34;
            this.lblBenutzerName.Text = "Benutzername";
            // 
            // btRegisterDone
            // 
            this.btRegisterDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btRegisterDone.FlatAppearance.BorderSize = 0;
            this.btRegisterDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegisterDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRegisterDone.Location = new System.Drawing.Point(339, 198);
            this.btRegisterDone.Name = "btRegisterDone";
            this.btRegisterDone.Size = new System.Drawing.Size(112, 23);
            this.btRegisterDone.TabIndex = 36;
            this.btRegisterDone.Text = "Regestrieren";
            this.btRegisterDone.UseVisualStyleBackColor = false;
            this.btRegisterDone.Click += new System.EventHandler(this.btRegisterDone_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBack.Location = new System.Drawing.Point(339, 169);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(112, 23);
            this.btBack.TabIndex = 37;
            this.btBack.Text = "Zurück";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btShowPassword
            // 
            this.btShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btShowPassword.BackgroundImage = global::ToDoList_V2.Properties.Resources.auge_icon_weiss__1_;
            this.btShowPassword.FlatAppearance.BorderSize = 0;
            this.btShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btShowPassword.Location = new System.Drawing.Point(294, 198);
            this.btShowPassword.Name = "btShowPassword";
            this.btShowPassword.Size = new System.Drawing.Size(23, 23);
            this.btShowPassword.TabIndex = 38;
            this.btShowPassword.UseVisualStyleBackColor = false;
            this.btShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btShowPassword_MouseDown);
            this.btShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btShowPassword_MouseUp);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.btShowPassword);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btRegisterDone);
            this.Controls.Add(this.benutzernameEingabe);
            this.Controls.Add(this.lblBenutzerName);
            this.Controls.Add(this.passwortEingabe);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.emailEingabe);
            this.Controls.Add(this.lblLoginEingabe);
            this.Controls.Add(this.lblRegisterTitel);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(466, 281);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwortEingabe;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.TextBox emailEingabe;
        private System.Windows.Forms.Label lblLoginEingabe;
        private System.Windows.Forms.Label lblRegisterTitel;
        private System.Windows.Forms.TextBox benutzernameEingabe;
        private System.Windows.Forms.Label lblBenutzerName;
        private System.Windows.Forms.Button btRegisterDone;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btShowPassword;
    }
}
