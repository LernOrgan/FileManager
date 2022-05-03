using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class ChangePasswordForm : Form
    {
        string oldPassword;
        public string newPassword;
        public ChangePasswordForm(string OldPassword)
        {
            InitializeComponent();
            oldPassword = OldPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(oldPassword == OldPassworTextBox.Text)
            {
                newPassword = NewPasswordTextBox.Text;
                Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неправильный пароль");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            newPassword = oldPassword;
            Close();
            DialogResult=DialogResult.Cancel;
        }
    }
}
