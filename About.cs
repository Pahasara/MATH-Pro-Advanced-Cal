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

namespace DvNET_Math_Pro
{
    public partial class About : Form
    {
        DvNET.MATH.Core.Main Main = new DvNET.MATH.Core.Main();
        public About()
        {
            InitializeComponent();
        }

        private void About_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            CopyrightLabel.Text = "Copyright © " + Main.GetYear() + " M.P.Dewnith Fernando. All rights reserved.";
            VER.Text = Main.GetVersion(); ;
            BUILD.Text = "Build " + Main.GetBuild();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/pahasara");
        }
    }
}
