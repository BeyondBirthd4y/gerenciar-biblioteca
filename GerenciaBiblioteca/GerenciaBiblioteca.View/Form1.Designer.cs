namespace GerenciaBiblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginBtn = new Button();
            UsernameTxt = new TextBox();
            PasswordTxt = new TextBox();
            UsernameLbl = new Label();
            PasswordLbl = new Label();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(187, 217);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(171, 74);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UsernameTxt
            // 
            UsernameTxt.Location = new Point(187, 106);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(171, 27);
            UsernameTxt.TabIndex = 1;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(187, 165);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(171, 27);
            PasswordTxt.TabIndex = 2;
            PasswordTxt.UseSystemPasswordChar = true;
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.Location = new Point(187, 83);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(75, 20);
            UsernameLbl.TabIndex = 3;
            UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(187, 142);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(70, 20);
            PasswordLbl.TabIndex = 4;
            PasswordLbl.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 323);
            Controls.Add(PasswordLbl);
            Controls.Add(UsernameLbl);
            Controls.Add(PasswordTxt);
            Controls.Add(UsernameTxt);
            Controls.Add(LoginBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private TextBox UsernameTxt;
        private TextBox PasswordTxt;
        private Label UsernameLbl;
        private Label PasswordLbl;
    }
}
