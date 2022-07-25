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
            if (Directory.Exists(pathBox.Text))
            {
                Directory.CreateDirectory(pathBox.Text + "\\" + nameBox.Text);
            }
        }

        private void OnClickCreateFile(object sender, EventArgs e)
        {
            if (Directory.Exists(pathBox.Text) && !File.Exists(pathBox.Text + "\\" + nameBox.Text))
            {
                File.Create(pathBox.Text + "\\" + nameBox.Text);
            }
            else
            {
                MessageBox.Show("Не верно указан путь либо такой файл уже существует");
            }
        }
    }
}
