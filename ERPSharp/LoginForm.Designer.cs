namespace ERPSharp
{
    partial class LoginForm
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
            BtnSubmitLogin = new Button();
            TxtUsername = new TextBox();
            PanelHeader = new Panel();
            LabelTitle = new Label();
            PanelBody = new Panel();
            TxtPassword = new TextBox();
            LabelPassword = new Label();
            LabelUsername = new Label();
            PanelFooter = new Panel();
            PanelHeader.SuspendLayout();
            PanelBody.SuspendLayout();
            PanelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSubmitLogin
            // 
            BtnSubmitLogin.Dock = DockStyle.Right;
            BtnSubmitLogin.Location = new Point(153, 10);
            BtnSubmitLogin.Name = "BtnSubmitLogin";
            BtnSubmitLogin.Size = new Size(131, 40);
            BtnSubmitLogin.TabIndex = 0;
            BtnSubmitLogin.Text = "Log In";
            BtnSubmitLogin.UseVisualStyleBackColor = true;
            BtnSubmitLogin.Click += BtnSubmitLogin_Click;
            // 
            // TxtUsername
            // 
            TxtUsername.Dock = DockStyle.Top;
            TxtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.Location = new Point(10, 39);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(284, 33);
            TxtUsername.TabIndex = 1;
            // 
            // PanelHeader
            // 
            PanelHeader.Controls.Add(LabelTitle);
            PanelHeader.Dock = DockStyle.Left;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(192, 217);
            PanelHeader.TabIndex = 2;
            // 
            // LabelTitle
            // 
            LabelTitle.Dock = DockStyle.Fill;
            LabelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.ForeColor = Color.Turquoise;
            LabelTitle.Location = new Point(0, 0);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Padding = new Padding(0, 0, 0, 40);
            LabelTitle.Size = new Size(192, 217);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "ERPSharp";
            LabelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelBody
            // 
            PanelBody.Controls.Add(TxtPassword);
            PanelBody.Controls.Add(LabelPassword);
            PanelBody.Controls.Add(TxtUsername);
            PanelBody.Controls.Add(LabelUsername);
            PanelBody.Controls.Add(PanelFooter);
            PanelBody.Dock = DockStyle.Fill;
            PanelBody.Location = new Point(192, 0);
            PanelBody.Name = "PanelBody";
            PanelBody.Padding = new Padding(10);
            PanelBody.Size = new Size(304, 217);
            PanelBody.TabIndex = 3;
            // 
            // TxtPassword
            // 
            TxtPassword.Dock = DockStyle.Top;
            TxtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(10, 101);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(284, 33);
            TxtPassword.TabIndex = 3;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Dock = DockStyle.Top;
            LabelPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.Location = new Point(10, 72);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Padding = new Padding(0, 5, 0, 5);
            LabelPassword.Size = new Size(70, 29);
            LabelPassword.TabIndex = 5;
            LabelPassword.Text = "Password:";
            // 
            // LabelUsername
            // 
            LabelUsername.AutoSize = true;
            LabelUsername.Dock = DockStyle.Top;
            LabelUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUsername.Location = new Point(10, 10);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Padding = new Padding(0, 5, 0, 5);
            LabelUsername.Size = new Size(74, 29);
            LabelUsername.TabIndex = 4;
            LabelUsername.Text = "Username:";
            // 
            // PanelFooter
            // 
            PanelFooter.Controls.Add(BtnSubmitLogin);
            PanelFooter.Dock = DockStyle.Bottom;
            PanelFooter.Location = new Point(10, 147);
            PanelFooter.Name = "PanelFooter";
            PanelFooter.Padding = new Padding(10, 10, 0, 10);
            PanelFooter.Size = new Size(284, 60);
            PanelFooter.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 217);
            Controls.Add(PanelBody);
            Controls.Add(PanelHeader);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ERPSharp // Login";
            PanelHeader.ResumeLayout(false);
            PanelBody.ResumeLayout(false);
            PanelBody.PerformLayout();
            PanelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSubmitLogin;
        private TextBox TxtUsername;
        private Panel PanelHeader;
        private Panel PanelBody;
        private Panel PanelFooter;
        private Label LabelPassword;
        private Label LabelUsername;
        private TextBox TxtPassword;
        private Label LabelTitle;
    }
}