using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace DVLD.General_Classes
{
    public class clsUtility
    {
        public enum enApplicationTypes
        {
            New_Local_Driving_License_Service = 1,
            Renew_Driving_License_Service = 2,
            Replacement_For_Damaged_Driving_License = 3,
            Replacement_For_Lost_Driving_License = 4,
            Release_Detained_Driving_Licsense = 5,
            New_International_License = 6,
            Retake_Test = 7
        };
        public enum enApplicationStatus { New = 1, Canceled = 2, Completed = 3 };
        public enum enTestTypeIDs { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };
        public enum enTestAppointmentLockStatus { Active = 0, Locked = 1};
        public enum enTestResult { Passed = 1, Failed = 0};
        public enum enVisionTestMode { Normal = 0, Edit = 0, Retake = 1, Edit_Retake = 3, Locked = 4};
        public enum enIssueLicenseReasons { FirstTime = 1, Renew = 2, ReplacementForDamaged = 3, ReplacementForLost = 4};
        public enum enLicenseActivityStatus { Active = 1, NotActive = 0 };
        public enum enReplacementReason { Lost = 4, Damaged = 3};
        public enum enDetainOrRelease { Detain, Release};
        public enum enIsReleased { Yes = 1, No = 0};

        public static int ValidityLengthOfInternationalLicenses
        {
            get { return 1; }
        }
        public static string DateFormat
        {
            get { return "dd/MMM/yyyy"; }
        }

        public static void TextBoxEmptyValidation(Object sender, CancelEventArgs e, ErrorProvider epEmptyTextBox)
        {
            if (((TextBox)sender).Text == String.Empty)
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                epEmptyTextBox.SetError(((TextBox)sender), "Set Value");
            }
            else
            {
                e.Cancel = false;
                epEmptyTextBox.SetError(((TextBox)sender), "");
            }
        }
        public static void TextBoxNumuberValidation(Object sender, CancelEventArgs e, ErrorProvider epEmptyTextBox)
        {
            if (!int.TryParse(((TextBox)sender).Text, out int result))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                epEmptyTextBox.SetError(((TextBox)sender), "Set Numburc Value");
            }
            else
            {
                e.Cancel = false;
                epEmptyTextBox.SetError(((TextBox)sender), "");
            }
        }
        public static void FeatureNotImplementedMessage()
        {
            MessageBox.Show("This Feature Not Implemented Yet", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ErorrMessage(string Message, string Caption = "Erorr")
        {
            MessageBox.Show(Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InfoMessage(string Message)
        {
            MessageBox.Show(Message, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult WarningMessage(string Message)
        {
            return MessageBox.Show(Message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        public static DialogResult QuestionMessage(string Message)
        {
            return MessageBox.Show(Message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void InvalidDatadNotifycation(NotifyIcon Notify)
        {
            Notify.Icon = Properties.Resources.FormIcon;
            Notify.BalloonTipIcon = ToolTipIcon.Error;
            Notify.BalloonTipTitle = "You Are Setting Invlid Data";
            Notify.BalloonTipText = "Set a Numerical Value In Test Fees TextBox, Not Anything Else.";
            Notify.ShowBalloonTip(1000);
        }

        public static string GetStatusName(int StatusID)
        {
            switch ((clsUtility.enApplicationStatus)StatusID)
            {
                case clsUtility.enApplicationStatus.New:
                    return "New";
                    break;

                case clsUtility.enApplicationStatus.Canceled:
                    return "Canceled";
                    break;

                case clsUtility.enApplicationStatus.Completed:
                    return "Completed";
                    break;

            }

            return "??";
        }

        public static void HandleFormWithActiveTestType(PictureBox FormLogo, Label labFormTitle)
        {
            switch (clsGlobalSettings.CurrentActiveTestType)
            {
                case clsUtility.enTestTypeIDs.VisionTest:

                    FormLogo.Image = Properties.Resources.Vision_512;
                    labFormTitle.Text = "Vision Test Appointments";

                    break;

                case clsUtility.enTestTypeIDs.WrittenTest:

                    FormLogo.Image = Properties.Resources.Written_Test_512;
                    labFormTitle.Text = "Written Test Appointments";

                    break;

                case clsUtility.enTestTypeIDs.StreetTest:

                    FormLogo.Image = Properties.Resources.driving_test_512;
                    labFormTitle.Text = "Street Test Appointments";

                    break;

            }


        }


    }
}
