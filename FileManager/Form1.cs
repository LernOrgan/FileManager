namespace FileManager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            FullInfo(FOperations.Discs);
        }
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
            FOperations.DeletePath(FileWay.Text);
            UpdateInfo(default, default(FormClosingEventArgs));
        }
        private void SerchButton_Click(object sender, EventArgs e)
        {
            FullInfo(FOperations.GoToFile(FileWay.Text));
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (FileWay.Text != "C:\\" && FileWay.Text != "D:\\" && FileWay.Text != "")
            {
                CopyForm CopyForm = new CopyForm(FileWay.Text);
                CopyForm.Show();
                CopyForm.FormClosing += new FormClosingEventHandler(UpdateInfo);
            }
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            FOperations.Compress(FileWay.Text);
            UpdateInfo(default, default(FormClosingEventArgs));
        }
    }
}