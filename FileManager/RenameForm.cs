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
    public partial class RenameForm : Form
    {
        string RenamedFile;
        public RenameForm(string File)
        {
            
            InitializeComponent();
            RenamedFile = File;
            string OldName = FOperations.NameOfFile(File);
            NameTextBox.Text = OldName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NewName = NameTextBox.Text;
            FOperations.RenameFile(RenamedFile, NewName);
            Close();

        }
    }
}
