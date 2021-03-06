namespace OCA.WinUI.BaseInformation
{
    partial class NewClerk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewClerk));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BtnInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ClerkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Access = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClerkGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagePic = new System.Windows.Forms.DataGridViewImageColumn();
            this.SignPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbAccess = new System.Windows.Forms.ComboBox();
            this.CmbUnit = new System.Windows.Forms.ComboBox();
            this.CmbSemat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_NewAccess = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbClerkGroup = new System.Windows.Forms.ComboBox();
            this.BtnShowAll = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.groupBox1);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.DataGridView);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(894, 461);
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateDisabled.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateDisabled.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateNormal.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.Text = "تعریف کارمند";
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "تعریف کارمند";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "توضیحات";
            this.kryptonHeaderGroup1.ValuesSecondary.Image = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(429, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(117, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(26, 93);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnInsert.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnInsert.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnInsert.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnInsert.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnInsert.TabIndex = 8;
            this.BtnInsert.Text = "ثبت";
            this.BtnInsert.Values.ExtraText = "";
            this.BtnInsert.Values.Image = null;
            this.BtnInsert.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnInsert.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnInsert.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnInsert.Values.Text = "ثبت";
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClerkID,
            this.Name_,
            this.Family,
            this.Username,
            this.Pass,
            this.Semat,
            this.Unit,
            this.Access,
            this.ClerkGroup,
            this.Sex,
            this.Age,
            this.Tel,
            this.Mobile,
            this.Email,
            this.Address_,
            this.Expert,
            this.ImagePic,
            this.SignPic});
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.Location = new System.Drawing.Point(34, 148);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(825, 247);
            this.DataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridView.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.TabIndex = 50;
            // 
            // ClerkID
            // 
            this.ClerkID.DataPropertyName = "ClerkID";
            this.ClerkID.HeaderText = "شماره پرسنلی";
            this.ClerkID.Name = "ClerkID";
            this.ClerkID.ReadOnly = true;
            this.ClerkID.Width = 97;
            // 
            // Name_
            // 
            this.Name_.DataPropertyName = "Name_";
            this.Name_.HeaderText = "نام";
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            this.Name_.Width = 47;
            // 
            // Family
            // 
            this.Family.DataPropertyName = "Family";
            this.Family.HeaderText = "نام خانوادگی";
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            this.Family.Width = 85;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "نام کاربری";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 74;
            // 
            // Pass
            // 
            this.Pass.DataPropertyName = "Pass";
            this.Pass.HeaderText = "کلمه عبور";
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            this.Pass.Visible = false;
            this.Pass.Width = 73;
            // 
            // Semat
            // 
            this.Semat.DataPropertyName = "Semat";
            this.Semat.HeaderText = "سمت";
            this.Semat.Name = "Semat";
            this.Semat.ReadOnly = true;
            this.Semat.Width = 62;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "واحد سازمانی";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 91;
            // 
            // Access
            // 
            this.Access.DataPropertyName = "Access";
            this.Access.HeaderText = "دسترسی";
            this.Access.Name = "Access";
            this.Access.ReadOnly = true;
            this.Access.Width = 81;
            // 
            // ClerkGroup
            // 
            this.ClerkGroup.DataPropertyName = "ClerkGroup";
            this.ClerkGroup.HeaderText = "گروه کاربری";
            this.ClerkGroup.Name = "ClerkGroup";
            this.ClerkGroup.ReadOnly = true;
            this.ClerkGroup.Width = 81;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "جنسیت";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 71;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "سن";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 53;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "تلفن";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 55;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            this.Mobile.Width = 62;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 59;
            // 
            // Address_
            // 
            this.Address_.DataPropertyName = "Address_";
            this.Address_.HeaderText = "آدرس";
            this.Address_.Name = "Address_";
            this.Address_.ReadOnly = true;
            this.Address_.Width = 59;
            // 
            // Expert
            // 
            this.Expert.DataPropertyName = "Expert";
            this.Expert.HeaderText = "تخصص";
            this.Expert.Name = "Expert";
            this.Expert.ReadOnly = true;
            this.Expert.Width = 66;
            // 
            // ImagePic
            // 
            this.ImagePic.DataPropertyName = "ImagePic";
            this.ImagePic.HeaderText = "تصویر کاربر";
            this.ImagePic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.ReadOnly = true;
            this.ImagePic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImagePic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImagePic.Width = 76;
            // 
            // SignPic
            // 
            this.SignPic.DataPropertyName = "SignPic";
            this.SignPic.HeaderText = "امضای کاربر";
            this.SignPic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SignPic.Name = "SignPic";
            this.SignPic.ReadOnly = true;
            this.SignPic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SignPic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SignPic.Width = 81;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(614, 55);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(116, 21);
            this.txtFamily.TabIndex = 2;
            this.txtFamily.TextChanged += new System.EventHandler(this.txtFamily_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(734, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "نام خانوادگی";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(614, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 21);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "نام کاربری";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(429, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(116, 21);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "کلمه عبور";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "سمت";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "دسترسی";
            // 
            // CmbAccess
            // 
            this.CmbAccess.FormattingEnabled = true;
            this.CmbAccess.Location = new System.Drawing.Point(265, 25);
            this.CmbAccess.Name = "CmbAccess";
            this.CmbAccess.Size = new System.Drawing.Size(99, 21);
            this.CmbAccess.TabIndex = 5;
            this.CmbAccess.TextChanged += new System.EventHandler(this.CmbAccess_TextChanged);
            // 
            // CmbUnit
            // 
            this.CmbUnit.FormattingEnabled = true;
            this.CmbUnit.Location = new System.Drawing.Point(26, 25);
            this.CmbUnit.Name = "CmbUnit";
            this.CmbUnit.Size = new System.Drawing.Size(116, 21);
            this.CmbUnit.TabIndex = 7;
            this.CmbUnit.TextChanged += new System.EventHandler(this.CmbUnit_TextChanged);
            // 
            // CmbSemat
            // 
            this.CmbSemat.FormattingEnabled = true;
            this.CmbSemat.Location = new System.Drawing.Point(227, 55);
            this.CmbSemat.Name = "CmbSemat";
            this.CmbSemat.Size = new System.Drawing.Size(137, 21);
            this.CmbSemat.TabIndex = 6;
            this.CmbSemat.TextChanged += new System.EventHandler(this.CmbSemat_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "واحد سازمانی";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.Btn_NewAccess);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CmbClerkGroup);
            this.groupBox1.Controls.Add(this.BtnShowAll);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbUnit);
            this.groupBox1.Controls.Add(this.CmbSemat);
            this.groupBox1.Controls.Add(this.BtnInsert);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbAccess);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFamily);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(34, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 127);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات کارمند";
            // 
            // Btn_NewAccess
            // 
            this.Btn_NewAccess.Location = new System.Drawing.Point(227, 25);
            this.Btn_NewAccess.Name = "Btn_NewAccess";
            this.Btn_NewAccess.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.Btn_NewAccess.Size = new System.Drawing.Size(34, 21);
            this.Btn_NewAccess.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_NewAccess.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_NewAccess.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_NewAccess.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_NewAccess.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_NewAccess.TabIndex = 25;
            this.Btn_NewAccess.Text = "جدید";
            this.Btn_NewAccess.Values.ExtraText = "";
            this.Btn_NewAccess.Values.Image = null;
            this.Btn_NewAccess.Values.ImageStates.ImageCheckedNormal = null;
            this.Btn_NewAccess.Values.ImageStates.ImageCheckedPressed = null;
            this.Btn_NewAccess.Values.ImageStates.ImageCheckedTracking = null;
            this.Btn_NewAccess.Values.Text = "جدید";
            this.Btn_NewAccess.Click += new System.EventHandler(this.Btn_NewAccess_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "گروه کاربری";
            // 
            // CmbClerkGroup
            // 
            this.CmbClerkGroup.FormattingEnabled = true;
            this.CmbClerkGroup.Location = new System.Drawing.Point(26, 55);
            this.CmbClerkGroup.Name = "CmbClerkGroup";
            this.CmbClerkGroup.Size = new System.Drawing.Size(116, 21);
            this.CmbClerkGroup.TabIndex = 23;
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.Location = new System.Drawing.Point(107, 93);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnShowAll.Size = new System.Drawing.Size(75, 23);
            this.BtnShowAll.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.TabIndex = 9;
            this.BtnShowAll.Text = "نمایش همه";
            this.BtnShowAll.Values.ExtraText = "";
            this.BtnShowAll.Values.Image = null;
            this.BtnShowAll.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnShowAll.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnShowAll.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnShowAll.Values.Text = "نمایش همه";
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // NewClerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = false;
            this.ClientSize = new System.Drawing.Size(926, 519);
            this.Name = "NewClerk";
            this.WindowText = "تعریف کارمند";
            this.Load += new System.EventHandler(this.NewClerk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnInsert;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridView;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbSemat;
        private System.Windows.Forms.ComboBox CmbUnit;
        private System.Windows.Forms.ComboBox CmbAccess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClerkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Access;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClerkGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expert;
        private System.Windows.Forms.DataGridViewImageColumn ImagePic;
        private System.Windows.Forms.DataGridViewImageColumn SignPic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbClerkGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_NewAccess;

    }
}
