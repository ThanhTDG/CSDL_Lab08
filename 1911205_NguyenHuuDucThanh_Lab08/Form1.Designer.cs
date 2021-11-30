namespace _1911205_NguyenHuuDucThanh_Lab08
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabFuncion = new System.Windows.Forms.TabControl();
            this.tabFood = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtCateName = new System.Windows.Forms.TextBox();
            this.cbbCateType = new System.Windows.Forms.ComboBox();
            this.lsvCate = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmtCate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateCate = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnResetCate = new System.Windows.Forms.Button();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.lvsFood = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msFood = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabFuncion.SuspendLayout();
            this.tabFood.SuspendLayout();
            this.tabCategory.SuspendLayout();
            this.cmtCate.SuspendLayout();
            this.grBox.SuspendLayout();
            this.msFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabFuncion);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // tabFuncion
            // 
            this.tabFuncion.Controls.Add(this.tabFood);
            this.tabFuncion.Controls.Add(this.tabCategory);
            this.tabFuncion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFuncion.Location = new System.Drawing.Point(3, 16);
            this.tabFuncion.Name = "tabFuncion";
            this.tabFuncion.SelectedIndex = 0;
            this.tabFuncion.Size = new System.Drawing.Size(340, 384);
            this.tabFuncion.TabIndex = 3;
            this.tabFuncion.SelectedIndexChanged += new System.EventHandler(this.tabFuncion_SelectedIndexChanged);
            // 
            // tabFood
            // 
            this.tabFood.Controls.Add(this.btnUpdate);
            this.tabFood.Controls.Add(this.btnAdd);
            this.tabFood.Controls.Add(this.btnLoadAll);
            this.tabFood.Controls.Add(this.btnReload);
            this.tabFood.Controls.Add(this.cbbCategory);
            this.tabFood.Controls.Add(this.txtNote);
            this.tabFood.Controls.Add(this.txtPrice);
            this.tabFood.Controls.Add(this.txtUnit);
            this.tabFood.Controls.Add(this.txtName);
            this.tabFood.Controls.Add(this.label5);
            this.tabFood.Controls.Add(this.label4);
            this.tabFood.Controls.Add(this.label3);
            this.tabFood.Controls.Add(this.label2);
            this.tabFood.Controls.Add(this.label1);
            this.tabFood.Location = new System.Drawing.Point(4, 22);
            this.tabFood.Name = "tabFood";
            this.tabFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabFood.Size = new System.Drawing.Size(332, 358);
            this.tabFood.TabIndex = 0;
            this.tabFood.Text = "Thực phẩm";
            this.tabFood.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(248, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(169, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(7, 331);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(75, 23);
            this.btnLoadAll.TabIndex = 11;
            this.btnLoadAll.Text = "Tất cả";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(87, 331);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Nhập lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cbbCategory
            // 
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(205, 92);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbbCategory.TabIndex = 16;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(66, 120);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(260, 205);
            this.txtNote.TabIndex = 12;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(226, 63);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 13;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(205, 34);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(121, 20);
            this.txtUnit.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 20);
            this.txtName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại thực phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đơn vị tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên thực phẩm";
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.label7);
            this.tabCategory.Controls.Add(this.label);
            this.tabCategory.Controls.Add(this.txtCateName);
            this.tabCategory.Controls.Add(this.cbbCateType);
            this.tabCategory.Controls.Add(this.lsvCate);
            this.tabCategory.Controls.Add(this.btnUpdateCate);
            this.tabCategory.Controls.Add(this.btnAddFood);
            this.tabCategory.Controls.Add(this.button3);
            this.tabCategory.Controls.Add(this.btnResetCate);
            this.tabCategory.Location = new System.Drawing.Point(4, 22);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(332, 358);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Nhóm thức ăn";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Loại thực phẩm";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(88, 252);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(74, 13);
            this.label.TabIndex = 19;
            this.label.Text = "Nhóm thức ăn";
            // 
            // txtCateName
            // 
            this.txtCateName.Location = new System.Drawing.Point(184, 246);
            this.txtCateName.Name = "txtCateName";
            this.txtCateName.Size = new System.Drawing.Size(141, 20);
            this.txtCateName.TabIndex = 18;
            // 
            // cbbCateType
            // 
            this.cbbCateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCateType.FormattingEnabled = true;
            this.cbbCateType.Location = new System.Drawing.Point(184, 281);
            this.cbbCateType.Name = "cbbCateType";
            this.cbbCateType.Size = new System.Drawing.Size(141, 21);
            this.cbbCateType.TabIndex = 17;
            // 
            // lsvCate
            // 
            this.lsvCate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader9,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvCate.ContextMenuStrip = this.cmtCate;
            this.lsvCate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsvCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCate.FullRowSelect = true;
            this.lsvCate.HideSelection = false;
            this.lsvCate.Location = new System.Drawing.Point(3, 3);
            this.lsvCate.MultiSelect = false;
            this.lsvCate.Name = "lsvCate";
            this.lsvCate.Size = new System.Drawing.Size(326, 224);
            this.lsvCate.TabIndex = 16;
            this.lsvCate.UseCompatibleStateImageBehavior = false;
            this.lsvCate.View = System.Windows.Forms.View.Details;
            this.lsvCate.Click += new System.EventHandler(this.lsvCate_Click);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "STT";
            this.columnHeader9.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nhóm thức ăn";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Loại thức ăn";
            this.columnHeader8.Width = 90;
            // 
            // cmtCate
            // 
            this.cmtCate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete});
            this.cmtCate.Name = "cmtMenu";
            this.cmtCate.Size = new System.Drawing.Size(181, 48);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(127, 22);
            this.tsmDelete.Text = "Xóa";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // btnUpdateCate
            // 
            this.btnUpdateCate.Location = new System.Drawing.Point(250, 324);
            this.btnUpdateCate.Name = "btnUpdateCate";
            this.btnUpdateCate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCate.TabIndex = 13;
            this.btnUpdateCate.Text = "Sửa";
            this.btnUpdateCate.UseVisualStyleBackColor = true;
            this.btnUpdateCate.Click += new System.EventHandler(this.btnUpdateCate_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(10, 324);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 14;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnResetCate
            // 
            this.btnResetCate.Location = new System.Drawing.Point(90, 324);
            this.btnResetCate.Name = "btnResetCate";
            this.btnResetCate.Size = new System.Drawing.Size(75, 23);
            this.btnResetCate.TabIndex = 15;
            this.btnResetCate.Text = "Nhập lại";
            this.btnResetCate.UseVisualStyleBackColor = true;
            this.btnResetCate.Click += new System.EventHandler(this.btnResetCate_Click);
            // 
            // grBox
            // 
            this.grBox.Controls.Add(this.lvsFood);
            this.grBox.Location = new System.Drawing.Point(365, 13);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(534, 432);
            this.grBox.TabIndex = 0;
            this.grBox.TabStop = false;
            this.grBox.Text = "danh mục thức ăn";
            // 
            // lvsFood
            // 
            this.lvsFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvsFood.ContextMenuStrip = this.msFood;
            this.lvsFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvsFood.FullRowSelect = true;
            this.lvsFood.HideSelection = false;
            this.lvsFood.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lvsFood.Location = new System.Drawing.Point(3, 16);
            this.lvsFood.Name = "lvsFood";
            this.lvsFood.Size = new System.Drawing.Size(528, 413);
            this.lvsFood.TabIndex = 0;
            this.lvsFood.UseCompatibleStateImageBehavior = false;
            this.lvsFood.View = System.Windows.Forms.View.Details;
            this.lvsFood.Click += new System.EventHandler(this.lvsFood_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên thực phẩm";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ĐVT";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Loại thực phẩm";
            this.columnHeader5.Width = 87;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi chú";
            this.columnHeader6.Width = 142;
            // 
            // msFood
            // 
            this.msFood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.msFood.Name = "cmtMenu";
            this.msFood.Size = new System.Drawing.Size(95, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem1.Text = "Xóa";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(271, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ứng dụng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabFuncion.ResumeLayout(false);
            this.tabFood.ResumeLayout(false);
            this.tabFood.PerformLayout();
            this.tabCategory.ResumeLayout(false);
            this.tabCategory.PerformLayout();
            this.cmtCate.ResumeLayout(false);
            this.grBox.ResumeLayout(false);
            this.msFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.ListView lvsFood;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabControl tabFuncion;
        private System.Windows.Forms.TabPage tabFood;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.Button btnUpdateCate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnResetCate;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.ListView lsvCate;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ContextMenuStrip cmtCate;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtCateName;
        private System.Windows.Forms.ComboBox cbbCateType;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ContextMenuStrip msFood;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

