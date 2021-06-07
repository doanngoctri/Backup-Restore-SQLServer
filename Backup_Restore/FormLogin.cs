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

namespace Backup_Restore
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            
            InitializeComponent();
            //this.Activate();
            //this.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsr.Text.Trim() == "" || txtPwd.Text.Trim() == "" || txtServername.Text.Trim()=="")
            {
                MessageBox.Show("Server name, Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.servername = txtServername.Text.Trim();
            Program.username = txtUsr.Text.Trim();
            Program.password = txtPwd.Text.Trim();
            if (Program.KetNoi() == 0)
            {
                return;
            }           
            Program.conn.Close();
            try
            {
                FormMain form = new FormMain();
                form.Activate();
                form.ShowDialog();
                //Program.form.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.Show();
            this.Activate();
            
        }
    }
}