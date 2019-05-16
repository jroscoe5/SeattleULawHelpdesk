using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountLookup
{
    public partial class AccountLookupForm : Form
    {
        public AccountLookupForm(double version)
        {
            InitializeComponent();
            Text = "Account Lookup v." + string.Format("{0:0.00}", version);
        }

        private void FieldSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ButtonSearch.Enabled = false;
                e.SuppressKeyPress = true;
                e.Handled = true;
                LookupUsernameAndBind();
                ButtonSearch.Enabled = true;
            }
        }

        private void ButtonSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSearch.Enabled = false;
                e.SuppressKeyPress = true;
                e.Handled = true;
                LookupUsernameAndBind();
                ButtonSearch.Enabled = true;
            }
        }

        private void LookupUsernameAndBind()
        {
            var username = FieldSearchBox.Text;

            if (string.IsNullOrEmpty(username)) return;

            FieldSearchBox.Text = "";

            SilentCMD.NetUserDomainLookup(username);
        }
    }
}
