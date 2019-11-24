using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GNSS_data_downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkInfoEphIGS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Unable to download GPS ephemeris in automatic mode. You can do this manually by clicking on the link above.");
        }

        #region Sources
        private void linkEphIAC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("ftp://ftp.glonass-iac.ru/MCC/PRODUCTS/");
        }

        private void linkHltIAC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("ftp://ftp.glonass-iac.ru/MCC/STATUS/");
        }

        private void linkEphIGS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("ftp://cddis.nasa.gov/gnss/products/");
        }

        private void linkYuma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.navcen.uscg.gov/?Do=gpsArchives");

        }
        #endregion
        #region Set directory to save
        private void btnDirEphIGS_Click(object sender, EventArgs e)
        {
            //todo: open directory dialog
        }

        private void btnDirYuma_Click(object sender, EventArgs e)
        {
            //todo: open directory dialog
        }

        private void btnDirEphIAC_Click(object sender, EventArgs e)
        {
            //todo: open directory dialog
        }

        private void btnDirHltIAC_Click(object sender, EventArgs e)
        {
            //todo: open directory dialog
        }

        #endregion
        #region Downloading
        private void btnDownEphIGS_Click(object sender, EventArgs e)
        {
            //todo: write download process
        }

        private void btnDownYuma_Click(object sender, EventArgs e)
        {
            //todo: write download process
        }

        private void btnDownEphIAC_Click(object sender, EventArgs e)
        {
            //todo: write download process
        }

        private void btnDownHltIAC_Click(object sender, EventArgs e)
        {
            //todo: write download process
        }
        #endregion

    }
}
