using System;
using System.IO;
using System.Windows.Forms;

namespace CopyFiles
{
    public partial class frmMain : Form
    {
        #region myCodes
        private bool CopyFiles()
        {
            try
            {
                string extPath = Properties.Settings.Default.extPath.ToString();
                string fileName = Path.GetFileName(extPath);
                string nouvPath = txtFolder.Text;
                string nouvFile = string.Format(@"{0}\{1}", nouvPath, fileName);

                if (!Directory.Exists(nouvPath))
                    Directory.CreateDirectory(nouvPath);

                if (File.Exists(nouvFile))
                    File.Delete(nouvFile);

                File.Copy(extPath, nouvFile, true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion myCodes
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (CopyFiles())
                MessageBox.Show("Votre fichier a copié correctement", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkBrowseFolder_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbd.SelectedPath;
            }
        }
    }
}