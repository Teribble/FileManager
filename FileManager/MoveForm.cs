using System;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    public partial class MoveForm : Form
    {
        public MoveForm()
        {
            InitializeComponent();
        }

        private void OnClickMoveButton1(object sender, EventArgs e)
        {
            CopyFolder(pathBox.Text, newPathBox.Text);
            DeleteFolder(pathBox.Text);
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

        private void DeleteFolder(string path)
        {
            try
            {
                var dirInfo = new DirectoryInfo(path);

                var dirDirectories = dirInfo.GetDirectories();

                var fileInfo = dirInfo.GetFiles();

                foreach (FileInfo f in fileInfo)
                {
                    f.Delete();
                }

                foreach (DirectoryInfo df in dirDirectories)
                {
                    DeleteFolder(df.FullName);
                }

                if (dirInfo.GetDirectories().Length == 0 && dirInfo.GetFiles().Length == 0) dirInfo.Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
