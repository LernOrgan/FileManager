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
    public partial class PasswordForm : Form
    {
        public string Pass;

        public PasswordForm(UserSettings userSettings)
        {

            InitializeComponent();
            Pass = userSettings.Password;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Pass == PasswordTextBox.Text)
            {
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Неправильный пароль");
                PasswordTextBox.Text = "";
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ConfirmButton_Click(default(Object), default(EventArgs));
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            //PasswordTextBox.PasswordChar = Convert.ToChar(new Random().Next(0,1999));
        }
    }
}
