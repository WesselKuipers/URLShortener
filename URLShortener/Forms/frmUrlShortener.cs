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
using URLShortener.Service;

namespace URLShortener
{
    public partial class frmUrlShortener : Form
    {
        public frmUrlShortener()
        {
            InitializeComponent();
        }

        private void btnShorten_Click(object sender, EventArgs e)
        {
            var result = UrlService.UploadUrl(txtUrl.Text, chkReadable.Checked);
            txtResult.Text = result.ShortenedUrl;
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            var input = textBox.Text;

            btnShorten.Enabled = UrlService.ValidateUrl(input);
            btnOpen.Enabled = !string.IsNullOrWhiteSpace(input);
        }

        private void txtResult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox) sender).Text))
            {
                Clipboard.SetText(((TextBox)sender).Text);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var url = txtUrl.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                return;
            }

            var uploadedUrl = UrlService.FindUrl(url);

            if (uploadedUrl != null)
            {
                Process.Start(uploadedUrl.Url);
            }
            else
            {
                MessageBox.Show("URL could not be found.");
            }
        }
    }
}
