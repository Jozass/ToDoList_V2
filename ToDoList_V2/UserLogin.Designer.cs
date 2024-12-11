namespace ToDoList_V2
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.btRegister = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.lblAnmeldeTitel = new System.Windows.Forms.Label();
            this.login1 = new ToDoList_V2.Login();
            this.register1 = new ToDoList_V2.Register();
            this.SuspendLayout();
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRegister.Location = new System.Drawing.Point(166, 172);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(140, 23);
            this.btRegister.TabIndex = 35;
            this.btRegister.Text = "Regestrieren";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLogin.Location = new System.Drawing.Point(166, 143);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(140, 23);
            this.btLogin.TabIndex = 34;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lblAnmeldeTitel
            // 
            this.lblAnmeldeTitel.AutoSize = true;
            this.lblAnmeldeTitel.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnmeldeTitel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAnmeldeTitel.Location = new System.Drawing.Point(142, 59);
            this.lblAnmeldeTitel.Name = "lblAnmeldeTitel";
            this.lblAnmeldeTitel.Size = new System.Drawing.Size(190, 46);
            this.lblAnmeldeTitel.TabIndex = 33;
            this.lblAnmeldeTitel.Text = "Anmelden";
            this.lblAnmeldeTitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.login1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.Location = new System.Drawing.Point(-1, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(447, 231);
            this.login1.TabIndex = 0;
            this.login1.Visible = false;
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.register1.Location = new System.Drawing.Point(-1, 0);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(447, 268);
            this.register1.TabIndex = 1;
            this.register1.Visible = false;
            this.register1.Load += new System.EventHandler(this.register1_Load);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(475, 255);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lblAnmeldeTitel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmelden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserLogin_FormClosing);
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Login login1;
        private Register register1;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lblAnmeldeTitel;
    }
}