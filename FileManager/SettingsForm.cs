using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class SettingsForm : Form
    {
        UserSettings userSettings =  new UserSettings();
        public string newPassword;
        public SettingsForm()
        {
            
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream("UserSettings.bin", FileMode.Open))
                {
                    userSettings = formatter.Deserialize(fs) as UserSettings;
                    
                    Decor(userSettings);
                }
            }
            catch (Exception ex) { }
            newPassword = userSettings.Password;
            InitializeComponent();
        }
        private void Decor(UserSettings userSettings)
        {
            Font = userSettings.UserFont;
            BackColor = userSettings.UserColor;
            
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK) 
            { 
                Font = fd.Font;
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK) BackColor = cd.Color;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm(userSettings.Password);
            if(changePassword.ShowDialog() == DialogResult.OK)
            {
                newPassword = changePassword.newPassword;
            }
        }
    }
}
