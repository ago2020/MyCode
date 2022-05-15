﻿using OnTopReplica.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsAero.Dwm;

namespace OnTopReplica.SidePanels {
    partial class AboutPanel : SidePanel {

        public AboutPanel() {
            InitializeComponent();

            //Display version number
            labelVersion.Text = string.Format(Application.ProductVersion);
        }

        public override Padding GlassMargins {
            get {
                return new Padding(0, 0, 0, labelVersion.Height);
            }
        }

    }
}
