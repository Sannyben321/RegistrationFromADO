namespace RegistrationFromADO
{
    partial class Form1
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
            this.lblRedg = new System.Windows.Forms.Label();
            this.lblFirstNmae = new System.Windows.Forms.Label();
            this.TxtFirstNmae = new System.Windows.Forms.TextBox();
            this.Txtlastname = new System.Windows.Forms.TextBox();
            this.lblLastNmae = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.dtpbirthdate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.lblConfirmpswd = new System.Windows.Forms.Label();
            this.TxtEmailId = new System.Windows.Forms.TextBox();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.TxtConfrmpswd = new System.Windows.Forms.TextBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRedg
            // 
            this.lblRedg.AutoSize = true;
            this.lblRedg.BackColor = System.Drawing.Color.Lavender;
            this.lblRedg.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRedg.Location = new System.Drawing.Point(181, 37);
            this.lblRedg.Name = "lblRedg";
            this.lblRedg.Size = new System.Drawing.Size(150, 27);
            this.lblRedg.TabIndex = 0;
            this.lblRedg.Text = "Registration";
            // 
            // lblFirstNmae
            // 
            this.lblFirstNmae.AutoSize = true;
            this.lblFirstNmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNmae.Location = new System.Drawing.Point(71, 106);
            this.lblFirstNmae.Name = "lblFirstNmae";
            this.lblFirstNmae.Size = new System.Drawing.Size(77, 18);
            this.lblFirstNmae.TabIndex = 1;
            this.lblFirstNmae.Text = "FirstName";
            // 
            // TxtFirstNmae
            // 
            this.TxtFirstNmae.Location = new System.Drawing.Point(277, 102);
            this.TxtFirstNmae.Name = "TxtFirstNmae";
            this.TxtFirstNmae.Size = new System.Drawing.Size(148, 22);
            this.TxtFirstNmae.TabIndex = 2;
            // 
            // Txtlastname
            // 
            this.Txtlastname.Location = new System.Drawing.Point(277, 156);
            this.Txtlastname.Name = "Txtlastname";
            this.Txtlastname.Size = new System.Drawing.Size(148, 22);
            this.Txtlastname.TabIndex = 3;
            // 
            // lblLastNmae
            // 
            this.lblLastNmae.AutoSize = true;
            this.lblLastNmae.Location = new System.Drawing.Point(71, 162);
            this.lblLastNmae.Name = "lblLastNmae";
            this.lblLastNmae.Size = new System.Drawing.Size(69, 16);
            this.lblLastNmae.TabIndex = 4;
            this.lblLastNmae.Text = "LastName";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(71, 217);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(62, 16);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "BirthDate";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(71, 266);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(74, 327);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(55, 16);
            this.lblEmailId.TabIndex = 7;
            this.lblEmailId.Text = "Email Id";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(71, 375);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(67, 16);
            this.lblpassword.TabIndex = 8;
            this.lblpassword.Text = "Password";
            // 
            // dtpbirthdate
            // 
            this.dtpbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbirthdate.Location = new System.Drawing.Point(277, 217);
            this.dtpbirthdate.Name = "dtpbirthdate";
            this.dtpbirthdate.Size = new System.Drawing.Size(148, 22);
            this.dtpbirthdate.TabIndex = 9;
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHERS"});
            this.comboBoxgender.Location = new System.Drawing.Point(277, 278);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(148, 24);
            this.comboBoxgender.TabIndex = 10;
            // 
            // lblConfirmpswd
            // 
            this.lblConfirmpswd.AutoSize = true;
            this.lblConfirmpswd.Location = new System.Drawing.Point(71, 438);
            this.lblConfirmpswd.Name = "lblConfirmpswd";
            this.lblConfirmpswd.Size = new System.Drawing.Size(114, 16);
            this.lblConfirmpswd.TabIndex = 11;
            this.lblConfirmpswd.Text = "Confirm password";
            // 
            // TxtEmailId
            // 
            this.TxtEmailId.Location = new System.Drawing.Point(277, 327);
            this.TxtEmailId.Name = "TxtEmailId";
            this.TxtEmailId.Size = new System.Drawing.Size(148, 22);
            this.TxtEmailId.TabIndex = 12;
            // 
            // Txtpassword
            // 
            this.Txtpassword.Location = new System.Drawing.Point(277, 375);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.PasswordChar = '*';
            this.Txtpassword.Size = new System.Drawing.Size(148, 22);
            this.Txtpassword.TabIndex = 13;
            this.Txtpassword.UseSystemPasswordChar = true;
            // 
            // TxtConfrmpswd
            // 
            this.TxtConfrmpswd.Location = new System.Drawing.Point(277, 432);
            this.TxtConfrmpswd.Name = "TxtConfrmpswd";
            this.TxtConfrmpswd.PasswordChar = '*';
            this.TxtConfrmpswd.Size = new System.Drawing.Size(148, 22);
            this.TxtConfrmpswd.TabIndex = 14;
            this.TxtConfrmpswd.UseSystemPasswordChar = true;
            // 
            // btnSignin
            // 
            this.btnSignin.Location = new System.Drawing.Point(149, 507);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(82, 26);
            this.btnSignin.TabIndex = 15;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(358, 509);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 557);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.TxtConfrmpswd);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.TxtEmailId);
            this.Controls.Add(this.lblConfirmpswd);
            this.Controls.Add(this.comboBoxgender);
            this.Controls.Add(this.dtpbirthdate);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblEmailId);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblLastNmae);
            this.Controls.Add(this.Txtlastname);
            this.Controls.Add(this.TxtFirstNmae);
            this.Controls.Add(this.lblFirstNmae);
            this.Controls.Add(this.lblRedg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRedg;
        private System.Windows.Forms.Label lblFirstNmae;
        private System.Windows.Forms.TextBox TxtFirstNmae;
        private System.Windows.Forms.TextBox Txtlastname;
        private System.Windows.Forms.Label lblLastNmae;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.DateTimePicker dtpbirthdate;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.Label lblConfirmpswd;
        private System.Windows.Forms.TextBox TxtEmailId;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.TextBox TxtConfrmpswd;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Button btnReset;
    }
}

