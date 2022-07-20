using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private Stack<string> _stackLeft = new Stack<string>();
        private Stack<string> _stackRight = new Stack<string>();

        private List<string> _mirrorLLV = new List<string>();
        private List<string> _mirrorRLV = new List<string>();

        public Form1()
        {
            InitializeComponent();

            LoadImage();

            LoadDisks();
        }

        private void LoadImage()
        {
            closePicBox.BackgroundImage = new Bitmap(@"..\..\Resources\Close.png");

            ImageList imageList = new ImageList()
            {
                Images =
                {
                    new Bitmap(@"..\..\Resources\File.png"),
                    new Bitmap(@"..\..\Resources\Folder.png")
                }
            };

            leftListView.SmallImageList = imageList;

            rightListView.SmallImageList = imageList;

            iconPicBox.BackgroundImage = new Bitmap(@"..\..\Resources\Icon.png");
        }

        private void OnMouseEnterClosePicBox(object sender, EventArgs e)
        {
            closePicBox.BackgroundImage = new Bitmap(@"..\..\Resources\Close_1.png");
        }

        private void OnMouseLeaveClosePicBox(object sender, EventArgs e)
        {
            closePicBox.BackgroundImage = new Bitmap(@"..\..\Resources\Close.png");
        }

        private void OnClickClosePicBox(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnMouseMovePanel1(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;

            Message message = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);

            WndProc(ref message);
        }

        private void LoadDisks()
        {
            var info = DriveInfo.GetDrives();

            info.ToList().ForEach(item =>
            {
                leftDiskListBox.Items.Add(item);

                rightDiskListBox.Items.Add(item);
            });
        }

        private void PrintSelectItemListView(ListView listView, ListBox listbox, Label label, List<string> mirrorLW)
        {
            if (listbox.SelectedItem != null)
            {
                listView.Items.Clear();

                if (listbox.SelectedItem is DriveInfo selectDrive)
                {
                    label.Text = new Convert(selectDrive.TotalSize).GetSize();
                }

                var selectDirectory = new DirectoryInfo(listbox.SelectedItem.ToString());

                selectDirectory.GetDirectories().ToList().ForEach(folder =>
                {
                    listView.Items.Add(new ListViewItem(folder.Name, 1));
                    mirrorLW.Add(folder.FullName);
                });

                selectDirectory.GetFiles().ToList().ForEach(folder =>
                {
                    listView.Items.Add(new ListViewItem(folder.Name, 0));
                    mirrorLW.Add(folder.FullName);
                });
            }

        }
        private void OnClickLeftDiskListBox(object sender, EventArgs e)
        {
            if (leftDiskListBox.SelectedItem != null)
            {
                PrintSelectItemListView(leftListView, leftDiskListBox, label2, _mirrorLLV);

                leftAdressStroke.Text = leftDiskListBox.SelectedItem.ToString();

                listBox1.Items.AddRange(_mirrorLLV.ToArray()) ;
            }
        }

        private void OnClickRightDiskListBox(object sender, EventArgs e)
        {
            if (rightDiskListBox.SelectedItem != null)
            {
                PrintSelectItemListView(rightListView, rightDiskListBox,label3,_mirrorRLV);

                rightAdressStroke.Text = rightDiskListBox.SelectedItem.ToString();
            }
        }

        private void OnMouseMoveLabel5(object sender, MouseEventArgs e)
        {
            label5.Capture = false;

            Message message = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);

            WndProc(ref message);
        }

        private void OnMouseMoveIconPicBox(object sender, MouseEventArgs e)
        {
            iconPicBox.Capture = false;

            Message message = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);

            WndProc(ref message);
        }

        private void OnDoubleClickLeftListView(object sender, EventArgs e)
        {
            if (leftListView.SelectedItems != null)
            {
                if (Directory.Exists(_mirrorLLV[leftListView.SelectedItems[0].Index]))
                {
                    leftAdressStroke.Text = new DirectoryInfo(_mirrorLLV[leftListView.SelectedItems[0].Index]).FullName;

                    _stackLeft.Push(new DirectoryInfo(_mirrorLLV[leftListView.SelectedItems[0].Index]).Parent.FullName);

                    leftListView.Items.Clear();
                    _mirrorLLV.Clear();

                    new DirectoryInfo(leftAdressStroke.Text).GetDirectories().ToList().ForEach(item =>
                    {
                        leftListView.Items.Add(new ListViewItem(item.Name, 1));

                        _mirrorLLV.Add(item.FullName);
                    });
                }
            }
        }
    }
}
