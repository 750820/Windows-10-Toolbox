using System.IO;
using System.Windows.Forms;
using Windows_10_Toolbox.Properties;

namespace Windows_10_Toolbox
{
    public partial class RemoveWindowsOld : Form
    {
        public RemoveWindowsOld()
        {
            InitializeComponent();
            progressBar1.Maximum = 1;
            progressBar1.Step = 1;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //Usuń folder Windows.old
            Directory.Delete("C:\\Windows.old");
            progressBar1.PerformStep();

            //Powiadom o usunięciu
            MessageBox.Show(Resources.Success, Resources.Success_Title);
        }
    }
}