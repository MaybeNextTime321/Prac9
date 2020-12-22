namespace Лабораторная_работа_3_
{
    partial class ConstructForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("", 5);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("", 6);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("", 7);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstructForm));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("", 4);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("", 5);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("", 6);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("", 7);
            this.process1 = new System.Diagnostics.Process();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlView = new System.Windows.Forms.Panel();
            this.FlatList = new System.Windows.Forms.ListView();
            this.imgListFlat = new System.Windows.Forms.ImageList(this.components);
            this.DecorList = new System.Windows.Forms.ListView();
            this.imgListDecor = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.Silver;
            this.pnlBorder.Controls.Add(this.lblTitle);
            this.pnlBorder.Controls.Add(this.imgLogo);
            this.pnlBorder.Controls.Add(this.btnMinimize);
            this.pnlBorder.Controls.Add(this.btnClose);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(600, 30);
            this.pnlBorder.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(30, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Главная форма";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgLogo
            // 
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(30, 30);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Location = new System.Drawing.Point(540, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(570, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.833333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.16667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.166667F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.FlatList, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.DecorList, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.83784F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.67568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.702703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.91892F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 370);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Просмотр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(307, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Плитка:";
            // 
            // pnlView
            // 
            this.pnlView.AllowDrop = true;
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(38, 63);
            this.pnlView.Name = "pnlView";
            this.tableLayoutPanel1.SetRowSpan(this.pnlView, 4);
            this.pnlView.Size = new System.Drawing.Size(235, 233);
            this.pnlView.TabIndex = 3;
            this.pnlView.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel1_DragDrop);
            this.pnlView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel1_DragEnter);
            // 
            // FlatList
            // 
            this.FlatList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlatList.HideSelection = false;
            this.FlatList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.FlatList.LargeImageList = this.imgListFlat;
            this.FlatList.Location = new System.Drawing.Point(307, 63);
            this.FlatList.Name = "FlatList";
            this.FlatList.Size = new System.Drawing.Size(246, 95);
            this.FlatList.TabIndex = 4;
            this.FlatList.UseCompatibleStateImageBehavior = false;
            this.FlatList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseDown);
            // 
            // imgListFlat
            // 
            this.imgListFlat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListFlat.ImageStream")));
            this.imgListFlat.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListFlat.Images.SetKeyName(0, "510x510resize_product15955_74_1355886433.jpg");
            this.imgListFlat.Images.SetKeyName(1, "510x510resize_product16101_95_1355889740.jpg");
            this.imgListFlat.Images.SetKeyName(2, "510x510resize_product16121_57_1355889907.jpg");
            this.imgListFlat.Images.SetKeyName(3, "510x510resize_product16122_47_1355889931.jpg");
            this.imgListFlat.Images.SetKeyName(4, "510x510resize_product16153_50_1355890644.jpg");
            this.imgListFlat.Images.SetKeyName(5, "510x510resize_product16164_31_1355890748.jpg");
            this.imgListFlat.Images.SetKeyName(6, "510x510resize_product16188_79_1355891226.jpg");
            this.imgListFlat.Images.SetKeyName(7, "510x510resize_product16241_8_1355891889.jpg");
            // 
            // DecorList
            // 
            this.DecorList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecorList.HideSelection = false;
            this.DecorList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.DecorList.LargeImageList = this.imgListDecor;
            this.DecorList.Location = new System.Drawing.Point(307, 200);
            this.DecorList.Name = "DecorList";
            this.DecorList.Size = new System.Drawing.Size(246, 87);
            this.DecorList.TabIndex = 5;
            this.DecorList.UseCompatibleStateImageBehavior = false;
            this.DecorList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListView2_MouseDown);
            // 
            // imgListDecor
            // 
            this.imgListDecor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListDecor.ImageStream")));
            this.imgListDecor.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListDecor.Images.SetKeyName(0, "510x510resize_product18677_26_1356318184.jpg");
            this.imgListDecor.Images.SetKeyName(1, "510x510resize_product19064_6_1356342222.jpg");
            this.imgListDecor.Images.SetKeyName(2, "510x510resize_product19360_41_1356410884.jpg");
            this.imgListDecor.Images.SetKeyName(3, "510x510resize_product19400_39_1356412875.jpg");
            this.imgListDecor.Images.SetKeyName(4, "510x510resize_product19905_39_1356491005.jpg");
            this.imgListDecor.Images.SetKeyName(5, "510x510resize_product20687_32_1356682995.jpg");
            this.imgListDecor.Images.SetKeyName(6, "510x510resize_product94442_43_1369728249.jpg");
            this.imgListDecor.Images.SetKeyName(7, "510x510resize_product94443_57_1369728296.jpg");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(307, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Декор:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ConstructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlBorder);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "ConstructForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConstructForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConstructForm_MouseDown);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.ListView FlatList;
        private System.Windows.Forms.ImageList imgListFlat;
        private System.Windows.Forms.ListView DecorList;
        private System.Windows.Forms.ImageList imgListDecor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}