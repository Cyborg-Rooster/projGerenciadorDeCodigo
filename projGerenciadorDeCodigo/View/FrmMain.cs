using projGerenciadorDeCodigo.Controller;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace projGerenciadorDeCodigo
{
    public partial class FrmMain : Form
    {
        string rootFolder;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void OnButtonSearchClicked(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK) 
            {
                rootFolder = dialog.SelectedPath;
                txtDirectory.Text = rootFolder;
            }
        }

        private void OnButtonStartClicked(object sender, EventArgs e)
        {
            if (ValidateFormsData())
            {
                try
                {
                    SiteController siteController = new SiteController(txtDirectory.Text, txtSiteName.Text, progressBar1);
                    siteController.SetChanges
                    (
                        ckbCanonical.Checked,
                        ckbMobirise.Checked,
                        ckbGoogle.Checked,
                        ckbSitemap.Checked
                    );
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Confira os campos antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidateFormsData()
        {
            if (!ckbCanonical.Checked && !ckbGoogle.Checked && !ckbMobirise.Checked &&
                !ckbSitemap.Checked) return false; 
            else if (ckbCanonical.Checked && txtSiteName.Text == string.Empty || ckbSitemap.Checked && txtSiteName.Text == string.Empty) return false; 
            else if (txtDirectory.Text == string.Empty) return false; 
            else return true;
        }

        private void OnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            string url = "https://github.com/enrisco";

            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}