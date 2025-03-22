namespace Sistema_Remuneraciones.app.UI.admin
{
    partial class admin_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_menu));
            admin_menu_strip = new MenuStrip();
            EmployerToolStripMenuItem = new ToolStripMenuItem();
            addEmployerToolStripMenuItem = new ToolStripMenuItem();
            UpdateEmployerToolStripMenuItem = new ToolStripMenuItem();
            eliminarTrabajadorToolStripMenuItem = new ToolStripMenuItem();
            CalculateSalaryToolStripMenuItem = new ToolStripMenuItem();
            EmployersListToolStripMenuItem = new ToolStripMenuItem();
            btn_logout = new Button();
            addemployer_panel = new Panel();
            addemployer_phone = new TextBox();
            addemployer_phonelabel = new Label();
            addemployer_btnadd = new Button();
            addemployer_addresslabel = new Label();
            addemployer_address = new TextBox();
            addemployer_rut = new TextBox();
            addemployer_rutlabel = new Label();
            addemployer_lastnamelabel = new Label();
            addemployer_lastname = new TextBox();
            addemployer_firstname = new TextBox();
            addemployer_firstnamelabel = new Label();
            addemployer_subtitle = new Label();
            addemployer_title = new Label();
            updateemployer_panel = new Panel();
            updateemployer_btnupdate = new Button();
            updateemployer_phone = new TextBox();
            updateemployer_phonelabel = new Label();
            updateemployer_btnsearch = new Button();
            updateemployer_addresslabel = new Label();
            updateemployer_address = new TextBox();
            updateemployer_rut = new TextBox();
            updateemployer_rutlabel = new Label();
            updateemployer_lastnamelabel = new Label();
            updateemployer_lastname = new TextBox();
            updateemployer_firstname = new TextBox();
            updateemployer_firstnamelabel = new Label();
            updateemployer_subtitle = new Label();
            updateemployer_title = new Label();
            deleteemployer_panel = new Panel();
            deleteemployer_btnsearch = new Button();
            deleteemployer_rut = new TextBox();
            deleteemployer_rutlabel = new Label();
            deleteemployer_subtitle = new Label();
            deleteemployer_title = new Label();
            calculatesalary_panel = new Panel();
            calculatesalary_btns_group = new GroupBox();
            calculatesalary_btnadd = new Button();
            calculatesalary_btnclear = new Button();
            calculatesalary_btncalculate = new Button();
            calculatesalary_resultsalary_group = new GroupBox();
            calculatesalary_netsalary = new TextBox();
            calculatesalary_grosssalary = new TextBox();
            calculatesalary_netsalarylabel = new Label();
            calculatesalary_grosssalarylabel = new Label();
            calculatesalary_afphealth_group = new GroupBox();
            calculatesalary_healthlabel = new Label();
            calculatesalary_health = new ComboBox();
            calculatesalary_afp = new ComboBox();
            calculatesalary_afplabel = new Label();
            calculatesalary_searchemployer_groupbox = new GroupBox();
            calculatesalary_btnsearch = new Button();
            calculatesalary_rut = new TextBox();
            calculatesalary_tiplabel = new Label();
            calculatesalary_rutlabel = new Label();
            calculatesalary_workinfo_group = new GroupBox();
            calculatesalary_extrahourslabel = new Label();
            calculatesalary_extrahours = new TextBox();
            calculatesalary_workedhours = new TextBox();
            calculatesalary_workedhourslabel = new Label();
            calculatesalary_subtitle = new Label();
            calculatesalary_title = new Label();
            employerslist_panel = new Panel();
            employerslist_datagrid_group = new GroupBox();
            employerslist_datagrid = new DataGridView();
            employerslist_subtitle = new Label();
            employerslist_title = new Label();
            mainmenu_panel = new Panel();
            mainmenu_group = new GroupBox();
            mainmenu_subtitle = new Label();
            mainmenu_title = new Label();
            admin_menu_strip.SuspendLayout();
            addemployer_panel.SuspendLayout();
            updateemployer_panel.SuspendLayout();
            deleteemployer_panel.SuspendLayout();
            calculatesalary_panel.SuspendLayout();
            calculatesalary_btns_group.SuspendLayout();
            calculatesalary_resultsalary_group.SuspendLayout();
            calculatesalary_afphealth_group.SuspendLayout();
            calculatesalary_searchemployer_groupbox.SuspendLayout();
            calculatesalary_workinfo_group.SuspendLayout();
            employerslist_panel.SuspendLayout();
            employerslist_datagrid_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employerslist_datagrid).BeginInit();
            mainmenu_panel.SuspendLayout();
            mainmenu_group.SuspendLayout();
            SuspendLayout();
            // 
            // admin_menu_strip
            // 
            admin_menu_strip.Items.AddRange(new ToolStripItem[] { EmployerToolStripMenuItem, CalculateSalaryToolStripMenuItem, EmployersListToolStripMenuItem });
            admin_menu_strip.Location = new Point(0, 0);
            admin_menu_strip.Name = "admin_menu_strip";
            admin_menu_strip.Size = new Size(1264, 24);
            admin_menu_strip.TabIndex = 1;
            admin_menu_strip.Text = "admin_menu_strip";
            // 
            // EmployerToolStripMenuItem
            // 
            EmployerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addEmployerToolStripMenuItem, UpdateEmployerToolStripMenuItem, eliminarTrabajadorToolStripMenuItem });
            EmployerToolStripMenuItem.Name = "EmployerToolStripMenuItem";
            EmployerToolStripMenuItem.Size = new Size(74, 20);
            EmployerToolStripMenuItem.Text = "Trabajador";
            // 
            // addEmployerToolStripMenuItem
            // 
            addEmployerToolStripMenuItem.Name = "addEmployerToolStripMenuItem";
            addEmployerToolStripMenuItem.Size = new Size(183, 22);
            addEmployerToolStripMenuItem.Text = "Añadir Trabajador";
            addEmployerToolStripMenuItem.Click += AddEmployerToolStripMenuItem_Click;
            // 
            // UpdateEmployerToolStripMenuItem
            // 
            UpdateEmployerToolStripMenuItem.Name = "UpdateEmployerToolStripMenuItem";
            UpdateEmployerToolStripMenuItem.Size = new Size(183, 22);
            UpdateEmployerToolStripMenuItem.Text = "Modificar Trabajador";
            UpdateEmployerToolStripMenuItem.Click += UpdateEmployerToolStripMenuItem_Click;
            // 
            // eliminarTrabajadorToolStripMenuItem
            // 
            eliminarTrabajadorToolStripMenuItem.Name = "eliminarTrabajadorToolStripMenuItem";
            eliminarTrabajadorToolStripMenuItem.Size = new Size(183, 22);
            eliminarTrabajadorToolStripMenuItem.Text = "Eliminar Trabajador";
            eliminarTrabajadorToolStripMenuItem.Click += eliminarTrabajadorToolStripMenuItem_Click;
            // 
            // CalculateSalaryToolStripMenuItem
            // 
            CalculateSalaryToolStripMenuItem.Name = "CalculateSalaryToolStripMenuItem";
            CalculateSalaryToolStripMenuItem.Size = new Size(153, 20);
            CalculateSalaryToolStripMenuItem.Text = "Calcular Remuneraciones";
            CalculateSalaryToolStripMenuItem.Click += CalculateSalaryToolStripMenuItem_Click;
            // 
            // EmployersListToolStripMenuItem
            // 
            EmployersListToolStripMenuItem.Name = "EmployersListToolStripMenuItem";
            EmployersListToolStripMenuItem.Size = new Size(120, 20);
            EmployersListToolStripMenuItem.Text = "Lista de Empleados";
            EmployersListToolStripMenuItem.Click += EmployersListToolStripMenuItem_Click;
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_logout.BackColor = Color.IndianRed;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.FlatStyle = FlatStyle.Popup;
            btn_logout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.Snow;
            btn_logout.Location = new Point(1152, 27);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(100, 32);
            btn_logout.TabIndex = 2;
            btn_logout.Text = "Cerrar Sesión";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // addemployer_panel
            // 
            addemployer_panel.Controls.Add(addemployer_phone);
            addemployer_panel.Controls.Add(addemployer_phonelabel);
            addemployer_panel.Controls.Add(addemployer_btnadd);
            addemployer_panel.Controls.Add(addemployer_addresslabel);
            addemployer_panel.Controls.Add(addemployer_address);
            addemployer_panel.Controls.Add(addemployer_rut);
            addemployer_panel.Controls.Add(addemployer_rutlabel);
            addemployer_panel.Controls.Add(addemployer_lastnamelabel);
            addemployer_panel.Controls.Add(addemployer_lastname);
            addemployer_panel.Controls.Add(addemployer_firstname);
            addemployer_panel.Controls.Add(addemployer_firstnamelabel);
            addemployer_panel.Controls.Add(addemployer_subtitle);
            addemployer_panel.Controls.Add(addemployer_title);
            addemployer_panel.Location = new Point(12, 67);
            addemployer_panel.Name = "addemployer_panel";
            addemployer_panel.Size = new Size(1240, 602);
            addemployer_panel.TabIndex = 3;
            // 
            // addemployer_phone
            // 
            addemployer_phone.Location = new Point(635, 265);
            addemployer_phone.Name = "addemployer_phone";
            addemployer_phone.Size = new Size(209, 23);
            addemployer_phone.TabIndex = 12;
            // 
            // addemployer_phonelabel
            // 
            addemployer_phonelabel.AutoSize = true;
            addemployer_phonelabel.Location = new Point(635, 247);
            addemployer_phonelabel.Name = "addemployer_phonelabel";
            addemployer_phonelabel.Size = new Size(119, 15);
            addemployer_phonelabel.TabIndex = 11;
            addemployer_phonelabel.Text = "Número de Contacto";
            // 
            // addemployer_btnadd
            // 
            addemployer_btnadd.Location = new Point(546, 394);
            addemployer_btnadd.Name = "addemployer_btnadd";
            addemployer_btnadd.Size = new Size(140, 29);
            addemployer_btnadd.TabIndex = 10;
            addemployer_btnadd.Text = "Añadir Trabajador";
            addemployer_btnadd.UseVisualStyleBackColor = true;
            addemployer_btnadd.Click += addemployer_btnadd_Click;
            // 
            // addemployer_addresslabel
            // 
            addemployer_addresslabel.AutoSize = true;
            addemployer_addresslabel.Location = new Point(386, 310);
            addemployer_addresslabel.Name = "addemployer_addresslabel";
            addemployer_addresslabel.Size = new Size(57, 15);
            addemployer_addresslabel.TabIndex = 9;
            addemployer_addresslabel.Text = "Dirección";
            // 
            // addemployer_address
            // 
            addemployer_address.Location = new Point(386, 328);
            addemployer_address.Name = "addemployer_address";
            addemployer_address.Size = new Size(458, 23);
            addemployer_address.TabIndex = 8;
            // 
            // addemployer_rut
            // 
            addemployer_rut.Location = new Point(386, 265);
            addemployer_rut.Name = "addemployer_rut";
            addemployer_rut.Size = new Size(209, 23);
            addemployer_rut.TabIndex = 7;
            // 
            // addemployer_rutlabel
            // 
            addemployer_rutlabel.AutoSize = true;
            addemployer_rutlabel.Location = new Point(386, 247);
            addemployer_rutlabel.Name = "addemployer_rutlabel";
            addemployer_rutlabel.Size = new Size(28, 15);
            addemployer_rutlabel.TabIndex = 6;
            addemployer_rutlabel.Text = "RUT";
            // 
            // addemployer_lastnamelabel
            // 
            addemployer_lastnamelabel.AutoSize = true;
            addemployer_lastnamelabel.Location = new Point(635, 175);
            addemployer_lastnamelabel.Name = "addemployer_lastnamelabel";
            addemployer_lastnamelabel.Size = new Size(51, 15);
            addemployer_lastnamelabel.TabIndex = 5;
            addemployer_lastnamelabel.Text = "Apellido";
            // 
            // addemployer_lastname
            // 
            addemployer_lastname.Location = new Point(635, 193);
            addemployer_lastname.Name = "addemployer_lastname";
            addemployer_lastname.Size = new Size(209, 23);
            addemployer_lastname.TabIndex = 4;
            // 
            // addemployer_firstname
            // 
            addemployer_firstname.Location = new Point(386, 193);
            addemployer_firstname.Name = "addemployer_firstname";
            addemployer_firstname.Size = new Size(209, 23);
            addemployer_firstname.TabIndex = 3;
            // 
            // addemployer_firstnamelabel
            // 
            addemployer_firstnamelabel.AutoSize = true;
            addemployer_firstnamelabel.Location = new Point(386, 175);
            addemployer_firstnamelabel.Name = "addemployer_firstnamelabel";
            addemployer_firstnamelabel.Size = new Size(51, 15);
            addemployer_firstnamelabel.TabIndex = 2;
            addemployer_firstnamelabel.Text = "Nombre";
            // 
            // addemployer_subtitle
            // 
            addemployer_subtitle.AutoSize = true;
            addemployer_subtitle.Location = new Point(431, 136);
            addemployer_subtitle.Name = "addemployer_subtitle";
            addemployer_subtitle.Size = new Size(374, 15);
            addemployer_subtitle.TabIndex = 1;
            addemployer_subtitle.Text = "agrega un trabajador a la compañia rellenando este simple formulario";
            addemployer_subtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // addemployer_title
            // 
            addemployer_title.AutoSize = true;
            addemployer_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addemployer_title.Location = new Point(517, 89);
            addemployer_title.Name = "addemployer_title";
            addemployer_title.Size = new Size(216, 25);
            addemployer_title.TabIndex = 0;
            addemployer_title.Text = "Agregar un Trabajador";
            // 
            // updateemployer_panel
            // 
            updateemployer_panel.Controls.Add(updateemployer_btnupdate);
            updateemployer_panel.Controls.Add(updateemployer_phone);
            updateemployer_panel.Controls.Add(updateemployer_phonelabel);
            updateemployer_panel.Controls.Add(updateemployer_btnsearch);
            updateemployer_panel.Controls.Add(updateemployer_addresslabel);
            updateemployer_panel.Controls.Add(updateemployer_address);
            updateemployer_panel.Controls.Add(updateemployer_rut);
            updateemployer_panel.Controls.Add(updateemployer_rutlabel);
            updateemployer_panel.Controls.Add(updateemployer_lastnamelabel);
            updateemployer_panel.Controls.Add(updateemployer_lastname);
            updateemployer_panel.Controls.Add(updateemployer_firstname);
            updateemployer_panel.Controls.Add(updateemployer_firstnamelabel);
            updateemployer_panel.Controls.Add(updateemployer_subtitle);
            updateemployer_panel.Controls.Add(updateemployer_title);
            updateemployer_panel.Location = new Point(12, 67);
            updateemployer_panel.Name = "updateemployer_panel";
            updateemployer_panel.Size = new Size(1240, 602);
            updateemployer_panel.TabIndex = 3;
            // 
            // updateemployer_btnupdate
            // 
            updateemployer_btnupdate.Location = new Point(537, 485);
            updateemployer_btnupdate.Name = "updateemployer_btnupdate";
            updateemployer_btnupdate.Size = new Size(151, 31);
            updateemployer_btnupdate.TabIndex = 13;
            updateemployer_btnupdate.Text = "Actualizar Trabajador";
            updateemployer_btnupdate.UseVisualStyleBackColor = true;
            updateemployer_btnupdate.Click += updateemployer_btnupdate_Click;
            // 
            // updateemployer_phone
            // 
            updateemployer_phone.Location = new Point(534, 394);
            updateemployer_phone.Name = "updateemployer_phone";
            updateemployer_phone.Size = new Size(154, 23);
            updateemployer_phone.TabIndex = 12;
            // 
            // updateemployer_phonelabel
            // 
            updateemployer_phonelabel.AutoSize = true;
            updateemployer_phonelabel.Location = new Point(546, 376);
            updateemployer_phonelabel.Name = "updateemployer_phonelabel";
            updateemployer_phonelabel.Size = new Size(119, 15);
            updateemployer_phonelabel.TabIndex = 11;
            updateemployer_phonelabel.Text = "Número de Contacto";
            // 
            // updateemployer_btnsearch
            // 
            updateemployer_btnsearch.Location = new Point(548, 204);
            updateemployer_btnsearch.Name = "updateemployer_btnsearch";
            updateemployer_btnsearch.Size = new Size(140, 29);
            updateemployer_btnsearch.TabIndex = 10;
            updateemployer_btnsearch.Text = "Buscar Trabajador";
            updateemployer_btnsearch.UseVisualStyleBackColor = true;
            updateemployer_btnsearch.Click += updateemployer_btnsearch_Click;
            // 
            // updateemployer_addresslabel
            // 
            updateemployer_addresslabel.AutoSize = true;
            updateemployer_addresslabel.Location = new Point(386, 418);
            updateemployer_addresslabel.Name = "updateemployer_addresslabel";
            updateemployer_addresslabel.Size = new Size(57, 15);
            updateemployer_addresslabel.TabIndex = 9;
            updateemployer_addresslabel.Text = "Dirección";
            // 
            // updateemployer_address
            // 
            updateemployer_address.Location = new Point(386, 436);
            updateemployer_address.Name = "updateemployer_address";
            updateemployer_address.Size = new Size(458, 23);
            updateemployer_address.TabIndex = 8;
            // 
            // updateemployer_rut
            // 
            updateemployer_rut.Location = new Point(524, 175);
            updateemployer_rut.Name = "updateemployer_rut";
            updateemployer_rut.Size = new Size(209, 23);
            updateemployer_rut.TabIndex = 7;
            // 
            // updateemployer_rutlabel
            // 
            updateemployer_rutlabel.AutoSize = true;
            updateemployer_rutlabel.Location = new Point(474, 178);
            updateemployer_rutlabel.Name = "updateemployer_rutlabel";
            updateemployer_rutlabel.Size = new Size(28, 15);
            updateemployer_rutlabel.TabIndex = 6;
            updateemployer_rutlabel.Text = "RUT";
            // 
            // updateemployer_lastnamelabel
            // 
            updateemployer_lastnamelabel.AutoSize = true;
            updateemployer_lastnamelabel.Location = new Point(635, 301);
            updateemployer_lastnamelabel.Name = "updateemployer_lastnamelabel";
            updateemployer_lastnamelabel.Size = new Size(51, 15);
            updateemployer_lastnamelabel.TabIndex = 5;
            updateemployer_lastnamelabel.Text = "Apellido";
            // 
            // updateemployer_lastname
            // 
            updateemployer_lastname.Location = new Point(635, 319);
            updateemployer_lastname.Name = "updateemployer_lastname";
            updateemployer_lastname.Size = new Size(209, 23);
            updateemployer_lastname.TabIndex = 4;
            // 
            // updateemployer_firstname
            // 
            updateemployer_firstname.Location = new Point(386, 319);
            updateemployer_firstname.Name = "updateemployer_firstname";
            updateemployer_firstname.Size = new Size(209, 23);
            updateemployer_firstname.TabIndex = 3;
            // 
            // updateemployer_firstnamelabel
            // 
            updateemployer_firstnamelabel.AutoSize = true;
            updateemployer_firstnamelabel.Location = new Point(386, 301);
            updateemployer_firstnamelabel.Name = "updateemployer_firstnamelabel";
            updateemployer_firstnamelabel.Size = new Size(51, 15);
            updateemployer_firstnamelabel.TabIndex = 2;
            updateemployer_firstnamelabel.Text = "Nombre";
            // 
            // updateemployer_subtitle
            // 
            updateemployer_subtitle.AutoSize = true;
            updateemployer_subtitle.Location = new Point(422, 136);
            updateemployer_subtitle.Name = "updateemployer_subtitle";
            updateemployer_subtitle.Size = new Size(394, 15);
            updateemployer_subtitle.TabIndex = 1;
            updateemployer_subtitle.Text = "Actualiza a un trabajador buscando su rut y obtener sus datos principales.";
            updateemployer_subtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // updateemployer_title
            // 
            updateemployer_title.AutoSize = true;
            updateemployer_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateemployer_title.Location = new Point(517, 89);
            updateemployer_title.Name = "updateemployer_title";
            updateemployer_title.Size = new Size(195, 25);
            updateemployer_title.TabIndex = 0;
            updateemployer_title.Text = "Editar un Trabajador";
            // 
            // deleteemployer_panel
            // 
            deleteemployer_panel.Controls.Add(deleteemployer_btnsearch);
            deleteemployer_panel.Controls.Add(deleteemployer_rut);
            deleteemployer_panel.Controls.Add(deleteemployer_rutlabel);
            deleteemployer_panel.Controls.Add(deleteemployer_subtitle);
            deleteemployer_panel.Controls.Add(deleteemployer_title);
            deleteemployer_panel.Location = new Point(12, 65);
            deleteemployer_panel.Name = "deleteemployer_panel";
            deleteemployer_panel.Size = new Size(1240, 602);
            deleteemployer_panel.TabIndex = 3;
            // 
            // deleteemployer_btnsearch
            // 
            deleteemployer_btnsearch.Location = new Point(551, 243);
            deleteemployer_btnsearch.Name = "deleteemployer_btnsearch";
            deleteemployer_btnsearch.Size = new Size(140, 29);
            deleteemployer_btnsearch.TabIndex = 10;
            deleteemployer_btnsearch.Text = "Buscar Trabajador";
            deleteemployer_btnsearch.UseVisualStyleBackColor = true;
            deleteemployer_btnsearch.Click += deleteemployer_btnsearch_Click;
            // 
            // deleteemployer_rut
            // 
            deleteemployer_rut.Location = new Point(520, 214);
            deleteemployer_rut.Name = "deleteemployer_rut";
            deleteemployer_rut.Size = new Size(209, 23);
            deleteemployer_rut.TabIndex = 7;
            // 
            // deleteemployer_rutlabel
            // 
            deleteemployer_rutlabel.AutoSize = true;
            deleteemployer_rutlabel.Location = new Point(477, 217);
            deleteemployer_rutlabel.Name = "deleteemployer_rutlabel";
            deleteemployer_rutlabel.Size = new Size(28, 15);
            deleteemployer_rutlabel.TabIndex = 6;
            deleteemployer_rutlabel.Text = "RUT";
            // 
            // deleteemployer_subtitle
            // 
            deleteemployer_subtitle.AutoSize = true;
            deleteemployer_subtitle.Location = new Point(434, 177);
            deleteemployer_subtitle.Name = "deleteemployer_subtitle";
            deleteemployer_subtitle.Size = new Size(394, 15);
            deleteemployer_subtitle.TabIndex = 1;
            deleteemployer_subtitle.Text = "Actualiza a un trabajador buscando su rut y obtener sus datos principales.";
            deleteemployer_subtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // deleteemployer_title
            // 
            deleteemployer_title.AutoSize = true;
            deleteemployer_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteemployer_title.Location = new Point(517, 130);
            deleteemployer_title.Name = "deleteemployer_title";
            deleteemployer_title.Size = new Size(212, 25);
            deleteemployer_title.TabIndex = 0;
            deleteemployer_title.Text = "Eliminar un trabajador";
            // 
            // calculatesalary_panel
            // 
            calculatesalary_panel.Controls.Add(calculatesalary_btns_group);
            calculatesalary_panel.Controls.Add(calculatesalary_resultsalary_group);
            calculatesalary_panel.Controls.Add(calculatesalary_afphealth_group);
            calculatesalary_panel.Controls.Add(calculatesalary_searchemployer_groupbox);
            calculatesalary_panel.Controls.Add(calculatesalary_workinfo_group);
            calculatesalary_panel.Controls.Add(calculatesalary_subtitle);
            calculatesalary_panel.Controls.Add(calculatesalary_title);
            calculatesalary_panel.Location = new Point(12, 64);
            calculatesalary_panel.Name = "calculatesalary_panel";
            calculatesalary_panel.Size = new Size(1240, 602);
            calculatesalary_panel.TabIndex = 3;
            // 
            // calculatesalary_btns_group
            // 
            calculatesalary_btns_group.Controls.Add(calculatesalary_btnadd);
            calculatesalary_btns_group.Controls.Add(calculatesalary_btnclear);
            calculatesalary_btns_group.Controls.Add(calculatesalary_btncalculate);
            calculatesalary_btns_group.Location = new Point(365, 439);
            calculatesalary_btns_group.Name = "calculatesalary_btns_group";
            calculatesalary_btns_group.Size = new Size(451, 86);
            calculatesalary_btns_group.TabIndex = 20;
            calculatesalary_btns_group.TabStop = false;
            // 
            // calculatesalary_btnadd
            // 
            calculatesalary_btnadd.Location = new Point(172, 29);
            calculatesalary_btnadd.Name = "calculatesalary_btnadd";
            calculatesalary_btnadd.Size = new Size(91, 37);
            calculatesalary_btnadd.TabIndex = 2;
            calculatesalary_btnadd.Text = "Añadir Datos";
            calculatesalary_btnadd.UseVisualStyleBackColor = true;
            calculatesalary_btnadd.Click += calculatesalary_btnadd_Click;
            // 
            // calculatesalary_btnclear
            // 
            calculatesalary_btnclear.Location = new Point(305, 29);
            calculatesalary_btnclear.Name = "calculatesalary_btnclear";
            calculatesalary_btnclear.Size = new Size(104, 37);
            calculatesalary_btnclear.TabIndex = 1;
            calculatesalary_btnclear.Text = "Limpiar Campos";
            calculatesalary_btnclear.UseVisualStyleBackColor = true;
            calculatesalary_btnclear.Click += calculatesalary_btnclear_Click;
            // 
            // calculatesalary_btncalculate
            // 
            calculatesalary_btncalculate.Location = new Point(41, 29);
            calculatesalary_btncalculate.Name = "calculatesalary_btncalculate";
            calculatesalary_btncalculate.Size = new Size(96, 37);
            calculatesalary_btncalculate.TabIndex = 0;
            calculatesalary_btncalculate.Text = "Calcular Salario";
            calculatesalary_btncalculate.UseVisualStyleBackColor = true;
            calculatesalary_btncalculate.Click += calculatesalary_btncalculate_Click;
            // 
            // calculatesalary_resultsalary_group
            // 
            calculatesalary_resultsalary_group.Controls.Add(calculatesalary_netsalary);
            calculatesalary_resultsalary_group.Controls.Add(calculatesalary_grosssalary);
            calculatesalary_resultsalary_group.Controls.Add(calculatesalary_netsalarylabel);
            calculatesalary_resultsalary_group.Controls.Add(calculatesalary_grosssalarylabel);
            calculatesalary_resultsalary_group.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            calculatesalary_resultsalary_group.Location = new Point(345, 268);
            calculatesalary_resultsalary_group.Name = "calculatesalary_resultsalary_group";
            calculatesalary_resultsalary_group.Size = new Size(499, 122);
            calculatesalary_resultsalary_group.TabIndex = 19;
            calculatesalary_resultsalary_group.TabStop = false;
            calculatesalary_resultsalary_group.Text = "Resultado de Salario";
            // 
            // calculatesalary_netsalary
            // 
            calculatesalary_netsalary.Font = new Font("Segoe UI", 9F);
            calculatesalary_netsalary.Location = new Point(274, 53);
            calculatesalary_netsalary.Name = "calculatesalary_netsalary";
            calculatesalary_netsalary.ReadOnly = true;
            calculatesalary_netsalary.Size = new Size(209, 23);
            calculatesalary_netsalary.TabIndex = 21;
            // 
            // calculatesalary_grosssalary
            // 
            calculatesalary_grosssalary.Font = new Font("Segoe UI", 9F);
            calculatesalary_grosssalary.Location = new Point(6, 53);
            calculatesalary_grosssalary.Name = "calculatesalary_grosssalary";
            calculatesalary_grosssalary.ReadOnly = true;
            calculatesalary_grosssalary.Size = new Size(209, 23);
            calculatesalary_grosssalary.TabIndex = 20;
            // 
            // calculatesalary_netsalarylabel
            // 
            calculatesalary_netsalarylabel.AutoSize = true;
            calculatesalary_netsalarylabel.Font = new Font("Segoe UI", 8.25F);
            calculatesalary_netsalarylabel.Location = new Point(274, 34);
            calculatesalary_netsalarylabel.Name = "calculatesalary_netsalarylabel";
            calculatesalary_netsalarylabel.Size = new Size(85, 13);
            calculatesalary_netsalarylabel.TabIndex = 20;
            calculatesalary_netsalarylabel.Text = "Sueldo Liquido";
            // 
            // calculatesalary_grosssalarylabel
            // 
            calculatesalary_grosssalarylabel.AutoSize = true;
            calculatesalary_grosssalarylabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculatesalary_grosssalarylabel.Location = new Point(6, 34);
            calculatesalary_grosssalarylabel.Name = "calculatesalary_grosssalarylabel";
            calculatesalary_grosssalarylabel.Size = new Size(74, 13);
            calculatesalary_grosssalarylabel.TabIndex = 20;
            calculatesalary_grosssalarylabel.Text = "Sueldo Bruto";
            // 
            // calculatesalary_afphealth_group
            // 
            calculatesalary_afphealth_group.Controls.Add(calculatesalary_healthlabel);
            calculatesalary_afphealth_group.Controls.Add(calculatesalary_health);
            calculatesalary_afphealth_group.Controls.Add(calculatesalary_afp);
            calculatesalary_afphealth_group.Controls.Add(calculatesalary_afplabel);
            calculatesalary_afphealth_group.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            calculatesalary_afphealth_group.Location = new Point(895, 131);
            calculatesalary_afphealth_group.Name = "calculatesalary_afphealth_group";
            calculatesalary_afphealth_group.Size = new Size(200, 259);
            calculatesalary_afphealth_group.TabIndex = 18;
            calculatesalary_afphealth_group.TabStop = false;
            calculatesalary_afphealth_group.Text = "Información de Salud";
            // 
            // calculatesalary_healthlabel
            // 
            calculatesalary_healthlabel.AutoSize = true;
            calculatesalary_healthlabel.Font = new Font("Segoe UI", 8.25F);
            calculatesalary_healthlabel.Location = new Point(17, 122);
            calculatesalary_healthlabel.Name = "calculatesalary_healthlabel";
            calculatesalary_healthlabel.Size = new Size(36, 13);
            calculatesalary_healthlabel.TabIndex = 3;
            calculatesalary_healthlabel.Text = "Salud";
            // 
            // calculatesalary_health
            // 
            calculatesalary_health.Font = new Font("Segoe UI", 9F);
            calculatesalary_health.FormattingEnabled = true;
            calculatesalary_health.Location = new Point(17, 138);
            calculatesalary_health.Name = "calculatesalary_health";
            calculatesalary_health.Size = new Size(152, 23);
            calculatesalary_health.TabIndex = 2;
            // 
            // calculatesalary_afp
            // 
            calculatesalary_afp.Font = new Font("Segoe UI", 9F);
            calculatesalary_afp.FormattingEnabled = true;
            calculatesalary_afp.Location = new Point(17, 58);
            calculatesalary_afp.Name = "calculatesalary_afp";
            calculatesalary_afp.Size = new Size(152, 23);
            calculatesalary_afp.TabIndex = 1;
            // 
            // calculatesalary_afplabel
            // 
            calculatesalary_afplabel.AutoSize = true;
            calculatesalary_afplabel.Font = new Font("Segoe UI", 8.25F);
            calculatesalary_afplabel.Location = new Point(17, 37);
            calculatesalary_afplabel.Name = "calculatesalary_afplabel";
            calculatesalary_afplabel.Size = new Size(26, 13);
            calculatesalary_afplabel.TabIndex = 0;
            calculatesalary_afplabel.Text = "AFP";
            // 
            // calculatesalary_searchemployer_groupbox
            // 
            calculatesalary_searchemployer_groupbox.Controls.Add(calculatesalary_btnsearch);
            calculatesalary_searchemployer_groupbox.Controls.Add(calculatesalary_rut);
            calculatesalary_searchemployer_groupbox.Controls.Add(calculatesalary_tiplabel);
            calculatesalary_searchemployer_groupbox.Controls.Add(calculatesalary_rutlabel);
            calculatesalary_searchemployer_groupbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculatesalary_searchemployer_groupbox.Location = new Point(22, 119);
            calculatesalary_searchemployer_groupbox.Name = "calculatesalary_searchemployer_groupbox";
            calculatesalary_searchemployer_groupbox.Size = new Size(254, 172);
            calculatesalary_searchemployer_groupbox.TabIndex = 17;
            calculatesalary_searchemployer_groupbox.TabStop = false;
            calculatesalary_searchemployer_groupbox.Text = "Buscar Empleado";
            // 
            // calculatesalary_btnsearch
            // 
            calculatesalary_btnsearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculatesalary_btnsearch.Location = new Point(57, 85);
            calculatesalary_btnsearch.Name = "calculatesalary_btnsearch";
            calculatesalary_btnsearch.Size = new Size(140, 29);
            calculatesalary_btnsearch.TabIndex = 10;
            calculatesalary_btnsearch.Text = "Buscar Trabajador";
            calculatesalary_btnsearch.UseVisualStyleBackColor = true;
            calculatesalary_btnsearch.Click += calculatesalary_btnsearch_Click;
            // 
            // calculatesalary_rut
            // 
            calculatesalary_rut.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculatesalary_rut.Location = new Point(20, 49);
            calculatesalary_rut.Name = "calculatesalary_rut";
            calculatesalary_rut.Size = new Size(209, 23);
            calculatesalary_rut.TabIndex = 7;
            // 
            // calculatesalary_tiplabel
            // 
            calculatesalary_tiplabel.AutoSize = true;
            calculatesalary_tiplabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            calculatesalary_tiplabel.Location = new Point(34, 131);
            calculatesalary_tiplabel.Name = "calculatesalary_tiplabel";
            calculatesalary_tiplabel.Size = new Size(195, 26);
            calculatesalary_tiplabel.TabIndex = 14;
            calculatesalary_tiplabel.Text = "TIP: para calcular las remuneraciones es\r\nnecesario ingresar el rut del trabajador.";
            calculatesalary_tiplabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // calculatesalary_rutlabel
            // 
            calculatesalary_rutlabel.AutoSize = true;
            calculatesalary_rutlabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculatesalary_rutlabel.Location = new Point(20, 31);
            calculatesalary_rutlabel.Name = "calculatesalary_rutlabel";
            calculatesalary_rutlabel.Size = new Size(28, 13);
            calculatesalary_rutlabel.TabIndex = 6;
            calculatesalary_rutlabel.Text = "RUT";
            // 
            // calculatesalary_workinfo_group
            // 
            calculatesalary_workinfo_group.Controls.Add(calculatesalary_extrahourslabel);
            calculatesalary_workinfo_group.Controls.Add(calculatesalary_extrahours);
            calculatesalary_workinfo_group.Controls.Add(calculatesalary_workedhours);
            calculatesalary_workinfo_group.Controls.Add(calculatesalary_workedhourslabel);
            calculatesalary_workinfo_group.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculatesalary_workinfo_group.Location = new Point(345, 131);
            calculatesalary_workinfo_group.Name = "calculatesalary_workinfo_group";
            calculatesalary_workinfo_group.Size = new Size(499, 116);
            calculatesalary_workinfo_group.TabIndex = 16;
            calculatesalary_workinfo_group.TabStop = false;
            calculatesalary_workinfo_group.Text = "Información Laboral";
            // 
            // calculatesalary_extrahourslabel
            // 
            calculatesalary_extrahourslabel.AutoSize = true;
            calculatesalary_extrahourslabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculatesalary_extrahourslabel.Location = new Point(276, 41);
            calculatesalary_extrahourslabel.Name = "calculatesalary_extrahourslabel";
            calculatesalary_extrahourslabel.Size = new Size(65, 13);
            calculatesalary_extrahourslabel.TabIndex = 14;
            calculatesalary_extrahourslabel.Text = "Horas Extra";
            // 
            // calculatesalary_extrahours
            // 
            calculatesalary_extrahours.Font = new Font("Segoe UI", 9F);
            calculatesalary_extrahours.Location = new Point(274, 57);
            calculatesalary_extrahours.Name = "calculatesalary_extrahours";
            calculatesalary_extrahours.Size = new Size(209, 23);
            calculatesalary_extrahours.TabIndex = 11;
            // 
            // calculatesalary_workedhours
            // 
            calculatesalary_workedhours.Font = new Font("Segoe UI", 9F);
            calculatesalary_workedhours.Location = new Point(6, 57);
            calculatesalary_workedhours.Name = "calculatesalary_workedhours";
            calculatesalary_workedhours.Size = new Size(209, 23);
            calculatesalary_workedhours.TabIndex = 12;
            // 
            // calculatesalary_workedhourslabel
            // 
            calculatesalary_workedhourslabel.AutoSize = true;
            calculatesalary_workedhourslabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculatesalary_workedhourslabel.Location = new Point(6, 41);
            calculatesalary_workedhourslabel.Name = "calculatesalary_workedhourslabel";
            calculatesalary_workedhourslabel.Size = new Size(95, 13);
            calculatesalary_workedhourslabel.TabIndex = 13;
            calculatesalary_workedhourslabel.Text = "Horas Trabajadas";
            // 
            // calculatesalary_subtitle
            // 
            calculatesalary_subtitle.AutoSize = true;
            calculatesalary_subtitle.Location = new Point(332, 50);
            calculatesalary_subtitle.Name = "calculatesalary_subtitle";
            calculatesalary_subtitle.Size = new Size(575, 15);
            calculatesalary_subtitle.TabIndex = 1;
            calculatesalary_subtitle.Text = "Calcula el salario del trabajador mediante este simple formulario además de los descuentos por Salud y AFP.";
            calculatesalary_subtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // calculatesalary_title
            // 
            calculatesalary_title.AutoSize = true;
            calculatesalary_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculatesalary_title.Location = new Point(507, 15);
            calculatesalary_title.Name = "calculatesalary_title";
            calculatesalary_title.Size = new Size(235, 25);
            calculatesalary_title.TabIndex = 0;
            calculatesalary_title.Text = "Calcular Remuneraciones";
            // 
            // employerslist_panel
            // 
            employerslist_panel.Controls.Add(employerslist_datagrid_group);
            employerslist_panel.Controls.Add(employerslist_subtitle);
            employerslist_panel.Controls.Add(employerslist_title);
            employerslist_panel.Location = new Point(12, 64);
            employerslist_panel.Name = "employerslist_panel";
            employerslist_panel.Size = new Size(1240, 602);
            employerslist_panel.TabIndex = 3;
            // 
            // employerslist_datagrid_group
            // 
            employerslist_datagrid_group.Controls.Add(employerslist_datagrid);
            employerslist_datagrid_group.Location = new Point(42, 108);
            employerslist_datagrid_group.Name = "employerslist_datagrid_group";
            employerslist_datagrid_group.Size = new Size(1160, 465);
            employerslist_datagrid_group.TabIndex = 2;
            employerslist_datagrid_group.TabStop = false;
            // 
            // employerslist_datagrid
            // 
            employerslist_datagrid.AllowUserToAddRows = false;
            employerslist_datagrid.AllowUserToDeleteRows = false;
            employerslist_datagrid.AllowUserToResizeColumns = false;
            employerslist_datagrid.AllowUserToResizeRows = false;
            employerslist_datagrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employerslist_datagrid.BackgroundColor = SystemColors.ButtonHighlight;
            employerslist_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employerslist_datagrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            employerslist_datagrid.Location = new Point(6, 15);
            employerslist_datagrid.MultiSelect = false;
            employerslist_datagrid.Name = "employerslist_datagrid";
            employerslist_datagrid.ReadOnly = true;
            employerslist_datagrid.RowHeadersVisible = false;
            employerslist_datagrid.ScrollBars = ScrollBars.Vertical;
            employerslist_datagrid.Size = new Size(1148, 444);
            employerslist_datagrid.TabIndex = 0;
            employerslist_datagrid.TabStop = false;
            // 
            // employerslist_subtitle
            // 
            employerslist_subtitle.AutoSize = true;
            employerslist_subtitle.Location = new Point(321, 50);
            employerslist_subtitle.Name = "employerslist_subtitle";
            employerslist_subtitle.Size = new Size(555, 30);
            employerslist_subtitle.TabIndex = 1;
            employerslist_subtitle.Text = "Ver lista actual de los trabajadores de la empresa. Se mostarará los siguientes campos de los trabajadores\r\nRUT, Nombre, Apellido, Numero de contacto, Salario Liquido, Salario Bruto, AFP y Salud\r\n";
            employerslist_subtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // employerslist_title
            // 
            employerslist_title.AutoSize = true;
            employerslist_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employerslist_title.Location = new Point(507, 15);
            employerslist_title.Name = "employerslist_title";
            employerslist_title.Size = new Size(180, 25);
            employerslist_title.TabIndex = 0;
            employerslist_title.Text = "Lista de Empleados";
            // 
            // mainmenu_panel
            // 
            mainmenu_panel.Controls.Add(mainmenu_group);
            mainmenu_panel.Location = new Point(12, 64);
            mainmenu_panel.Name = "mainmenu_panel";
            mainmenu_panel.Size = new Size(1240, 602);
            mainmenu_panel.TabIndex = 3;
            // 
            // mainmenu_group
            // 
            mainmenu_group.Controls.Add(mainmenu_subtitle);
            mainmenu_group.Controls.Add(mainmenu_title);
            mainmenu_group.Location = new Point(36, 23);
            mainmenu_group.Name = "mainmenu_group";
            mainmenu_group.Size = new Size(1160, 560);
            mainmenu_group.TabIndex = 2;
            mainmenu_group.TabStop = false;
            // 
            // mainmenu_subtitle
            // 
            mainmenu_subtitle.AutoSize = true;
            mainmenu_subtitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainmenu_subtitle.Location = new Point(69, 253);
            mainmenu_subtitle.Name = "mainmenu_subtitle";
            mainmenu_subtitle.Size = new Size(1019, 90);
            mainmenu_subtitle.TabIndex = 1;
            mainmenu_subtitle.Text = resources.GetString("mainmenu_subtitle.Text");
            mainmenu_subtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // mainmenu_title
            // 
            mainmenu_title.AutoSize = true;
            mainmenu_title.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainmenu_title.Location = new Point(355, 184);
            mainmenu_title.Name = "mainmenu_title";
            mainmenu_title.Size = new Size(437, 50);
            mainmenu_title.TabIndex = 0;
            mainmenu_title.Text = "Bienvenid@ {username}";
            // 
            // admin_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btn_logout);
            Controls.Add(admin_menu_strip);
            Controls.Add(updateemployer_panel);
            Controls.Add(addemployer_panel);
            Controls.Add(mainmenu_panel);
            Controls.Add(employerslist_panel);
            Controls.Add(calculatesalary_panel);
            Controls.Add(deleteemployer_panel);
            MainMenuStrip = admin_menu_strip;
            MaximizeBox = false;
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "admin_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel Administrativo -  Sistema Remuneraciones";
            Load += admin_menu_Load;
            admin_menu_strip.ResumeLayout(false);
            admin_menu_strip.PerformLayout();
            addemployer_panel.ResumeLayout(false);
            addemployer_panel.PerformLayout();
            updateemployer_panel.ResumeLayout(false);
            updateemployer_panel.PerformLayout();
            deleteemployer_panel.ResumeLayout(false);
            deleteemployer_panel.PerformLayout();
            calculatesalary_panel.ResumeLayout(false);
            calculatesalary_panel.PerformLayout();
            calculatesalary_btns_group.ResumeLayout(false);
            calculatesalary_resultsalary_group.ResumeLayout(false);
            calculatesalary_resultsalary_group.PerformLayout();
            calculatesalary_afphealth_group.ResumeLayout(false);
            calculatesalary_afphealth_group.PerformLayout();
            calculatesalary_searchemployer_groupbox.ResumeLayout(false);
            calculatesalary_searchemployer_groupbox.PerformLayout();
            calculatesalary_workinfo_group.ResumeLayout(false);
            calculatesalary_workinfo_group.PerformLayout();
            employerslist_panel.ResumeLayout(false);
            employerslist_panel.PerformLayout();
            employerslist_datagrid_group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employerslist_datagrid).EndInit();
            mainmenu_panel.ResumeLayout(false);
            mainmenu_group.ResumeLayout(false);
            mainmenu_group.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip admin_menu_strip;
        private ToolStripMenuItem EmployerToolStripMenuItem;
        private ToolStripMenuItem addEmployerToolStripMenuItem;
        private ToolStripMenuItem UpdateEmployerToolStripMenuItem;
        private ToolStripMenuItem CalculateSalaryToolStripMenuItem;
        private ToolStripMenuItem EmployersListToolStripMenuItem;
        private Button btn_logout;
        private Panel addemployer_panel;
        private Label addemployer_title;
        private TextBox addemployer_lastname;
        private TextBox addemployer_firstname;
        private Label addemployer_firstnamelabel;
        private Label addemployer_subtitle;
        private Label addemployer_rutlabel;
        private Label addemployer_lastnamelabel;
        private TextBox addemployer_address;
        private TextBox addemployer_rut;
        private Label addemployer_addresslabel;
        private Button addemployer_btnadd;
        private Label addemployer_phonelabel;
        private TextBox addemployer_phone;
        private Panel updateemployer_panel;
        private TextBox updateemployer_phone;
        private Label updateemployer_phonelabel;
        private Button updateemployer_btnsearch;
        private Label updateemployer_addresslabel;
        private TextBox updateemployer_address;
        private TextBox updateemployer_rut;
        private Label updateemployer_rutlabel;
        private Label updateemployer_lastnamelabel;
        private TextBox updateemployer_lastname;
        private TextBox updateemployer_firstname;
        private Label updateemployer_firstnamelabel;
        private Label updateemployer_subtitle;
        private Label updateemployer_title;
        private Button updateemployer_btnupdate;
        private ToolStripMenuItem eliminarTrabajadorToolStripMenuItem;
        private Panel deleteemployer_panel;
        private Button deleteemployer_btnsearch;
        private TextBox deleteemployer_rut;
        private Label deleteemployer_rutlabel;
        private Label deleteemployer_subtitle;
        private Label deleteemployer_title;
        private Panel calculatesalary_panel;
        private Button calculatesalary_btnsearch;
        private TextBox calculatesalary_rut;
        private Label calculatesalary_rutlabel;
        private Label calculatesalary_subtitle;
        private Label calculatesalary_title;
        private TextBox calculatesalary_extrahours;
        private Label calculatesalary_tiplabel;
        private TextBox calculatesalary_workedhours;
        private Label calculatesalary_workedhourslabel;
        private GroupBox calculatesalary_workinfo_group;
        private Label calculatesalary_extrahourslabel;
        private GroupBox calculatesalary_searchemployer_groupbox;
        private GroupBox calculatesalary_resultsalary_group;
        private TextBox calculatesalary_grosssalary;
        private Label calculatesalary_netsalarylabel;
        private Label calculatesalary_grosssalarylabel;
        private GroupBox calculatesalary_afphealth_group;
        private Label calculatesalary_healthlabel;
        private ComboBox calculatesalary_health;
        private ComboBox calculatesalary_afp;
        private Label calculatesalary_afplabel;
        private GroupBox calculatesalary_btns_group;
        private Button calculatesalary_btncalculate;
        private TextBox calculatesalary_netsalary;
        private Button calculatesalary_btnadd;
        private Button calculatesalary_btnclear;
        private Panel employerslist_panel;
        private Label employerslist_subtitle;
        private Label employerslist_title;
        private GroupBox employerslist_datagrid_group;
        private DataGridView employerslist_datagrid;
        private Panel mainmenu_panel;
        private GroupBox mainmenu_group;
        private Label mainmenu_subtitle;
        private Label mainmenu_title;
    }
}