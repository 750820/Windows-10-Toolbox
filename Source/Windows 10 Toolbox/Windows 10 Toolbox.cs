using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Windows_10_Toolbox.Properties;

namespace Windows_10_Toolbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Podepnij do linkLabel1 link do GitHub
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://github.com/TheTechGuy96/Windows-10-Toolbox";
            linkLabel1.Links.Add(link);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Pokaż informację o zakończeniu działania programu
            MessageBox.Show(Resources.Thanks_M8, Resources.Thanks_M8_Title);
            //Zakończ program
            Application.Exit();
        }

        private void buttonRemoveChosen_Click(object sender, EventArgs e)
        {
            //Uruchom Form do wybierania pakietów
            Form packagepicker = new PackagePicker();
            packagepicker.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Wyślij link do syttemu
            //W ten sposób żeby otwierało się do w domyślnej przegladarce
            //Inaczej zawsze startuje w IE
            Process.Start(e.Link.LinkData as string);
        }

        private void buttonRemoveOneDrive_Click(object sender, EventArgs e)
        {
            //Uruchom form do Usunięcia onedrive
            Form removeonedrive = new RemoveOneDrive();
            removeonedrive.Show();
        }

        private void buttonRestoreAll_Click(object sender, EventArgs e)
        {
            //Uruchom Form do przywracania aplikacji
            Form restoreApps = new RestoreApps();
            restoreApps.Show();
        }

        private void buttonRemoveWindowsOld_Click(object sender, EventArgs e)
        {
            //Sprawdź czy folder istnieje na dysku
            if (Directory.Exists("C:\\Windows.old") == false)
            {
                //Powiadom użytkownika że folderu nie ma
                MessageBox.Show(Resources.Window_old_Not_Found, Resources.Windows_old_Not_Found_Title);
            }
            else
            {
                //Uruchom Form do usuwania Windows.Old
                Form removeWindowsOld = new RemoveWindowsOld();
                removeWindowsOld.Show();
            }
        }
    }
}