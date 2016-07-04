using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Windows_10_Toolbox
{
    public partial class EditStartMenu : Form
    {
        public EditStartMenu()
        {
            InitializeComponent();
        }

        private void buttonEditForAllUsers_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu");
        }

        private void buttonEditOnlyForMe_Click(object sender, EventArgs e)
        {
            string appDataLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string startFolderLocation = appDataLocation + @"\Microsoft\Windows\Start Menu";
            Process.Start(startFolderLocation);
        }
    }
}