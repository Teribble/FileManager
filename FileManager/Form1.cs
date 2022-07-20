using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private Stack<string> _stackLeft = new Stack<string>();
        private Stack<string> _stackRight = new Stack<string>();

        private List<string> _mirrorLLV = new List<string>();
        private List<string> _mirrorRLV = new List<string>();

        private const string Back = "...";

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

                listView.Items.Add(new ListViewItem(Back));

                selectDirectory.GetDirectories().ToList().ForEach(folder =>
                {
                    listView.Items.Add(new ListViewItem(folder.Name, 1));

                    mirrorLW.Add(folder.FullName);
                });

                selectDirectory.GetFiles().ToList().ForEach(file =>
                {
                    listView.Items.Add(new ListViewItem(file.Name, 0));

                    mirrorLW.Add(file.FullName);
                });

            }

        }
        private void OnClickLeftDiskListBox(object sender, EventArgs e)
        {
            if (leftDiskListBox.SelectedItem != null)
            {
                _stackLeft.Clear();

                _mirrorLLV.Clear();

                PrintSelectItemListView(leftListView, leftDiskListBox, label2, _mirrorLLV);

                leftAdressStroke.Text = leftDiskListBox.SelectedItem.ToString();

            }
        }

        private void OnClickRightDiskListBox(object sender, EventArgs e)
        {
            if (rightDiskListBox.SelectedItem != null)
            {
                PrintSelectItemListView(rightListView, rightDiskListBox, label3, _mirrorRLV);

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
                if (leftListView.SelectedItems[0].Text == Back)
                {
                    leftListView.Items.Clear();

                    _mirrorLLV.Clear();

                    if (_stackLeft.Count > 0)
                    {
                        leftListView.Items.Add(new ListViewItem(Back));
                    }

                    if (_stackLeft.Count > 0)
                    {
                        leftAdressStroke.Text = _stackLeft.Peek();

                        new DirectoryInfo(_stackLeft.Peek()).GetDirectories().ToList().ForEach(folder =>
                        {
                            leftListView.Items.Add(new ListViewItem(folder.Name, 1));

                            _mirrorLLV.Add(folder.FullName);
                        });

                        new DirectoryInfo(_stackLeft.Pop()).GetFiles().ToList().ForEach(file =>
                        {
                            leftListView.Items.Add(new ListViewItem(file.Name, 0));

                            _mirrorLLV.Add(file.FullName);
                        });
                    }                
                }
                else if (Directory.Exists(_mirrorLLV[leftListView.SelectedItems[0].Index - 1]))
                {
                    try
                    {
                        leftAdressStroke.Text = new DirectoryInfo(_mirrorLLV[leftListView.SelectedItems[0].Index - 1]).FullName;

                        _stackLeft.Push(new DirectoryInfo(_mirrorLLV[leftListView.SelectedItems[0].Index - 1]).Parent.FullName);

                        leftListView.Items.Clear();

                        _mirrorLLV.Clear();

                        leftListView.Items.Add(new ListViewItem(Back));

                        new DirectoryInfo(leftAdressStroke.Text).GetDirectories().ToList().ForEach(item =>
                        {
                            leftListView.Items.Add(new ListViewItem(item.Name, 1));

                            _mirrorLLV.Add(item.FullName);
                        });

                        new DirectoryInfo(leftAdressStroke.Text).GetFiles().ToList().ForEach(item =>
                        {
                            leftListView.Items.Add(new ListViewItem(item.Name, 0));

                            _mirrorLLV.Add(item.FullName);
                        });
                    }
                    catch (UnauthorizedAccessException)
                    {

                        MessageBox.Show("От админа прогу запусти");
                    }
                }
            }
        }

        private void OnKeyDownLeftAdressStroke(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (Directory.Exists(leftAdressStroke.Text))
                {
                    var selectInfo = new DirectoryInfo(leftAdressStroke.Text);

                    _stackLeft.Push(selectInfo.Parent.FullName);

                    leftListView.Items.Clear();

                    _mirrorLLV.Clear();

                    leftListView.Items.Add(new ListViewItem(Back));

                    selectInfo.GetDirectories().ToList().ForEach(folder =>
                    {
                        leftListView.Items.Add(new ListViewItem(folder.Name, 1));

                        _mirrorLLV.Add(folder.FullName);
                    });

                    selectInfo.GetFiles().ToList().ForEach(file =>
                    {
                        leftListView.Items.Add(new ListViewItem(file.Name, 0));

                        _mirrorLLV.Add(file.FullName);
                    });
                }
            }
        }
    }
}
