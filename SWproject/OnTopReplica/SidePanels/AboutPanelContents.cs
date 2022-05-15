using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsFormsAero.TaskDialog;
using System.IO;
using WindowsFormsAero;

namespace OnTopReplica.SidePanels {
    public partial class AboutPanelContents : UserControl {

        public AboutPanelContents() {
            InitializeComponent();

            this.FixDefaultFont();
        }

        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
        }

        protected override void OnHandleDestroyed(EventArgs e) {
            base.OnHandleDestroyed(e);
        }

        private void LinkHomepage_clicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Shell.Execute(AppStrings.ApplicationWebsite);
        }

        private void LinkAuthor_clicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Shell.Execute(AppStrings.AuthorWebsite);
        }

        private void LinkCredits_click(object sender, LinkLabelLinkClickedEventArgs e) {
            var exeDir = Path.GetDirectoryName(Application.ExecutablePath);
            var filePath = Path.Combine(exeDir, "CREDITS.txt");

            Shell.Execute(filePath);
        }

        void UpdateButton_click(object sender, System.EventArgs e) {
            progressUpdate.Visible = true;
        }

        void UpdateCheckCompleted(object sender) {
            this.Invoke(new Action(() => {
                progressUpdate.Visible = false;
            }));
        }

        private void LinkLicense_click(object sender, LinkLabelLinkClickedEventArgs e) {
            Shell.Execute(AppStrings.MsRlLicenseLink);
        }

        private void LinkContribute_clicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Shell.Execute(AppStrings.LatestCommitsLink);
        }
    }
}
