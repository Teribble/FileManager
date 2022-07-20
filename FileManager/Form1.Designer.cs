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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPicBox = new System.Windows.Forms.PictureBox();
            this.closePicBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rightAdressStroke = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rightDiskListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rightListView = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.leftAdressStroke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leftDiskListBox = new System.Windows.Forms.ListBox();
            this.leftListView = new System.Windows.Forms.ListView();
            this.folders = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(600, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMovePanel1);
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
            // closePicBox
            // 
            this.closePicBox.Location = new System.Drawing.Point(575, 2);
            this.closePicBox.Name = "closePicBox";
            this.closePicBox.Size = new System.Drawing.Size(20, 20);
            this.closePicBox.TabIndex = 1;
            this.closePicBox.TabStop = false;
            this.closePicBox.Click += new System.EventHandler(this.OnClickClosePicBox);
            this.closePicBox.MouseEnter += new System.EventHandler(this.OnMouseEnterClosePicBox);
            this.closePicBox.MouseLeave += new System.EventHandler(this.OnMouseLeaveClosePicBox);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.rightAdressStroke);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rightDiskListBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rightListView);
            this.panel2.Location = new System.Drawing.Point(331, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 427);
            this.panel2.TabIndex = 1;
            // 
            // rightAdressStroke
            // 
            this.rightAdressStroke.Location = new System.Drawing.Point(3, 11);
            this.rightAdressStroke.Name = "rightAdressStroke";
            this.rightAdressStroke.Size = new System.Drawing.Size(258, 20);
            this.rightAdressStroke.TabIndex = 5;
            this.rightAdressStroke.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 345);
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
            this.label4.Location = new System.Drawing.Point(3, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Размер: ";
            // 
            // rightListView
            // 
            this.rightListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.rightListView.Location = new System.Drawing.Point(3, 37);
            this.rightListView.MultiSelect = false;
            this.rightListView.Name = "rightListView";
            this.rightListView.Size = new System.Drawing.Size(258, 230);
            this.rightListView.TabIndex = 1;
            this.rightListView.TabStop = false;
            this.rightListView.UseCompatibleStateImageBehavior = false;
            this.rightListView.View = System.Windows.Forms.View.Details;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.leftAdressStroke);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.leftDiskListBox);
            this.panel3.Controls.Add(this.leftListView);
            this.panel3.Location = new System.Drawing.Point(61, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 427);
            this.panel3.TabIndex = 2;
            // 
            // leftAdressStroke
            // 
            this.leftAdressStroke.Location = new System.Drawing.Point(3, 11);
            this.leftAdressStroke.Name = "leftAdressStroke";
            this.leftAdressStroke.Size = new System.Drawing.Size(258, 20);
            this.leftAdressStroke.TabIndex = 4;
            this.leftAdressStroke.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер: ";
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
            this.leftListView.Location = new System.Drawing.Point(3, 37);
            this.leftListView.MultiSelect = false;
            this.leftListView.Name = "leftListView";
            this.leftListView.Size = new System.Drawing.Size(258, 230);
            this.leftListView.TabIndex = 0;
            this.leftListView.TabStop = false;
            this.leftListView.UseCompatibleStateImageBehavior = false;
            this.leftListView.View = System.Windows.Forms.View.Details;
            this.leftListView.DoubleClick += new System.EventHandler(this.OnDoubleClickLeftListView);
            // 
            // folders
            // 
            this.folders.Text = "Папки и файлы";
            this.folders.Width = 230;
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Папки и файлы";
            this.columnHeader1.Width = 230;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(64, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 121);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePicBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.ListBox listBox1;
    }
}

