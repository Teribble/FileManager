using System;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    public partial class CopyForm : Form
    {
        public CopyForm()
        {
            InitializeComponent();
        }

        private void OnClickCopyButton1(object sender, EventArgs e)
        {
            if (File.Exists(pathBox.Text))
            {
                new FileInfo(pathBox.Text).CopyTo(newPathBox.Text);
                MessageBox.Show("Good");
            }
        }

        private void CopyFolder(string FromDir, string ToDir)
        {
            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                string s2 = ToDir + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2);
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyFolder(s, ToDir + "\\" + Path.GetFileName(s));
            }
        }

        private void OnClickCopyButton2(object sender, EventArgs e)
        {
            CopyFolder(pathBox.Text, newPathBox.Text);
        }
    }
}
