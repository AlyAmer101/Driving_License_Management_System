using DVLD.Properties;
using DVLD.General_Classes;
using DVLD___BusinessLayer;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class frmPeopleManagement : Form
    {

        //! My Methods 
        enum enPeopleFilter { None, PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, Nationality, Gendor, Phone, Email}

        public void RefreashdgvPeople()
        {
            this.peopleTableAdapter.FillBy(this.dVLDDataSet.People);
            labRecordCount.Text = clsPeople.PeopleCount().ToString();
            
            dgvPeople.Rows[0].Selected = true;
        }
       
        void _dgvPeopleFilter(string ColumnName, string FilterValue)
        {
            switch (ColumnName)
            {
                case "Gendor":

                    if (FilterValue.ToLower().StartsWith("m"))
                        peopleBindingSource.Filter = $"{ColumnName} = '0'";

                    else if (FilterValue.ToLower().StartsWith("f"))
                        peopleBindingSource.Filter = $"{ColumnName} = '1'";

                    break;


                case "NationalityCountryID":

                    int CountryID = clsCountries.GetCountryIdByName(FilterValue);

                    if (CountryID != -1)
                        peopleBindingSource.Filter = $"{ColumnName} = '{CountryID}'";

                    break;


                default:

                    peopleBindingSource.Filter = $"{ColumnName} LIKE '%{FilterValue}%'";

                    break;
            }


        }
        void _dgvPeopleFilter(string ColumnName, int FilterValue)
        {
            if (ColumnName == "Phone")
                peopleBindingSource.Filter = $"{ColumnName} Like '{FilterValue}%'";
            else
                peopleBindingSource.Filter = $"{ColumnName} = '{FilterValue}'";
        }

        
        //! Starting Methods
        public frmPeopleManagement()
        {
            InitializeComponent();

            clsGlobalSettings.NormalizeForm(this);

            cbPeopleFilter.SelectedIndex = (int)enPeopleFilter.None;
            tbFilterValue.Visible = false;

            //! Set ContextMenue Images 
            ShowDetailsToolStripMenuItem.Image = Resources.PersonDetails_32;
            editToolStripMenuItem.Image = Resources.edit_32;
            deleteToolStripMenuItem.Image = Resources.Delete_32;
            sendToolStripMenuItem.Image = Resources.send_email_32;
            callPhoneToolStripMenuItem.Image = Resources.call_32;

            addNewPersonToolStripMenuItem.Image = Resources.AddPerson_32;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dVLDDataSet.People' table. You can move, or remove it, as needed.
            RefreashdgvPeople();
        }


        //! Helper Methods  (On Clicks, On Changed, etc..)
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;

            frmPersonInfo frm = new frmPersonInfo(PersonID);
            frm.ShowDialog();

            RefreashdgvPeople();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewPerson_Click_1(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;

            Form frm = new frmAddPerson(PersonID);

            frm.ShowDialog();

            RefreashdgvPeople();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;

            if (clsPeople.IsPersonLinkedWithData(PersonID))
            {
                clsUtility.ErorrMessage("Person was not deleted, becuase he has data linked with.");
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete Person [{PersonID}]", "Confirm Delelte", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            { 
                if (clsPeople.DeletePersonByID(PersonID))
                {
                    MessageBox.Show("Person Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreashdgvPeople();


                }   
                else
                    MessageBox.Show("Faild To Delete Person, Check First If This Person is A User System or Connected with System Operation And Try Agine.", "Failded Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Operation Canceled Successfully", "Canceld Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUtility.FeatureNotImplementedMessage();
        }
      
        private void callPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUtility.FeatureNotImplementedMessage();
        }

        private void btnAddNewPerson_Click_1(object sender, EventArgs e)
        {
            Form frm = new frmAddPerson();

            frm.ShowDialog();

            RefreashdgvPeople();
        }


        //! dgvPeople Filter 
        private void cbPeopleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeopleFilter.SelectedIndex == (int)enPeopleFilter.None)
                tbFilterValue.Visible = false;
            else
                tbFilterValue.Visible = true;

        }
      
        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilterValue.Text))
            {
                peopleBindingSource.Filter = "";
                return;
            }

            string FilterValue = tbFilterValue.Text;
            
            switch (cbPeopleFilter.SelectedIndex)
            {

                case (int)enPeopleFilter.PersonID:

                    if (int.TryParse(FilterValue, out int PersonID))
                        _dgvPeopleFilter("PersonID", PersonID);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enPeopleFilter.NationalNo:
                    
                    _dgvPeopleFilter("NationalNo", FilterValue);

                    break;

                case (int)enPeopleFilter.FirstName:

                    _dgvPeopleFilter("FirstName", FilterValue);

                    break;

                case (int)enPeopleFilter.SecondName:

                    _dgvPeopleFilter("SecondName", FilterValue);

                    break;

                case (int)enPeopleFilter.ThirdName:

                    _dgvPeopleFilter("ThirdName", FilterValue);

                    break;

                case (int)enPeopleFilter.LastName:

                    _dgvPeopleFilter("LastName", FilterValue);

                    break;

                case (int)enPeopleFilter.Nationality:

                    _dgvPeopleFilter("NationalityCountryID", FilterValue);
                    break;

                case (int)enPeopleFilter.Gendor:

                    _dgvPeopleFilter("Gendor", FilterValue);

                    break;

                case (int)enPeopleFilter.Phone:

                    if (int.TryParse(FilterValue, out int Phone))
                        _dgvPeopleFilter("Phone", Phone);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enPeopleFilter.Email:
                    
                    _dgvPeopleFilter("Email", FilterValue);

                    break;
            }


        }
        
        private void dgvPeople_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            //if (dgvPeople.Columns[e.ColumnIndex].DataPropertyName == "Gendor")
            //{
            //    if (e.Value != null)
            //    {
            //        e.Value = Convert.ToInt32(e.Value) == 0 ? "Male" : "Female";
            //    }
            //}

            if (dgvPeople.Columns[e.ColumnIndex].DataPropertyName == "NationalityCountryID")
            {
                if (e.Value != null)
                {
                    e.Value = clsCountries.GetCountryNameByID(Convert.ToInt32(e.Value));
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    
    }
}
