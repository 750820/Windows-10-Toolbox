using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Windows.Forms;
using Windows_10_Toolbox.Properties;

namespace Windows_10_Toolbox
{
    public partial class PackagePicker : Form
    {
        //Tworzenie dictionary
        private Dictionary<string, string> packagelist = new Dictionary<string, string>();

        public PackagePicker()
        {
            InitializeComponent();

            //Ładuje elementy dictionary po inicjalizcji okna
            //Nie wiem czy dobry pomysł
            packagelist.Add("Email & Calendar", "*WindowsCommunicationsApps*");
            packagelist.Add("People", "*People*");
            packagelist.Add("Phone", "*Phone*");
            packagelist.Add("Messages", "*messaging*");
            packagelist.Add("Groove Music", "*zunemusic*");
            packagelist.Add("Get Skype", "*skypeapp*");
            packagelist.Add("Xbox", "*xboxapp*");
            packagelist.Add("Get Office", "*officehub*");
            packagelist.Add("Alarms", "*windowsalarms*");
            packagelist.Add("3D Builder", "*3DBuilder*");
            packagelist.Add("Camera", "*windowscamera*");
            packagelist.Add("Get Started", "*getstarted*");
            packagelist.Add("Maps", "*WindowsMaps*");
            packagelist.Add("Solitaire", "*MicrosoftSolitaireCollection*");
            packagelist.Add("Movies & TV", "*zunevideo*");
            packagelist.Add("News", "*bingnews*");
            packagelist.Add("OneNote", "*onenote*");
            packagelist.Add("Phone Companion", "*WindowsPhone*");
            packagelist.Add("Weather", "*bingweather*");
            packagelist.Add("Sports", "*BingSports*");
            packagelist.Add("Finance", "*bingfinance*");
            packagelist.Add("Voice Recorder", "*soundrecorder*");
            packagelist.Add("Bing", "*bing*");
            packagelist.Add("Photos", "*photos*");
            packagelist.Add("Windows Store", "*store*");
            packagelist.Add("Contact Support", "*ContactSupport*");
            packagelist.Add("Sway", "*sway*");

            foreach (KeyValuePair<string, string> pair in packagelist)
            {
                //Dodaje elementy dictionary jako kolejne pozycje listy
                checkedListBox1.Items.Add(pair.Key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Liczy ile elementów zostało zaznaczonych
            int steps = checkedListBox1.CheckedItems.Count;

            //Progressbar ustawiony na ilosc elementów
            progressBar1.Maximum = steps;
            progressBar1.Step = 1;

            //Pokaż ostrzeżenie że zajmie wcholere czasu
            MessageBox.Show(Resources.Removing_Packages_Wait);

            foreach (string itemChecked in checkedListBox1.CheckedItems)
            {
                //Stówrz powershell
                //Każdy obrót osobny
                PowerShell powerShell = PowerShell.Create();

                //Dodanie komendy do Powershella
                string remove = "Get-AppxPackage " + packagelist[itemChecked] + " | Remove-AppxPackage";
                powerShell.AddScript(remove);

                //Uruchomienie komend i zamknięcie procesu
                powerShell.Invoke();
                powerShell.Stop();

                //Zmiana progresu w progressBar1
                progressBar1.PerformStep();
            }

            //Powiadomienei o zakończeniu procesu
            MessageBox.Show(Resources.Success, Resources.Success_Title);

            //Zamukanie okna wybowu pakietów
            Close();
        }
    }
}