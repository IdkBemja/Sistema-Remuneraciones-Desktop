namespace Sistema_Remuneraciones.app.UI.employer
{
    partial class employer_menu
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
            employer_title = new Label();
            myinfo_personal_group = new GroupBox();
            myinfo_rut = new TextBox();
            myinfo_address = new TextBox();
            myinfo_rutlabel = new Label();
            myinfo_addresslabel = new Label();
            myinfo_phonelabel = new Label();
            myinfo_phone = new TextBox();
            myinfo_name = new TextBox();
            myinfo_namelabel = new Label();
            myinfo_securesafp_group = new GroupBox();
            myinfo_healthlabel = new Label();
            myinfo_afplabel = new Label();
            myinfo_health = new TextBox();
            myinfo_afp = new TextBox();
            myinfo_salary_group = new GroupBox();
            myinfo_grosssalarylabel = new Label();
            myinfo_btncalculate = new Button();
            myinfo_extrahourslabel = new Label();
            myinfo_workedhours = new Label();
            myinfo_netsalary = new TextBox();
            myinfo_netsalarylabel = new Label();
            myinfo_btnlogout = new Button();
            myinfo_personal_group.SuspendLayout();
            myinfo_securesafp_group.SuspendLayout();
            myinfo_salary_group.SuspendLayout();
            SuspendLayout();
            // 
            // employer_title
            // 
            employer_title.AutoSize = true;
            employer_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employer_title.Location = new Point(420, 9);
            employer_title.Name = "employer_title";
            employer_title.Size = new Size(103, 25);
            employer_title.TabIndex = 0;
            employer_title.Text = "Mi Cuenta";
            employer_title.TextAlign = ContentAlignment.TopCenter;
            // 
            // myinfo_personal_group
            // 
            myinfo_personal_group.Controls.Add(myinfo_rut);
            myinfo_personal_group.Controls.Add(myinfo_address);
            myinfo_personal_group.Controls.Add(myinfo_rutlabel);
            myinfo_personal_group.Controls.Add(myinfo_addresslabel);
            myinfo_personal_group.Controls.Add(myinfo_phonelabel);
            myinfo_personal_group.Controls.Add(myinfo_phone);
            myinfo_personal_group.Controls.Add(myinfo_name);
            myinfo_personal_group.Controls.Add(myinfo_namelabel);
            myinfo_personal_group.Location = new Point(12, 56);
            myinfo_personal_group.Name = "myinfo_personal_group";
            myinfo_personal_group.Size = new Size(640, 188);
            myinfo_personal_group.TabIndex = 1;
            myinfo_personal_group.TabStop = false;
            myinfo_personal_group.Text = "Mis Datos";
            // 
            // myinfo_rut
            // 
            myinfo_rut.Location = new Point(229, 53);
            myinfo_rut.Name = "myinfo_rut";
            myinfo_rut.ReadOnly = true;
            myinfo_rut.Size = new Size(178, 23);
            myinfo_rut.TabIndex = 7;
            // 
            // myinfo_address
            // 
            myinfo_address.Location = new Point(6, 136);
            myinfo_address.Name = "myinfo_address";
            myinfo_address.ReadOnly = true;
            myinfo_address.Size = new Size(620, 23);
            myinfo_address.TabIndex = 6;
            // 
            // myinfo_rutlabel
            // 
            myinfo_rutlabel.AutoSize = true;
            myinfo_rutlabel.Location = new Point(229, 35);
            myinfo_rutlabel.Name = "myinfo_rutlabel";
            myinfo_rutlabel.Size = new Size(28, 15);
            myinfo_rutlabel.TabIndex = 5;
            myinfo_rutlabel.Text = "RUT";
            // 
            // myinfo_addresslabel
            // 
            myinfo_addresslabel.AutoSize = true;
            myinfo_addresslabel.Location = new Point(6, 118);
            myinfo_addresslabel.Name = "myinfo_addresslabel";
            myinfo_addresslabel.Size = new Size(74, 15);
            myinfo_addresslabel.TabIndex = 4;
            myinfo_addresslabel.Text = "Mi Dirección";
            // 
            // myinfo_phonelabel
            // 
            myinfo_phonelabel.AutoSize = true;
            myinfo_phonelabel.Location = new Point(433, 35);
            myinfo_phonelabel.Name = "myinfo_phonelabel";
            myinfo_phonelabel.Size = new Size(78, 15);
            myinfo_phonelabel.TabIndex = 3;
            myinfo_phonelabel.Text = "N° Telefonico";
            // 
            // myinfo_phone
            // 
            myinfo_phone.Location = new Point(433, 53);
            myinfo_phone.Name = "myinfo_phone";
            myinfo_phone.ReadOnly = true;
            myinfo_phone.Size = new Size(193, 23);
            myinfo_phone.TabIndex = 2;
            // 
            // myinfo_name
            // 
            myinfo_name.Location = new Point(6, 53);
            myinfo_name.Name = "myinfo_name";
            myinfo_name.ReadOnly = true;
            myinfo_name.Size = new Size(193, 23);
            myinfo_name.TabIndex = 1;
            // 
            // myinfo_namelabel
            // 
            myinfo_namelabel.AutoSize = true;
            myinfo_namelabel.Location = new Point(6, 35);
            myinfo_namelabel.Name = "myinfo_namelabel";
            myinfo_namelabel.Size = new Size(28, 15);
            myinfo_namelabel.TabIndex = 0;
            myinfo_namelabel.Text = "Sr/a";
            // 
            // myinfo_securesafp_group
            // 
            myinfo_securesafp_group.Controls.Add(myinfo_healthlabel);
            myinfo_securesafp_group.Controls.Add(myinfo_afplabel);
            myinfo_securesafp_group.Controls.Add(myinfo_health);
            myinfo_securesafp_group.Controls.Add(myinfo_afp);
            myinfo_securesafp_group.Location = new Point(698, 56);
            myinfo_securesafp_group.Name = "myinfo_securesafp_group";
            myinfo_securesafp_group.Size = new Size(211, 188);
            myinfo_securesafp_group.TabIndex = 2;
            myinfo_securesafp_group.TabStop = false;
            myinfo_securesafp_group.Text = "Seguros y AFP";
            // 
            // myinfo_healthlabel
            // 
            myinfo_healthlabel.AutoSize = true;
            myinfo_healthlabel.Location = new Point(25, 118);
            myinfo_healthlabel.Name = "myinfo_healthlabel";
            myinfo_healthlabel.Size = new Size(36, 15);
            myinfo_healthlabel.TabIndex = 3;
            myinfo_healthlabel.Text = "Salud";
            // 
            // myinfo_afplabel
            // 
            myinfo_afplabel.AutoSize = true;
            myinfo_afplabel.Location = new Point(25, 35);
            myinfo_afplabel.Name = "myinfo_afplabel";
            myinfo_afplabel.Size = new Size(28, 15);
            myinfo_afplabel.TabIndex = 2;
            myinfo_afplabel.Text = "AFP";
            // 
            // myinfo_health
            // 
            myinfo_health.Location = new Point(25, 136);
            myinfo_health.Name = "myinfo_health";
            myinfo_health.ReadOnly = true;
            myinfo_health.Size = new Size(157, 23);
            myinfo_health.TabIndex = 1;
            // 
            // myinfo_afp
            // 
            myinfo_afp.Location = new Point(25, 53);
            myinfo_afp.Name = "myinfo_afp";
            myinfo_afp.ReadOnly = true;
            myinfo_afp.Size = new Size(157, 23);
            myinfo_afp.TabIndex = 0;
            // 
            // myinfo_salary_group
            // 
            myinfo_salary_group.Controls.Add(myinfo_grosssalarylabel);
            myinfo_salary_group.Controls.Add(myinfo_btncalculate);
            myinfo_salary_group.Controls.Add(myinfo_extrahourslabel);
            myinfo_salary_group.Controls.Add(myinfo_workedhours);
            myinfo_salary_group.Controls.Add(myinfo_netsalary);
            myinfo_salary_group.Controls.Add(myinfo_netsalarylabel);
            myinfo_salary_group.Location = new Point(296, 263);
            myinfo_salary_group.Name = "myinfo_salary_group";
            myinfo_salary_group.Size = new Size(356, 175);
            myinfo_salary_group.TabIndex = 3;
            myinfo_salary_group.TabStop = false;
            myinfo_salary_group.Text = "Mi Salario";
            // 
            // myinfo_grosssalarylabel
            // 
            myinfo_grosssalarylabel.AutoSize = true;
            myinfo_grosssalarylabel.Location = new Point(214, 37);
            myinfo_grosssalarylabel.Name = "myinfo_grosssalarylabel";
            myinfo_grosssalarylabel.Size = new Size(92, 15);
            myinfo_grosssalarylabel.TabIndex = 5;
            myinfo_grosssalarylabel.Text = "Sueldo Bruto {0}";
            // 
            // myinfo_btncalculate
            // 
            myinfo_btncalculate.Location = new Point(124, 84);
            myinfo_btncalculate.Name = "myinfo_btncalculate";
            myinfo_btncalculate.Size = new Size(109, 29);
            myinfo_btncalculate.TabIndex = 4;
            myinfo_btncalculate.Text = "Calcular Sueldo";
            myinfo_btncalculate.UseVisualStyleBackColor = true;
            myinfo_btncalculate.Click += myinfo_btncalculate_Click;
            // 
            // myinfo_extrahourslabel
            // 
            myinfo_extrahourslabel.AutoSize = true;
            myinfo_extrahourslabel.Location = new Point(103, 131);
            myinfo_extrahourslabel.Name = "myinfo_extrahourslabel";
            myinfo_extrahourslabel.Size = new Size(154, 15);
            myinfo_extrahourslabel.TabIndex = 3;
            myinfo_extrahourslabel.Text = "Mis horas Extra {extrahours}";
            myinfo_extrahourslabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // myinfo_workedhours
            // 
            myinfo_workedhours.AutoSize = true;
            myinfo_workedhours.Location = new Point(87, 146);
            myinfo_workedhours.Name = "myinfo_workedhours";
            myinfo_workedhours.Size = new Size(195, 15);
            myinfo_workedhours.TabIndex = 2;
            myinfo_workedhours.Text = "Mis horas trabajadas {workedhours}";
            myinfo_workedhours.TextAlign = ContentAlignment.TopCenter;
            // 
            // myinfo_netsalary
            // 
            myinfo_netsalary.Location = new Point(23, 55);
            myinfo_netsalary.Name = "myinfo_netsalary";
            myinfo_netsalary.ReadOnly = true;
            myinfo_netsalary.Size = new Size(298, 23);
            myinfo_netsalary.TabIndex = 1;
            // 
            // myinfo_netsalarylabel
            // 
            myinfo_netsalarylabel.AutoSize = true;
            myinfo_netsalarylabel.Location = new Point(22, 37);
            myinfo_netsalarylabel.Name = "myinfo_netsalarylabel";
            myinfo_netsalarylabel.Size = new Size(86, 15);
            myinfo_netsalarylabel.TabIndex = 0;
            myinfo_netsalarylabel.Text = "Sueldo Liquido";
            // 
            // myinfo_btnlogout
            // 
            myinfo_btnlogout.BackColor = Color.IndianRed;
            myinfo_btnlogout.FlatStyle = FlatStyle.Popup;
            myinfo_btnlogout.ForeColor = Color.Snow;
            myinfo_btnlogout.Location = new Point(868, 9);
            myinfo_btnlogout.Name = "myinfo_btnlogout";
            myinfo_btnlogout.Size = new Size(96, 23);
            myinfo_btnlogout.TabIndex = 4;
            myinfo_btnlogout.Text = "Cerrar Sesión";
            myinfo_btnlogout.UseVisualStyleBackColor = false;
            myinfo_btnlogout.Click += myinfo_btnlogout_Click;
            // 
            // employer_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 450);
            Controls.Add(myinfo_btnlogout);
            Controls.Add(myinfo_salary_group);
            Controls.Add(myinfo_securesafp_group);
            Controls.Add(myinfo_personal_group);
            Controls.Add(employer_title);
            MaximizeBox = false;
            MaximumSize = new Size(992, 489);
            MinimumSize = new Size(992, 489);
            Name = "employer_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vista Trabajador - Sistema Remuneraciones";
            Load += employer_menu_Load;
            myinfo_personal_group.ResumeLayout(false);
            myinfo_personal_group.PerformLayout();
            myinfo_securesafp_group.ResumeLayout(false);
            myinfo_securesafp_group.PerformLayout();
            myinfo_salary_group.ResumeLayout(false);
            myinfo_salary_group.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label employer_title;
        private GroupBox myinfo_personal_group;
        private Label myinfo_phonelabel;
        private TextBox myinfo_phone;
        private TextBox myinfo_name;
        private Label myinfo_namelabel;
        private TextBox myinfo_rut;
        private TextBox myinfo_address;
        private Label myinfo_rutlabel;
        private Label myinfo_addresslabel;
        private GroupBox myinfo_securesafp_group;
        private Label myinfo_afplabel;
        private TextBox myinfo_health;
        private TextBox myinfo_afp;
        private Label myinfo_healthlabel;
        private GroupBox myinfo_salary_group;
        private Button myinfo_btncalculate;
        private Label myinfo_extrahourslabel;
        private Label myinfo_workedhours;
        private TextBox myinfo_netsalary;
        private Label myinfo_netsalarylabel;
        private Label myinfo_grosssalarylabel;
        private Button myinfo_btnlogout;
    }
}