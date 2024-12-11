namespace ToDoList_V2
{
    partial class Login
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
            this.lblLoginTitel = new System.Windows.Forms.Label();
            this.lblLoginEingabe = new System.Windows.Forms.Label();
            this.emailEingabeLogin = new System.Windows.Forms.TextBox();
            this.passwortEingabe = new System.Windows.Forms.TextBox();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.btLoginDone = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btShowPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginTitel
            // 
            this.lblLoginTitel.AutoSize = true;
            this.lblLoginTitel.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLoginTitel.Location = new System.Drawing.Point(39, 22);
            this.lblLoginTitel.Name = "lblLoginTitel";
            this.lblLoginTitel.Size = new System.Drawing.Size(113, 46);
            this.lblLoginTitel.TabIndex = 24;
            this.lblLoginTitel.Text = "Login";
            this.lblLoginTitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLoginEingabe
            // 
            this.lblLoginEingabe.AutoSize = true;
            this.lblLoginEingabe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLoginEingabe.Location = new System.Drawing.Point(44, 92);
            this.lblLoginEingabe.Name = "lblLoginEingabe";
            this.lblLoginEingabe.Size = new System.Drawing.Size(39, 13);
            this.lblLoginEingabe.TabIndex = 25;
            this.lblLoginEingabe.Text = "E-Mail";
            // 
            // emailEingabeLogin
            // 
            this.emailEingabeLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.emailEingabeLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.emailEingabeLogin.Location = new System.Drawing.Point(47, 108);
            this.emailEingabeLogin.Name = "emailEingabeLogin";
            this.emailEingabeLogin.Size = new System.Drawing.Size(243, 22);
            this.emailEingabeLogin.TabIndex = 26;
            // 
            // passwortEingabe
            // 
            this.passwortEingabe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.passwortEingabe.ForeColor = System.Drawing.SystemColors.Window;
            this.passwortEingabe.Location = new System.Drawing.Point(47, 152);
            this.passwortEingabe.Name = "passwortEingabe";
            this.passwortEingabe.Size = new System.Drawing.Size(243, 22);
            this.passwortEingabe.TabIndex = 28;
            this.passwortEingabe.Enter += new System.EventHandler(this.passwortEingabe_Enter);
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPasswort.Location = new System.Drawing.Point(44, 136);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(53, 13);
            this.lblPasswort.TabIndex = 27;
            this.lblPasswort.Text = "Passwort";
            // 
            // btLoginDone
            // 
            this.btLoginDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btLoginDone.FlatAppearance.BorderSize = 0;
            this.btLoginDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoginDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLoginDone.Location = new System.Drawing.Point(47, 192);
            this.btLoginDone.Name = "btLoginDone";
            this.btLoginDone.Size = new System.Drawing.Size(112, 23);
            this.btLoginDone.TabIndex = 37;
            this.btLoginDone.Text = "Einloggen";
            this.btLoginDone.UseVisualStyleBackColor = false;
            this.btLoginDone.Click += new System.EventHandler(this.btLoginDone_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBack.Location = new System.Drawing.Point(165, 192);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(112, 23);
            this.btBack.TabIndex = 38;
            this.btBack.Text = "Zurück";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btShowPassword
            // 
            this.btShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btShowPassword.FlatAppearance.BorderSize = 0;
            this.btShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btShowPassword.Image = global::ToDoList_V2.Properties.Resources.auge_icon_weiss__1_;
            this.btShowPassword.Location = new System.Drawing.Point(296, 151);
            this.btShowPassword.Name = "btShowPassword";
            this.btShowPassword.Size = new System.Drawing.Size(23, 23);
            this.btShowPassword.TabIndex = 39;
            this.btShowPassword.UseVisualStyleBackColor = false;
            this.btShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btShowPassword_MouseDown);
            this.btShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btShowPassword_MouseUp);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.btShowPassword);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btLoginDone);
            this.Controls.Add(this.passwortEingabe);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.emailEingabeLogin);
            this.Controls.Add(this.lblLoginEingabe);
            this.Controls.Add(this.lblLoginTitel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.Size = new System.Drawing.Size(423, 252);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginTitel;
        private System.Windows.Forms.Label lblLoginEingabe;
        private System.Windows.Forms.TextBox emailEingabeLogin;
        private System.Windows.Forms.TextBox passwortEingabe;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Button btLoginDone;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btShowPassword;
    }
}
