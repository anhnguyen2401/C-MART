namespace Cmart.Cmart_GUI
{
    partial class C07_Promotion
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
            this.list = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.img = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.tabAdd.SuspendLayout();
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
            this.btnSearch.Location = new System.Drawing.Point(598, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(590, 23);
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
            // list
            // 
            this.list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Location = new System.Drawing.Point(3, 33);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(670, 343);
            this.list.TabIndex = 5;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.img);
            this.tabAdd.Controls.Add(this.btnBrowse);
            this.tabAdd.Controls.Add(this.txtContent);
            this.tabAdd.Controls.Add(this.label6);
            this.tabAdd.Controls.Add(this.dateTimeEnd);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Controls.Add(this.btnCancel);
            this.tabAdd.Controls.Add(this.btnSave);
            this.tabAdd.Controls.Add(this.dateTimeStart);
            this.tabAdd.Controls.Add(this.txtPrice);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.txtID);
            this.tabAdd.Controls.Add(this.label8);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(676, 408);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(501, 103);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(115, 115);
            this.img.TabIndex = 40;
            this.img.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(524, 230);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 39;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(174, 270);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(425, 77);
            this.txtContent.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Content:";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(174, 233);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(227, 20);
            this.dateTimeEnd.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "End Date:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(593, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(174, 198);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(227, 20);
            this.dateTimeStart.TabIndex = 32;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(174, 160);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 20);
            this.txtPrice.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Start Date:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(174, 121);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 20);
            this.txtID.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "ID Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "CMART PROMOTION";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabList);
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 434);
            this.tabControl1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fullname";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 0);
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
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click_1);
            // 
            // branchImportToolStripMenuItem
            // 
            this.branchImportToolStripMenuItem.Name = "branchImportToolStripMenuItem";
            this.branchImportToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.branchImportToolStripMenuItem.Text = "Branch Import";
            this.branchImportToolStripMenuItem.Click += new System.EventHandler(this.branchImportToolStripMenuItem_Click_1);
            // 
            // headImportToolStripMenuItem
            // 
            this.headImportToolStripMenuItem.Name = "headImportToolStripMenuItem";
            this.headImportToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.headImportToolStripMenuItem.Text = "Head Import";
            this.headImportToolStripMenuItem.Click += new System.EventHandler(this.headImportToolStripMenuItem_Click_1);
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
            this.priceHistoryToolStripMenuItem.Click += new System.EventHandler(this.priceHistoryToolStripMenuItem_Click_1);
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
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
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
            this.billToolStripMenuItem.Click += new System.EventHandler(this.billToolStripMenuItem_Click_1);
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(595, 382);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // C07_Promotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "C07_Promotion";
            this.Text = "C07_Promotion";
            this.tabList.ResumeLayout(false);
            this.tabList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
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
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
    }
}