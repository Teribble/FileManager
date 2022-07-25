namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closePicBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconPicBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rightAdressStroke = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rightDiskListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rightListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.leftAdressStroke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leftDiskListBox = new System.Windows.Forms.ListBox();
            this.leftListView = new System.Windows.Forms.ListView();
            this.folders = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.closePicBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.iconPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMovePanel1);
            // 
            // closePicBox
            // 
            this.closePicBox.Location = new System.Drawing.Point(856, 2);
            this.closePicBox.Name = "closePicBox";
            this.closePicBox.Size = new System.Drawing.Size(20, 20);
            this.closePicBox.TabIndex = 1;
            this.closePicBox.TabStop = false;
            this.closePicBox.Click += new System.EventHandler(this.OnClickClosePicBox);
            this.closePicBox.MouseEnter += new System.EventHandler(this.OnMouseEnterClosePicBox);
            this.closePicBox.MouseLeave += new System.EventHandler(this.OnMouseLeaveClosePicBox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "FileManager";
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMoveLabel5);
            // 
            // iconPicBox
            // 
            this.iconPicBox.Location = new System.Drawing.Point(5, 2);
            this.iconPicBox.Name = "iconPicBox";
            this.iconPicBox.Size = new System.Drawing.Size(20, 20);
            this.iconPicBox.TabIndex = 3;
            this.iconPicBox.TabStop = false;
            this.iconPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMoveIconPicBox);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.rightAdressStroke);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rightDiskListBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rightListView);
            this.panel2.Location = new System.Drawing.Point(503, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(368, 427);
            this.panel2.TabIndex = 1;
            // 
            // rightAdressStroke
            // 
            this.rightAdressStroke.Location = new System.Drawing.Point(3, 11);
            this.rightAdressStroke.Name = "rightAdressStroke";
            this.rightAdressStroke.Size = new System.Drawing.Size(340, 20);
            this.rightAdressStroke.TabIndex = 5;
            this.rightAdressStroke.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // rightDiskListBox
            // 
            this.rightDiskListBox.FormattingEnabled = true;
            this.rightDiskListBox.Location = new System.Drawing.Point(3, 273);
            this.rightDiskListBox.Name = "rightDiskListBox";
            this.rightDiskListBox.Size = new System.Drawing.Size(120, 69);
            this.rightDiskListBox.TabIndex = 2;
            this.rightDiskListBox.TabStop = false;
            this.rightDiskListBox.Click += new System.EventHandler(this.OnClickRightDiskListBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Размер диска: ";
            // 
            // rightListView
            // 
            this.rightListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.rightListView.HideSelection = false;
            this.rightListView.Location = new System.Drawing.Point(3, 37);
            this.rightListView.MultiSelect = false;
            this.rightListView.Name = "rightListView";
            this.rightListView.Size = new System.Drawing.Size(340, 230);
            this.rightListView.TabIndex = 1;
            this.rightListView.TabStop = false;
            this.rightListView.UseCompatibleStateImageBehavior = false;
            this.rightListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Папки и файлы";
            this.columnHeader1.Width = 315;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.leftAdressStroke);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.leftDiskListBox);
            this.panel3.Controls.Add(this.leftListView);
            this.panel3.Location = new System.Drawing.Point(118, 39);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(368, 427);
            this.panel3.TabIndex = 2;
            // 
            // leftAdressStroke
            // 
            this.leftAdressStroke.Location = new System.Drawing.Point(3, 11);
            this.leftAdressStroke.Name = "leftAdressStroke";
            this.leftAdressStroke.Size = new System.Drawing.Size(340, 20);
            this.leftAdressStroke.TabIndex = 4;
            this.leftAdressStroke.TabStop = false;
            this.leftAdressStroke.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownLeftAdressStroke);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер диска: ";
            // 
            // leftDiskListBox
            // 
            this.leftDiskListBox.FormattingEnabled = true;
            this.leftDiskListBox.Location = new System.Drawing.Point(3, 273);
            this.leftDiskListBox.Name = "leftDiskListBox";
            this.leftDiskListBox.Size = new System.Drawing.Size(120, 69);
            this.leftDiskListBox.TabIndex = 1;
            this.leftDiskListBox.TabStop = false;
            this.leftDiskListBox.Click += new System.EventHandler(this.OnClickLeftDiskListBox);
            // 
            // leftListView
            // 
            this.leftListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.folders});
            this.leftListView.HideSelection = false;
            this.leftListView.Location = new System.Drawing.Point(3, 37);
            this.leftListView.MultiSelect = false;
            this.leftListView.Name = "leftListView";
            this.leftListView.Size = new System.Drawing.Size(340, 230);
            this.leftListView.TabIndex = 0;
            this.leftListView.TabStop = false;
            this.leftListView.UseCompatibleStateImageBehavior = false;
            this.leftListView.View = System.Windows.Forms.View.Details;
            this.leftListView.DoubleClick += new System.EventHandler(this.OnDoubleClickLeftListView);
            // 
            // folders
            // 
            this.folders.Text = "Папки и файлы";
            this.folders.Width = 315;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnClickPicBox1);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.OnMouseEnterPicBox1);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.OnMouseLeavePicBox1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(12, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(92, 329);
            this.panel4.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 267);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 186);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(888, 485);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closePicBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView rightListView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView leftListView;
        private System.Windows.Forms.ListBox rightDiskListBox;
        private System.Windows.Forms.ListBox leftDiskListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader folders;
        private System.Windows.Forms.TextBox rightAdressStroke;
        private System.Windows.Forms.TextBox leftAdressStroke;
        private System.Windows.Forms.PictureBox iconPicBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

