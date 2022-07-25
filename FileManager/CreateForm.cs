using System;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void OnClickDirectoryCreate(object sender, EventArgs e)
        {
            string path = pathBox.Text + "\\" + nameBox.Text;
            if (Directory.Exists(pathBox.Text) && !Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(pathBox.Text + "\\" + nameBox.Text);

                    if (Directory.Exists(pathBox.Text + "\\" + nameBox.Text))
                        MessageBox.Show("Папка создана");
                }
                catch
                {
                    MessageBox.Show("Объект с таким именем уже существует");
                }
            }
            else
            {
                MessageBox.Show("Не верно указан путь либо папка уже существует");
            }
        }

        private void OnClickCreateFile(object sender, EventArgs e)
        {
            if (Directory.Exists(pathBox.Text) && !File.Exists(pathBox.Text + "\\" + nameBox.Text))
            {
                try
                {
                    FileStream fs = File.Create(pathBox.Text + "\\" + nameBox.Text);
                    fs.Close();
                }
                catch
                {
                    MessageBox.Show("Объект с таким именем уже существует");
                }
            }
            else
            {
                MessageBox.Show("Не верно указан путь либо такой файл уже существует");
            }
        }
    }
}
