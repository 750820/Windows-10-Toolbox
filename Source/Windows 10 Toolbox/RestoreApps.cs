using System;
using System.Management.Automation;
using System.Windows.Forms;
using Windows_10_Toolbox.Properties;

namespace Windows_10_Toolbox
{
    public partial class RestoreApps : Form
    {
        public RestoreApps()
        {
            InitializeComponent();
            progressBar1.Maximum = 1;
            progressBar1.Step = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PowerShell powerShell = PowerShell.Create();

            //Petla w komendzie, przydało by się wyciągnąć ją do C#
            //Inaczej progress bar będzie kompletnie bezużyteczny
            //Zostawiam żeby wyglądało fajnie #tofix

            //Dodanie komedy przywracająej pakiety z folderu instalacyjnego
            string restore = "Get-AppxPackage -AllUsers| Foreach {Add-AppxPackage -DisableDevelopmentMode -Register “$($_.InstallLocation)\\AppXManifest.xml”}";
            powerShell.AddScript(restore);

            //Wykonanie komendy w PS'ie
            powerShell.Invoke();
            powerShell.Stop();

            MessageBox.Show(Resources.Success, Resources.Success_Title);
            Close();
        }
    }
}