using DVLD.Properties;
using DVLD.Properties;
using DVLD___BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ucPersonInfo : UserControl
    {
        public ucPersonInfo()
        {
            InitializeComponent();
        }
        
        //! My Methods 
        public int PersonID { set; get; }
        public string NationalNo { set; get; }

        clsPeople Person = new clsPeople();

        private void _FillPersonalInfoCardFromObject(clsPeople Person)
        {
            labPersonIDValue.Text = Person.ID.ToString();
            labNameValue.Text = Person.FullName;
            labNationalNoValue.Text = Person.NationalNo;
            labGendorValue.Text = (Person.Gendor == clsPeople.enGendor.Male ? "Male" : "Female");
            labEmailValue.Text = Person.Email;
            labAddressValue.Text = Person.Address;
            labDateOfBirthValue.Text = Person.DateOfBirth.ToShortDateString();
            labPhoneValue.Text = Person.Phone.ToString();
            labCountryValue.Text = Person.CountryName;

            pbPersonImage.ImageLocation = Person.ImagePath;

        }

        public void LoadPersonInfo()
        {
             Person = clsPeople.GetPersonByID(Person.ID);

            _FillPersonalInfoCardFromObject(Person);

            PersonID = Person.ID;
        }

        public void LoadPersonInfo(int PersonID)
        {
             Person = clsPeople.GetPersonByID(PersonID);

            _FillPersonalInfoCardFromObject(Person);

            PersonID = Person.ID;
        }

        public void LoadPersonInfo(string NationalNo)
        {
             Person = clsPeople.GetPersonByNationalNo(NationalNo);

            _FillPersonalInfoCardFromObject(Person);

            PersonID = Person.ID;
        }

        public void Clear()
        {
            labPersonIDValue.Text = "???";
            labNameValue.Text = "???";
            labNationalNoValue.Text = "???";
            labGendorValue.Text = "???";
            labEmailValue.Text = "???";
            labAddressValue.Text = "???";
            labDateOfBirthValue.Text = "???";
            labPhoneValue.Text = "???";
            labCountryValue.Text = "???";

            pbPersonImage.Image = Resources.Male_512;
        }

        public void VisiblingEditPersonalInfoButton(bool Visible = true)
        {
            link_EditPersonalInfo.Visible = Visible;
        }

        //! Healper Methonds 
        private void link_EditPersonalInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddPerson(Person.ID);

            frm.ShowDialog();
                
            LoadPersonInfo(); // Re-Freash Peron Details Card
        }

    }
}
