using System.Runtime.Serialization.Formatters.Binary;

namespace FileManager
{
    public partial class Form1 : Form
    {
        UserSettings userSettings = new UserSettings();
        BinaryFormatter formatter = new BinaryFormatter();
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (FileStream fs = new FileStream("UserSettings.bin", FileMode.Open))
                {
                    userSettings = formatter.Deserialize(fs) as UserSettings;
                    Decor(userSettings);
                }
            }
            catch (Exception ex) { }
            PasswordForm PassForm = new PasswordForm(userSettings);
            
            if (PassForm.ShowDialog() != DialogResult.OK) { Shown += Form1_Shown_Close; }
            FullInfo(FOperations.Discs);

        }

        #region Сериализационная часть
        private void Form1_Shown_Close(object? sender, EventArgs e)
        {
            Close();
        }
        private void Decor(UserSettings userSettings)
        {
            Font = userSettings.UserFont;
            BackColor = userSettings.UserColor;
            SettingsButton.Font = userSettings.UserFont;
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            if(settingsForm.ShowDialog() == DialogResult.OK)
            {
                userSettings.UserColor = settingsForm.BackColor;
                userSettings.UserFont = settingsForm.Font;
                userSettings.Password = settingsForm.newPassword;
                Decor(userSettings);
                SerializeNow(userSettings);
            }

        }
        private void SerializeNow(UserSettings userSettings)
        {
            using (FileStream fs = new FileStream("UserSettings.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, userSettings);
            }
        }
        #endregion

        #region Файловая часть
        private void FullInfo(string[]? Discs)
        {
            if (Discs == null) return;
          
            ListOfDirectories.Items.Clear();
            ListOfDirectories.Items.AddRange(Discs);
           
        }
        private void ListOfDirectories_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            var lb = (ListBox)sender;
            if (lb.SelectedItem != null)
            {
                FullInfo(FOperations.GoForward((string)lb.SelectedItem));
                
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            FullInfo(FOperations.GoBack());
            ChangeFileWayText(FOperations.NowDirectoryWay);
        }
        private void ListOfDirectories_MouseClick(object sender, MouseEventArgs e)
        {
            var lb = (ListBox)sender;
            if ((string)lb.SelectedItem == "C:\\" || (string)lb.SelectedItem == "D:\\")
            {
                ChangeFileWayText((string)lb.SelectedItem);
            }
            else
            {
                ChangeFileWayText(FOperations.NowDirectoryWay + "\\" + lb.SelectedItem);
            }

        }
        private void ChangeFileWayText(string? text)
        {
            FileWay.Text = text;
        }
        private void RenameButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (FileWay.Text != "C:\\" && FileWay.Text != "D:\\" && FileWay.Text != "")
            { 
                RenameForm RenameForm = new RenameForm(FileWay.Text);
                RenameForm.Show();
                RenameForm.FormClosing += new FormClosingEventHandler(UpdateInfo); 
            }
        }
        private void UpdateInfo(object? sender, FormClosingEventArgs? e)
        {
            FullInfo(FOperations.GoToFile(FOperations.NowDirectoryWay));
            ChangeFileWayText(FOperations.NowDirectoryWay);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                FOperations.DeletePath(FileWay.Text);
                UpdateInfo(default, default(FormClosingEventArgs));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SerchButton_Click(object sender, EventArgs e)
        {
            try
            {
                FullInfo(FOperations.GoToFile(FileWay.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileWay.Text != "C:\\" && FileWay.Text != "D:\\" && FileWay.Text != "")
                {
                    CopyForm CopyForm = new CopyForm(FileWay.Text);
                    CopyForm.Show();
                    CopyForm.FormClosing += new FormClosingEventHandler(UpdateInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            try 
            { 
                FOperations.Compress(FileWay.Text);
                UpdateInfo(default, default(FormClosingEventArgs));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }
}