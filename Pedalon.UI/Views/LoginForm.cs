using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pedalon.UI.Utils;

namespace Pedalon.UI.Views
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim(), password = txtPassword.Text.Trim();
            if(Utils.Utilities.areNotNull(username, password))
            {
                Program.User = AccountService.Login(username, password);
                if(Program.User != null)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı ya da parola!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                MessageBox.Show("Geçersiz kullanıcı adı ya da parola!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}