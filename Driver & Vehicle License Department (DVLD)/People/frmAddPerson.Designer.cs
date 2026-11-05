namespace DVLD
{
    partial class frmAddPerson
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPerson));
            this.label5 = new System.Windows.Forms.Label();
            this.labFormTitle = new System.Windows.Forms.Label();
            this.labPeronID = new System.Windows.Forms.Label();
            this.link_Remove = new System.Windows.Forms.LinkLabel();
            this.cbCountriesList = new System.Windows.Forms.ComboBox();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCountries = new DVLD.dsCountries();
            this.link_SetImage = new System.Windows.Forms.LinkLabel();
            this.dtpDataOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ofdSetImage = new System.Windows.Forms.OpenFileDialog();
            this.epRepeatedNationalNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epInvalidEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmptyTextBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.epNotNunberValue = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFillRandomData = new System.Windows.Forms.Button();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.countriesTableAdapter = new DVLD.dsCountriesTableAdapters.CountriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRepeatedNationalNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInvalidEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNotNunberValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Person ID : ";
            // 
            // labFormTitle
            // 
            this.labFormTitle.AutoSize = true;
            this.labFormTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.labFormTitle.ForeColor = System.Drawing.Color.Red;
            this.labFormTitle.Location = new System.Drawing.Point(346, 9);
            this.labFormTitle.Name = "labFormTitle";
            this.labFormTitle.Size = new System.Drawing.Size(279, 48);
            this.labFormTitle.TabIndex = 2;
            this.labFormTitle.Text = "Add New Person";
            // 
            // labPeronID
            // 
            this.labPeronID.AutoSize = true;
            this.labPeronID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPeronID.Location = new System.Drawing.Point(144, 57);
            this.labPeronID.Name = "labPeronID";
            this.labPeronID.Size = new System.Drawing.Size(49, 25);
            this.labPeronID.TabIndex = 63;
            this.labPeronID.Text = "N/A";
            // 
            // link_Remove
            // 
            this.link_Remove.AutoSize = true;
            this.link_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Remove.Location = new System.Drawing.Point(778, 308);
            this.link_Remove.Name = "link_Remove";
            this.link_Remove.Size = new System.Drawing.Size(82, 22);
            this.link_Remove.TabIndex = 1000;
            this.link_Remove.TabStop = true;
            this.link_Remove.Text = "Remove";
            this.link_Remove.Visible = false;
            this.link_Remove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Remove_LinkClicked);
            // 
            // cbCountriesList
            // 
            this.cbCountriesList.DataSource = this.countriesBindingSource;
            this.cbCountriesList.DisplayMember = "CountryName";
            this.cbCountriesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountriesList.FormattingEnabled = true;
            this.cbCountriesList.Location = new System.Drawing.Point(552, 188);
            this.cbCountriesList.Name = "cbCountriesList";
            this.cbCountriesList.Size = new System.Drawing.Size(143, 28);
            this.cbCountriesList.TabIndex = 999;
            this.cbCountriesList.TabStop = false;
            this.cbCountriesList.ValueMember = "CountryID";
            this.cbCountriesList.SelectedIndexChanged += new System.EventHandler(this.cbCountriesList_SelectedIndexChanged);
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.dsCountries;
            // 
            // dsCountries
            // 
            this.dsCountries.DataSetName = "dsCountries";
            this.dsCountries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // link_SetImage
            // 
            this.link_SetImage.AutoSize = true;
            this.link_SetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_SetImage.Location = new System.Drawing.Point(770, 275);
            this.link_SetImage.Name = "link_SetImage";
            this.link_SetImage.Size = new System.Drawing.Size(99, 22);
            this.link_SetImage.TabIndex = 12;
            this.link_SetImage.TabStop = true;
            this.link_SetImage.Text = "Set Image";
            this.link_SetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_SetImage_LinkClicked_1);
            // 
            // dtpDataOfBirth
            // 
            this.dtpDataOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpDataOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataOfBirth.Location = new System.Drawing.Point(552, 99);
            this.dtpDataOfBirth.Name = "dtpDataOfBirth";
            this.dtpDataOfBirth.Size = new System.Drawing.Size(143, 26);
            this.dtpDataOfBirth.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(433, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 76;
            this.label13.Text = "Country:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(444, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 73;
            this.label14.Text = "Phone:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(395, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 20);
            this.label15.TabIndex = 71;
            this.label15.Text = "Date Of Bith:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(552, 147);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(143, 26);
            this.tbPhone.TabIndex = 9;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonImage.Image")));
            this.pbPersonImage.Location = new System.Drawing.Point(729, 99);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(164, 162);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 69;
            this.pbPersonImage.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(787, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 25);
            this.label16.TabIndex = 68;
            this.label16.Text = "Last";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(595, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 25);
            this.label17.TabIndex = 67;
            this.label17.Text = "Third";
            // 
            // ofdSetImage
            // 
            this.ofdSetImage.FileName = "openFileDialog1";
            // 
            // epRepeatedNationalNo
            // 
            this.epRepeatedNationalNo.ContainerControl = this;
            // 
            // epInvalidEmail
            // 
            this.epInvalidEmail.ContainerControl = this;
            // 
            // epEmptyTextBox
            // 
            this.epEmptyTextBox.ContainerControl = this;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(729, 50);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(164, 26);
            this.tbLastName.TabIndex = 4;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // epNotNunberValue
            // 
            this.epNotNunberValue.ContainerControl = this;
            // 
            // tbThirdName
            // 
            this.tbThirdName.Location = new System.Drawing.Point(552, 50);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(143, 26);
            this.tbThirdName.TabIndex = 3;
            this.tbThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.tbThirdName_Validating);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(191, 237);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(504, 118);
            this.tbAddress.TabIndex = 11;
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddress_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox11);
            this.groupBox2.Controls.Add(this.pictureBox12);
            this.groupBox2.Controls.Add(this.pictureBox13);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnFillRandomData);
            this.groupBox2.Controls.Add(this.link_Remove);
            this.groupBox2.Controls.Add(this.cbCountriesList);
            this.groupBox2.Controls.Add(this.link_SetImage);
            this.groupBox2.Controls.Add(this.dtpDataOfBirth);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbPhone);
            this.groupBox2.Controls.Add(this.pbPersonImage);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.tbLastName);
            this.groupBox2.Controls.Add(this.tbThirdName);
            this.groupBox2.Controls.Add(this.tbSecondName);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.pictureBox15);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Controls.Add(this.tbFirstName);
            this.groupBox2.Controls.Add(this.tbAddress);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.tbNationalNo);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Location = new System.Drawing.Point(17, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 440);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(510, 190);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(31, 26);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 1012;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(510, 144);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(31, 26);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 1011;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(510, 96);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(31, 26);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 1010;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1005;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(132, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1006;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(132, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1007;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(132, 190);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1008;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(132, 235);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1009;
            this.pictureBox5.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(410, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 44);
            this.btnClose.TabIndex = 1004;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(564, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 44);
            this.btnSave.TabIndex = 1003;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFillRandomData
            // 
            this.btnFillRandomData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnFillRandomData.FlatAppearance.BorderSize = 2;
            this.btnFillRandomData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillRandomData.Image = ((System.Drawing.Image)(resources.GetObject("btnFillRandomData.Image")));
            this.btnFillRandomData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFillRandomData.Location = new System.Drawing.Point(236, 373);
            this.btnFillRandomData.Name = "btnFillRandomData";
            this.btnFillRandomData.Size = new System.Drawing.Size(150, 44);
            this.btnFillRandomData.TabIndex = 65;
            this.btnFillRandomData.Text = "Fill Randomly";
            this.btnFillRandomData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFillRandomData.UseVisualStyleBackColor = true;
            this.btnFillRandomData.Click += new System.EventHandler(this.btnFillRandomData_Click_1);
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(374, 50);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(143, 26);
            this.tbSecondName.TabIndex = 2;
            this.tbSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.tbSecondName_Validating);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(405, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 25);
            this.label18.TabIndex = 63;
            this.label18.Text = "Second";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(304, 143);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(87, 24);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(266, 142);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(31, 26);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 61;
            this.pictureBox15.TabStop = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(191, 145);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 24);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(191, 50);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(143, 26);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(191, 190);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(143, 26);
            this.tbEmail.TabIndex = 10;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(43, 236);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 20);
            this.label19.TabIndex = 49;
            this.label19.Text = "Address: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(65, 191);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 20);
            this.label20.TabIndex = 48;
            this.label20.Text = "Email: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(54, 143);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 20);
            this.label21.TabIndex = 47;
            this.label21.Text = "Gendor:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(21, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 20);
            this.label22.TabIndex = 46;
            this.label22.Text = "National No:";
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Location = new System.Drawing.Point(191, 99);
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.Size = new System.Drawing.Size(143, 26);
            this.tbNationalNo.TabIndex = 5;
            this.tbNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tbNationalNo_Validating);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(238, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 25);
            this.label23.TabIndex = 44;
            this.label23.Text = "First";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(68, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 20);
            this.label24.TabIndex = 43;
            this.label24.Text = "Name:";
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labPeronID);
            this.Controls.Add(this.labFormTitle);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddPerson";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Person Info";
            this.Load += new System.EventHandler(this.frmAddPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRepeatedNationalNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInvalidEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmptyTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNotNunberValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labFormTitle;
        private System.Windows.Forms.Label labPeronID;
        private System.Windows.Forms.LinkLabel link_Remove;
        private System.Windows.Forms.ComboBox cbCountriesList;
        private System.Windows.Forms.LinkLabel link_SetImage;
        private System.Windows.Forms.DateTimePicker dtpDataOfBirth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.OpenFileDialog ofdSetImage;
        private System.Windows.Forms.ErrorProvider epRepeatedNationalNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbNationalNo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ErrorProvider epInvalidEmail;
        private System.Windows.Forms.ErrorProvider epEmptyTextBox;
        private System.Windows.Forms.ErrorProvider epNotNunberValue;
        private System.Windows.Forms.Button btnFillRandomData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private dsCountries dsCountries;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private dsCountriesTableAdapters.CountriesTableAdapter countriesTableAdapter;
    }
}