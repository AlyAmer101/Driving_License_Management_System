using DVLD.Properties;
using DVLD.General_Classes;
using DVLD.Properties;
using DVLD___BusinessLayer;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using static DVLD___BusinessLayer.clsPeople;



namespace DVLD
{
    public partial class frmAddPerson : Form
    {

        Random _random = new Random();

        clsPeople Person = new clsPeople();

        bool IsImageChanged = false;
        
        int _PersonID = -1;

        clsPeople.enMode _Mode = enMode.AddNew;

        //! Starting Methods
        public frmAddPerson()
        {
            InitializeComponent();
            clsGlobalSettings.NormalizeForm(this);

            _Mode = enMode.AddNew;
        }

        public frmAddPerson(int PersonID) : this()
        {
            _Mode = enMode.Update;

            _PersonID = PersonID;
        }


        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    _EnabelAddNewMode();
                    break;

                case enMode.Update:

                    _EnabelUpdateMode();
                    break;
            }


            Directory.CreateDirectory(@"C:\DVLD-People-Images");

            // Handle dtp Data Of Birth Logic
            dtpDataOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDataOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDataOfBirth.Value = dtpDataOfBirth.MaxDate;

            
            this.countriesTableAdapter.Fill(this.dsCountries.Countries);
            cbCountriesList.SelectedIndex = cbCountriesList.FindString("Egypt");
        }



        //! My Methods 

        void _ClearForm()
        {
            tbFirstName.Text = "";
            tbSecondName.Text = "";
            tbThirdName.Text = "";
            tbLastName.Text = "";
            tbNationalNo.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            dtpDataOfBirth.Value = dtpDataOfBirth.MinDate;

            pbPersonImage.Image = (rbMale.Checked == true ? Resources.Male_512 : Resources.Female_512);
        }

        string _GenerateRandomValue(string inputType)
        {
            string[] names = { "Ahmed", "Ali", "Omar", "Sara", "Mona", "Khaled", "Youssef", "Noha" };
            string[] cities = { "Cairo", "Alexandria", "Giza", "Tanta", "Mansoura", "Aswan" };
            string[] emailPrefixes = { "user", "test", "dev", "alex", "john", "devcode", "shadow" };
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            string type = inputType?.Trim().ToLower();

            if (type == "name")
            {
                return names[_random.Next(names.Length)];
            }
            else if (type == "nn")
            {
                char randomLetter = letters[_random.Next(letters.Length)];
                int randomNumber = _random.Next(0, 10);
                return $"{randomLetter}{randomNumber}";
            }
            else if (type == "address")
            {
                string city = cities[_random.Next(cities.Length)];
                int streetNumber = _random.Next(1, 501);
                return $"{city} - Street {streetNumber}";
            }
            else if (type == "phone")
            {
                // يولد رقم مكون من 11 خانة يبدأ بـ 01
                string[] prefixes = { "010", "011", "012", "015" };
                string prefix = prefixes[_random.Next(prefixes.Length)];
                int remainingDigits = _random.Next(10000000, 100000000); // 8 أرقام عشوائية
                return $"{prefix}{remainingDigits}";
            }
            else if (type == "email")
            {
                string word = emailPrefixes[_random.Next(emailPrefixes.Length)];
                int randomNum = _random.Next(10, 999);
                return $"{word}{randomNum}@gmail.com";
            }

            return string.Empty;
        }

        private bool _ValidatePersonIsSetImage()
        {
            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation) || pbPersonImage.ImageLocation == "")
            {
                MessageBox.Show("Set Image", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void _FillPersonObjectFromForm(clsPeople Person)
        {
            Person.NationalNo = tbNationalNo.Text;
            Person.FirstName = tbFirstName.Text;
            Person.SecondName = tbSecondName.Text;
            Person.ThirdName = tbThirdName.Text;
            Person.LastName = tbLastName.Text;
            Person.DateOfBirth = dtpDataOfBirth.Value;
            Person.Gendor = (rbMale.Checked ? enGendor.Male : enGendor.Female);
            Person.Address = tbAddress.Text;
            Person.Phone = Convert.ToInt32(tbPhone.Text);
            Person.Email = (tbEmail.Text == string.Empty ? null : tbEmail.Text);
            Person.Country = Convert.ToInt32(cbCountriesList.SelectedValue);

            if (IsImageChanged)
            {
                RemoveOldPersonalImage();
                Person.ImagePath = CopyImageWithGuidName();
            }

        }

        private void _FillFormFromPersonObject(clsPeople Person)
        {
            labPeronID.Text = Person.ID.ToString();
            tbNationalNo.Text = Person.NationalNo;
            tbFirstName.Text = Person.FirstName;
            tbSecondName.Text = Person.SecondName;
            tbThirdName.Text = Person.ThirdName;
            tbLastName.Text = Person.LastName;
            dtpDataOfBirth.Value = Person.DateOfBirth;
            tbAddress.Text = Person.Address;
            tbPhone.Text = Person.Phone.ToString();
            tbEmail.Text = Person.Email;
            cbCountriesList.SelectedValue = Person.Country;

            if (Person.ImagePath != "")
                pbPersonImage.ImageLocation = Person.ImagePath;
            else
                pbPersonImage.Image = Person.Gendor == enGendor.Male ? Resources.Male_512 : Resources.Female_512;
                

            if (Person.Gendor == enGendor.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;


            link_Remove.Visible = (Person.ImagePath != "");
        }

        void _EnabelUpdateMode()
        {
            Person = clsPeople.GetPersonByID(_PersonID);

            labFormTitle.Text = "Update Person";

            _FillFormFromPersonObject(Person);
        }
      
        void _EnabelAddNewMode()
        {
            labFormTitle.Text = "Add New Person";
            link_Remove.Visible = false;

            _ClearForm();

        }


        // Validating TextBox Is Empty Or Not
        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);

        }
        private void tbSecondName_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);
        }
        private void tbThirdName_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);
        }
        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);
        }
        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);

            //!  Validating if value is Numeric or Not
            if (!int.TryParse(tbPhone.Text, out int number))
            {
                e.Cancel = true;
                tbPhone.Focus();
                epEmptyTextBox.SetError(tbPhone, "Set Numeric Value");
            }
            else
            {
                e.Cancel = false;
                epEmptyTextBox.SetError(tbPhone, "");
            }

        }
        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);
        }

        // Validating Email , NationalNo
        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (tbNationalNo.Text == Person.NationalNo)
            {
                e.Cancel = false;
                epRepeatedNationalNo.SetError(tbNationalNo, "");
                return;
            }

            if (clsPeople.IsNationalNoExist(tbNationalNo.Text))
            {
                e.Cancel = true;
                tbNationalNo.Focus();
                epRepeatedNationalNo.SetError(tbNationalNo, "This National Number Is Taken, Use Anotehr One");
            }
            else
            {
                e.Cancel = false;
                epRepeatedNationalNo.SetError(tbNationalNo, "");
            }

        }
        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text == string.Empty)
                return;

            if (!clsPeople.IsValidEmail(tbEmail.Text))
            {
                e.Cancel = true;
                tbEmail.Focus();
                epInvalidEmail.SetError(tbEmail, "Not Valid Email");
            }
            else
            {
                e.Cancel = false;
                epInvalidEmail.SetError(tbEmail, "");
            }
        }

        private void RemoveOldPersonalImage()
        {
            if (!string.IsNullOrEmpty(Person.ImagePath) && File.Exists(Person.ImagePath))
            {
                try
                {
                    File.Delete(Person.ImagePath);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erorr : " + error);
                }

            }
        }

        private string CopyImageWithGuidName()
        {

            string SourcePath = pbPersonImage.ImageLocation;

            string guid = Guid.NewGuid().ToString();
            string FileName = guid + Path.GetExtension(SourcePath);

            string DestinationPath = $@"C:\DVLD-People-Images\{FileName}";

            File.Copy(SourcePath, DestinationPath);

            return DestinationPath;
        }
        public void Save()
        {
            if (!_ValidatePersonIsSetImage())
                return;


            switch (Person.Mode)
            {

                case enMode.AddNew:

                    _FillPersonObjectFromForm(Person);
                    Person.ID = clsPeople.AddNewPeron(Person);
                    clsGlobalSettings.LastAddedPersonId = Person.ID;

                    if (Person.ID != -1)
                    {
                        MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        frmAddPerson frmEditPerson = new frmAddPerson(Person.ID);
                        frmEditPerson.TopMost = true;
                        frmEditPerson.Show();
                        frmEditPerson.StartPosition = FormStartPosition.CenterScreen;

                    }
                    else
                        MessageBox.Show("Faild To Save Data", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;

                case enMode.Update:

                    _FillPersonObjectFromForm(Person);

                    if (clsPeople.UpdatePerson(Person))
                    {
                        MessageBox.Show("Data Updated Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Faild To Save Data", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;

            }
        }


        //! Helper Methods  (On Clicks, On Changed, etc..)

        private void btnFillRandomData_Click_1(object sender, EventArgs e)
        {
            tbNationalNo.Text = _GenerateRandomValue("nn");
            tbFirstName.Text = _GenerateRandomValue("name");
            tbSecondName.Text = _GenerateRandomValue("name");
            tbThirdName.Text = _GenerateRandomValue("name");
            tbLastName.Text = _GenerateRandomValue("name");
            tbAddress.Text = _GenerateRandomValue("address");
            tbPhone.Text = _GenerateRandomValue("phone");
            tbEmail.Text = _GenerateRandomValue("email");

            link_Remove.Visible = true;
        }

        // Handle Gendor Image
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
                pbPersonImage.Image = Resources.Female_512;
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
                pbPersonImage.Image = Resources.Male_512;
        }

        private void link_SetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdSetImage.Title = "Select Image";
            ofdSetImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofdSetImage.FilterIndex = 1;
            ofdSetImage.RestoreDirectory = true;
            ofdSetImage.Multiselect = false;

            if (ofdSetImage.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = ofdSetImage.FileName;

                link_Remove.Visible = true;
                IsImageChanged = true;
            }


        }

        private void link_Remove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.Image = (rbFemale.Checked == true ? Resources.Female_512 : Resources.Male_512);

        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

       
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCountriesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
