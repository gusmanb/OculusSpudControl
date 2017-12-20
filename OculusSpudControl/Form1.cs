using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OculusSpudControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {

                using (var rootKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                {
                    using (var sKey = rootKey.OpenSubKey("SOFTWARE"))
                    {
                        if (sKey == null)
                        {
                            MessageBox.Show("Cannot access Windows registry");
                            Application.Exit();
                            return;
                        }

                        using (var oKey = sKey.OpenSubKey("Oculus"))
                        {

                            if (oKey == null)
                            {
                                dBtn.Enabled = true;
                                sLbl.Text = "Enabled";
                                return;
                            }

                            var value = (int)oKey.GetValue("UseSpud", 1);

                            if (value == 0)
                            {
                                eBtn.Enabled = true;
                                sLbl.Text = "Disabled";
                                return;
                            }

                            dBtn.Enabled = true;
                            sLbl.Text = "Enabled";
                            return;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cannot access Windows registry");
                Application.Exit();
                return;
            }
        }

        private void eBtn_Click(object sender, EventArgs e)
        {
            try
            {

                using (var rootKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                {
                    using (var sKey = rootKey.OpenSubKey("SOFTWARE", true))
                    {
                        if (sKey == null)
                        {
                            MessageBox.Show("Cannot access Windows registry");
                            return;
                        }

                        sKey.DeleteSubKeyTree("Oculus");

                        MessageBox.Show("Spud enabled, remember to restart the system to apply the configuration");
                        eBtn.Enabled = false;
                        dBtn.Enabled = true;
                        sLbl.Text = "Enabled";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cannot access Windows registry");
            }
        }

        private void dBtn_Click(object sender, EventArgs e)
        {
            using (var rootKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (var sKey = rootKey.OpenSubKey("SOFTWARE", true))
                {
                    if (sKey == null)
                    {
                        MessageBox.Show("Cannot access Windows registry");
                        Application.Exit();
                        return;
                    }

                    using (var oKey = sKey.CreateSubKey("Oculus", true))
                    {
                        oKey.SetValue("UseSpud", 0, RegistryValueKind.DWord);
                        MessageBox.Show("Spud disabled, remember to restart the system to apply the configuration");
                        eBtn.Enabled = true;
                        dBtn.Enabled = false;
                        sLbl.Text = "Disabled";
                    }
                }
            }
        }
    }
}
