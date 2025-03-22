namespace Sistema_Remuneraciones.app.UI
{
    partial class login_form
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
            label_title = new Label();
            label_username = new Label();
            label_passwd = new Label();
            login_username = new TextBox();
            login_passwd = new TextBox();
            btn_login = new Button();
            tiplabel = new Label();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(105, 42);
            label_title.Name = "label_title";
            label_title.Size = new Size(130, 25);
            label_title.TabIndex = 0;
            label_title.Text = "Iniciar Sesión";
            label_title.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_username
            // 
            label_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_username.AutoSize = true;
            label_username.Location = new Point(74, 95);
            label_username.Name = "label_username";
            label_username.Size = new Size(81, 15);
            label_username.TabIndex = 1;
            label_username.Text = "Usuario o RUT";
            // 
            // label_passwd
            // 
            label_passwd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_passwd.AutoSize = true;
            label_passwd.Location = new Point(74, 178);
            label_passwd.Name = "label_passwd";
            label_passwd.Size = new Size(67, 15);
            label_passwd.TabIndex = 2;
            label_passwd.Text = "Contraseña";
            // 
            // login_username
            // 
            login_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login_username.Location = new Point(74, 113);
            login_username.Name = "login_username";
            login_username.Size = new Size(192, 23);
            login_username.TabIndex = 3;
            // 
            // login_passwd
            // 
            login_passwd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login_passwd.Location = new Point(74, 196);
            login_passwd.Name = "login_passwd";
            login_passwd.PasswordChar = '*';
            login_passwd.Size = new Size(192, 23);
            login_passwd.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.None;
            btn_login.Location = new Point(105, 250);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(130, 29);
            btn_login.TabIndex = 5;
            btn_login.Text = "Iniciar Sesión";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // tiplabel
            // 
            tiplabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tiplabel.AutoSize = true;
            tiplabel.Cursor = Cursors.Help;
            tiplabel.Location = new Point(56, 328);
            tiplabel.Name = "tiplabel";
            tiplabel.Size = new Size(231, 30);
            tiplabel.TabIndex = 6;
            tiplabel.Text = "TIP: si eres trabajador solo ingresa tu RUT y\r\nhaz clic al botón de iniciar sesión";
            tiplabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 367);
            Controls.Add(tiplabel);
            Controls.Add(btn_login);
            Controls.Add(login_passwd);
            Controls.Add(login_username);
            Controls.Add(label_passwd);
            Controls.Add(label_username);
            Controls.Add(label_title);
            MaximizeBox = false;
            MaximumSize = new Size(358, 406);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(358, 406);
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Remuneraciones - Sistema Remuneraciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Label label_username;
        private Label label_passwd;
        private TextBox login_username;
        private TextBox login_passwd;
        private Button btn_login;
        private Label tiplabel;
    }
}