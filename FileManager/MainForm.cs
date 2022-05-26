using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileManager
{
    public partial class MainForm : Form
    {
        ListViewColumnSorter lvwColumnSorter;
        UserSettings userSettings = new UserSettings();
        BinaryFormatter formatter = new BinaryFormatter();
        public MainForm()
        {
            InitializeComponent();
            try
            {
                using (FileStream fs = new FileStream("UserSettings.bin", FileMode.Open))
                {
                    userSettings = formatter.Deserialize(fs) as UserSettings;
                    Decor(userSettings);
                }
                lvwColumnSorter = new ListViewColumnSorter();
            }
            catch (Exception ex) { }
            //PasswordForm PassForm = new PasswordForm(userSettings);
            
            //if (PassForm.ShowDialog() != DialogResult.OK) { Shown += Form1_Shown_Close; }
            

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

        #region Книжная часть
        string urlAddress = "https://www.amazon.com/s?k=python&i=stripbooks-intl-ship&page=1";
        PageInfo pageInfo;

        private void UpdateInfo(object? sender, FormClosingEventArgs? e)
        {
            
        }
        private void UpdateInfo(BookInfo[] bookList)
        {
            foreach (var book in bookList)
            {
                ListViewItem item = new(book.nameOfBook);
                if (book.authorOfBook == "")
                {
                    listViewBooks.Items.Clear();
                    SerchButton_Click();
                    return;
                }
                item.Tag = book.linkOfBook;
                item.SubItems.Add(book.authorOfBook);
                item.SubItems.Add(book.priceOfBook);
                item.SubItems.Add(book.dateOfBook);
                item.SubItems.Add(book.ratingOfBook);
                listViewBooks.Items.Add(item);
                
            }
        }

        private void SerchButton_Click(object sender, EventArgs e)
        {
            urlAddress = urlAddress.Replace("python", LunguageName.Text.ToLower());
            pageInfo = new(urlAddress, Convert.ToInt32(CountOfBooks.Text));
            UpdateInfo(pageInfo.bookList);
        }
        private void SerchButton_Click()
        {
            urlAddress = urlAddress.Replace("python", LunguageName.Text.ToLower());
            pageInfo = new(urlAddress, Convert.ToInt32(CountOfBooks.Text));
            UpdateInfo(pageInfo.bookList);
        }




        #endregion

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewBooks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var LVI = listViewBooks.SelectedItems;
            Process.Start(new ProcessStartInfo(LVI[0].Tag.ToString()) { UseShellExecute = true });
        }
       
        private void listViewBooks_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listViewBooks.ListViewItemSorter = lvwColumnSorter;
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            listViewBooks.Sort();
        }
    }
    }
