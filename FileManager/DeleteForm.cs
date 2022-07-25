using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void OnClickDeleteButton1(object sender, EventArgs e)
        {
            string path = pathBox.Text + "\\" + nameBox.Text;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void OnClickDeleteButton2(object sender, EventArgs e)
        {
            string path = pathBox.Text + "\\" + nameBox.Text;

            if (Directory.Exists(path))
            {
                DeleteFolder(path);

                MessageBox.Show("Готово");
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
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
