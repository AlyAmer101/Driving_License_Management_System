
using DVLD.Properties;
using DVLD___BusinessLayer;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DVLD.General_Classes
{
    public class clsGlobalSettings
    {
        public static int CurrentPersonId { set; get; }
     
        public static int LastAddedPersonId { set; get; }

        public static clsUsers CurrentUser { set; get; }
        

        public static clsUtility.enTestTypeIDs CurrentActiveTestType { set; get; }
        
        public static void NormalizeForm(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.BackColor = Color.White;

            frm.ShowIcon = true;
            frm.Icon = Properties.Resources.FormIcon;
        }


    }
}
