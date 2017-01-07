namespace Cmart.Cmart_GUI
{
    partial class C08_Product
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabList = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbbTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSupplier = new System.Windows.Forms.ComboBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblFullName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(593, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(579, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.btnEdit);
            this.tabList.Controls.Add(this.btnDelete);
            this.tabList.Controls.Add(this.list);
            this.tabList.Controls.Add(this.btnSearch);
            this.tabList.Controls.Add(this.txtSearch);
            this.tabList.Location = new System.Drawing.Point(4, 22);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(676, 408);
            this.tabList.TabIndex = 0;
            this.tabList.Text = "List";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(598, 382);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // list
            // 
            this.list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Location = new System.Drawing.Point(8, 32);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(660, 344);
            this.list.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbbTypes);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbbSupplier);
            this.tabPage2.Controls.Add(this.img);
            this.tabPage2.Controls.Add(this.btnBrowse);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbbTypes
            // 
            this.cbbTypes.FormattingEnabled = true;
            this.cbbTypes.Location = new System.Drawing.Point(270, 300);
            this.cbbTypes.Name = "cbbTypes";
            this.cbbTypes.Size = new System.Drawing.Size(227, 21);
            this.cbbTypes.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Type:";
            // 
            // cbbSupplier
            // 
            this.cbbSupplier.FormattingEnabled = true;
            this.cbbSupplier.Location = new System.Drawing.Point(270, 343);
            this.cbbSupplier.Name = "cbbSupplier";
            this.cbbSupplier.Size = new System.Drawing.Size(227, 21);
            this.cbbSupplier.TabIndex = 56;
            // 
            // img
            // 
            this.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img.Location = new System.Drawing.Point(306, 80);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(115, 115);
            this.img.TabIndex = 55;
            this.img.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(326, 201);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 54;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(595, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Supplier:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(270, 248);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 37);
            this.label2.TabIndex = 41;
            this.label2.Text = "CMART PRODUCT";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabList);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 434);
            this.tabControl1.TabIndex = 7;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(540, 4);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(63, 16);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Fullname";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.statisticToolStripMenuItem.Text = "Statistic";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click);
            // 
            // branchImportToolStripMenuItem
            // 
            this.branchImportToolStripMenuItem.Name = "branchImportToolStripMenuItem";
            this.branchImportToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.branchImportToolStripMenuItem.Text = "Branch Import";
            this.branchImportToolStripMenuItem.Click += new System.EventHandler(this.branchImportToolStripMenuItem_Click);
            // 
            // headImportToolStripMenuItem
            // 
            this.headImportToolStripMenuItem.Name = "headImportToolStripMenuItem";
            this.headImportToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.headImportToolStripMenuItem.Text = "Head Import";
            this.headImportToolStripMenuItem.Click += new System.EventHandler(this.headImportToolStripMenuItem_Click);
            // 
            // importManagementToolStripMenuItem
            // 
            this.importManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headImportToolStripMenuItem,
            this.branchImportToolStripMenuItem});
            this.importManagementToolStripMenuItem.Name = "importManagementToolStripMenuItem";
            this.importManagementToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importManagementToolStripMenuItem.Text = "Import";
            // 
            // priceHistoryToolStripMenuItem
            // 
            this.priceHistoryToolStripMenuItem.Name = "priceHistoryToolStripMenuItem";
            this.priceHistoryToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.priceHistoryToolStripMenuItem.Text = "Price History";
            this.priceHistoryToolStripMenuItem.Click += new System.EventHandler(this.priceHistoryToolStripMenuItem_Click);
            // 
            // promotionToolStripMenuItem
            // 
            this.promotionToolStripMenuItem.Name = "promotionToolStripMenuItem";
            this.promotionToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.promotionToolStripMenuItem.Text = "Promotion";
            this.promotionToolStripMenuItem.Click += new System.EventHandler(this.promotionToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // categoToolStripMenuItem
            // 
            this.categoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.promotionToolStripMenuItem,
            this.priceHistoryToolStripMenuItem});
            this.categoToolStripMenuItem.Name = "categoToolStripMenuItem";
            this.categoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoToolStripMenuItem.Text = "Category";
            // 
            // billToolStripMenuItem
            // 
            this.billToolStripMenuItem.Name = "billToolStripMenuItem";
            this.billToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.billToolStripMenuItem.Text = "Bill";
            this.billToolStripMenuItem.Click += new System.EventHandler(this.billToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoToolStripMenuItem,
            this.importManagementToolStripMenuItem,
            this.billToolStripMenuItem,
            this.statisticToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // C08_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "C08_Product";
            this.Text = "C08_Product";
            this.tabList.ResumeLayout(false);
            this.tabList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSupplier;
        private System.Windows.Forms.ComboBox cbbTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
    }
}