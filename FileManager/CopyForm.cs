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
    public partial class CopyForm : Form
    {
        string OldPath;
        public CopyForm(string path)
        {
            InitializeComponent();
            WayOfCopiedFile.Text = path;
            OldPath = path;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string NewPath = WayOfCopiedFile.Text;
            FOperations.Copy(OldPath, NewPath);
            Close();

        }
    }
}
