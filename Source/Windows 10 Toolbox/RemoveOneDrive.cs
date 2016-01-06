using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Windows_10_Toolbox.Properties;

namespace Windows_10_Toolbox
{
    public partial class RemoveOneDrive : Form
    {
        public RemoveOneDrive()
        {
            InitializeComponent();
            progressBar1.Maximum = 13;
            progressBar1.Step = 1;
        }

        public void RemoveOneDriveCmd()
        {
            //Based on RemoveOneDrive CMD Script v.0.4
            //I have no knowledge about orginal author
            //I hold no rights to this script

            //Uruchom CMD
            Process commandline = new Process();
            ProcessStartInfo commandlineinfo = new ProcessStartInfo();
            commandlineinfo.FileName = "cmd.exe";
            commandlineinfo.RedirectStandardInput = true;
            commandlineinfo.UseShellExecute = false;
            commandlineinfo.CreateNoWindow = true;

            //Informacje startowe dla CMD
            commandline.StartInfo = commandlineinfo;
            commandline.Start();

            //Ustaw wpisywanie komend jak z klawiatury
            using (StreamWriter sw = commandline.StandardInput)
            {
                //Potrzebne, inaczej komendy wpisują się od razu zamiast czekac na wywołanie poprzedniej
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("set x86=\"%SYSTEMROOT %\\System32\\OneDriveSetup.exe\"");
                    progressBar1.PerformStep();
                    sw.WriteLine("set x64=\"%SYSTEMROOT %\\SysWOW64\\OneDriveSetup.exe\"");
                    progressBar1.PerformStep();
                    sw.WriteLine("taskkill /f /im OneDrive.exe > NUL 2>&1");
                    progressBar1.PerformStep();
                    sw.WriteLine("ping 127.0.0.1 -n 5 > NUL 2>&1");
                    progressBar1.PerformStep();
                    sw.WriteLine("if exist %x64% %x64% /uninstall");
                    progressBar1.PerformStep();
                    sw.WriteLine("if exist %x86% %x86% /uninstall");
                    progressBar1.PerformStep();
                    sw.WriteLine("ping 127.0.0.1 -n 5 > NUL 2>&1");
                    progressBar1.PerformStep();
                    sw.WriteLine("rd \"%USERPROFILE%\\OneDrive\" /Q /S > NUL 2>&1");
                    progressBar1.PerformStep();
                    sw.WriteLine("rd \"C:\\OneDriveTemp\" /Q /S > NUL 2>&1");
                    progressBar1.PerformStep();
                    sw.WriteLine("rd \"%LOCALAPPDATA%\\Microsoft\\OneDrive\" /Q /S > NUL 2>&1");
                    progressBar1.PerformStep();
                    sw.WriteLine("rd \"%PROGRAMDATA%\\Microsoft OneDrive\" /Q /S > NUL 2>&1");
                    progressBar1.PerformStep();
                    //Eementy usuwania rejestru przeniesione poniżej jako funkcje w C#
                }
            }

            //Zamknij process CMD
            commandline.Close();
        }

        public byte RemoveOneDriveReg()
        {
            //Zmienna analizująca ilość znalezionych kluczy
            byte keyCounter = 0;

            //Szukaj pierwszego klucza
            using (RegistryKey Klucz1 = Registry.LocalMachine.OpenSubKey(@"HKEY_CLASSES_ROOT\CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}"))
            {
                if (Klucz1 != null)
                {
                    //Usuń klucz pierwszy i zwiększ counter
                    keyCounter++;
                    Registry.CurrentUser.DeleteSubKey(@"HKEY_CLASSES_ROOT\CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}");
                }
            }
            progressBar1.PerformStep();

            //Szukaj drugiego klucza
            using (RegistryKey Klucz2 = Registry.LocalMachine.OpenSubKey(@"HKEY_CLASSES_ROOT\Wow6432Node\CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}"))
            {
                if (Klucz2 != null)
                {
                    //Usuń klucz drugi i zwiększ counter
                    keyCounter++;
                    Registry.CurrentUser.DeleteSubKey(@"HKEY_CLASSES_ROOT\Wow6432Node\CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}");
                }
            }
            progressBar1.PerformStep();

            //Jeżeli usunięto oba klucze zwraca 2
            //Jeżeli usunięto tylko jeden zwraca 1
            //Jeżeli nie usunięgto żadnego zwraca 0
            return keyCounter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveOneDriveCmd();
            byte messageValue = RemoveOneDriveReg();

            //Jeżeli oba klucze zostaną znalezione i usunięte
            if (messageValue == 2)
            {
                MessageBox.Show(Resources.Success, Resources.Success_Title);
            }

            //Jeżeli jeden klucz zostanie znaleziony i usunięty
            if (messageValue == 1)
            {
                MessageBox.Show("One key is missing in the registry, OneDrive may be still visible in Explorer's side panel!", "Missing registry key!");
            }

            //Jeżeli żaden z kluczy nie zostanie znaleziony
            if (messageValue == 0)
            {
                MessageBox.Show("No OneDrive key was found in the registry, OneDrive may be still visible in Explorer's side panel!", "No registry key found!");
            }

            //Zakończ process
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}