namespace Cmart.Cmart_GUI
{
    partial class C02_Statistic
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbFilterByYear = new System.Windows.Forms.GroupBox();
            this.dpToYear_FilterByYear = new System.Windows.Forms.DateTimePicker();
            this.dpFromYear_FilterByYear = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbFilterByMonth = new System.Windows.Forms.GroupBox();
            this.dpToMonth_FilterByMonth = new System.Windows.Forms.DateTimePicker();
            this.dpFromMonth_FilterByMonth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnFilterAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFilterByYear.SuspendLayout();
            this.gbFilterByMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // promotionToolStripMenuItem
            // 
            this.promotionToolStripMenuItem.Name = "promotionToolStripMenuItem";
            this.promotionToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.promotionToolStripMenuItem.Text = "Promotion";
            this.promotionToolStripMenuItem.Click += new System.EventHandler(this.promotionToolStripMenuItem_Click);
            // 
            // priceHistoryToolStripMenuItem
            // 
            this.priceHistoryToolStripMenuItem.Name = "priceHistoryToolStripMenuItem";
            this.priceHistoryToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.priceHistoryToolStripMenuItem.Text = "Price History";
            this.priceHistoryToolStripMenuItem.Click += new System.EventHandler(this.priceHistoryToolStripMenuItem_Click);
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
            // headImportToolStripMenuItem
            // 
            this.headImportToolStripMenuItem.Name = "headImportToolStripMenuItem";
            this.headImportToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.headImportToolStripMenuItem.Text = "Head Import";
            // 
            // branchImportToolStripMenuItem
            // 
            this.branchImportToolStripMenuItem.Name = "branchImportToolStripMenuItem";
            this.branchImportToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.branchImportToolStripMenuItem.Text = "Branch Import";
            // 
            // billToolStripMenuItem
            // 
            this.billToolStripMenuItem.Name = "billToolStripMenuItem";
            this.billToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.billToolStripMenuItem.Text = "Bill";
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.statisticToolStripMenuItem.Text = "Statistic";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(538, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Fullname";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(607, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 151);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 121;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Day";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(85, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 39);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(373, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 78;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(69, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "From:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 74;
            this.label9.Text = "To:";
            // 
            // gbFilterByYear
            // 
            this.gbFilterByYear.Controls.Add(this.dpToYear_FilterByYear);
            this.gbFilterByYear.Controls.Add(this.dpFromYear_FilterByYear);
            this.gbFilterByYear.Controls.Add(this.label5);
            this.gbFilterByYear.Controls.Add(this.label6);
            this.gbFilterByYear.Location = new System.Drawing.Point(85, 55);
            this.gbFilterByYear.Name = "gbFilterByYear";
            this.gbFilterByYear.Size = new System.Drawing.Size(586, 39);
            this.gbFilterByYear.TabIndex = 120;
            this.gbFilterByYear.TabStop = false;
            // 
            // dpToYear_FilterByYear
            // 
            this.dpToYear_FilterByYear.CustomFormat = "yyyy";
            this.dpToYear_FilterByYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpToYear_FilterByYear.Location = new System.Drawing.Point(374, 12);
            this.dpToYear_FilterByYear.Name = "dpToYear_FilterByYear";
            this.dpToYear_FilterByYear.Size = new System.Drawing.Size(200, 20);
            this.dpToYear_FilterByYear.TabIndex = 76;
            // 
            // dpFromYear_FilterByYear
            // 
            this.dpFromYear_FilterByYear.CustomFormat = "yyyy";
            this.dpFromYear_FilterByYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFromYear_FilterByYear.Location = new System.Drawing.Point(69, 13);
            this.dpFromYear_FilterByYear.Name = "dpFromYear_FilterByYear";
            this.dpFromYear_FilterByYear.Size = new System.Drawing.Size(200, 20);
            this.dpFromYear_FilterByYear.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "To:";
            // 
            // gbFilterByMonth
            // 
            this.gbFilterByMonth.Controls.Add(this.dpToMonth_FilterByMonth);
            this.gbFilterByMonth.Controls.Add(this.dpFromMonth_FilterByMonth);
            this.gbFilterByMonth.Controls.Add(this.label1);
            this.gbFilterByMonth.Controls.Add(this.label2);
            this.gbFilterByMonth.Location = new System.Drawing.Point(85, 94);
            this.gbFilterByMonth.Name = "gbFilterByMonth";
            this.gbFilterByMonth.Size = new System.Drawing.Size(586, 39);
            this.gbFilterByMonth.TabIndex = 118;
            this.gbFilterByMonth.TabStop = false;
            // 
            // dpToMonth_FilterByMonth
            // 
            this.dpToMonth_FilterByMonth.CustomFormat = "MM/yyyy";
            this.dpToMonth_FilterByMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpToMonth_FilterByMonth.Location = new System.Drawing.Point(373, 13);
            this.dpToMonth_FilterByMonth.Name = "dpToMonth_FilterByMonth";
            this.dpToMonth_FilterByMonth.Size = new System.Drawing.Size(200, 20);
            this.dpToMonth_FilterByMonth.TabIndex = 76;
            // 
            // dpFromMonth_FilterByMonth
            // 
            this.dpFromMonth_FilterByMonth.CustomFormat = "MM/yyyy";
            this.dpFromMonth_FilterByMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFromMonth_FilterByMonth.Location = new System.Drawing.Point(69, 13);
            this.dpFromMonth_FilterByMonth.Name = "dpFromMonth_FilterByMonth";
            this.dpFromMonth_FilterByMonth.Size = new System.Drawing.Size(200, 20);
            this.dpFromMonth_FilterByMonth.TabIndex = 75;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "To:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(596, 438);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 117;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 212);
            this.dataGridView1.TabIndex = 116;
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Location = new System.Drawing.Point(15, 107);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(55, 17);
            this.rbtnMonth.TabIndex = 115;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            this.rbtnMonth.CheckedChanged += new System.EventHandler(this.rbtnMonth_CheckedChanged);
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Location = new System.Drawing.Point(15, 67);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(47, 17);
            this.rbtnYear.TabIndex = 114;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            this.rbtnYear.CheckedChanged += new System.EventHandler(this.rbtnYear_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(217, 441);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 113;
            this.label15.Text = "VND";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 112;
            this.label7.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(134, 441);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(21, 20);
            this.lblTotalAmount.TabIndex = 111;
            this.lblTotalAmount.Text = "...";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.Location = new System.Drawing.Point(134, 421);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(21, 20);
            this.lblTotalQuantity.TabIndex = 110;
            this.lblTotalQuantity.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 109;
            this.label4.Text = "Total Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 37);
            this.label3.TabIndex = 108;
            this.label3.Text = "CMART STATISTIC";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(503, 178);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 107;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnFilterAll
            // 
            this.btnFilterAll.Location = new System.Drawing.Point(597, 178);
            this.btnFilterAll.Name = "btnFilterAll";
            this.btnFilterAll.Size = new System.Drawing.Size(75, 23);
            this.btnFilterAll.TabIndex = 122;
            this.btnFilterAll.Text = "Filter All";
            this.btnFilterAll.UseVisualStyleBackColor = true;
            this.btnFilterAll.Click += new System.EventHandler(this.btnFilterAll_Click);
            // 
            // C02_Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 464);
            this.Controls.Add(this.btnFilterAll);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFilterByYear);
            this.Controls.Add(this.gbFilterByMonth);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.Name = "C02_Statistic";
            this.Text = "C02_Statistic";
            this.Load += new System.EventHandler(this.C02_Statistic_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFilterByYear.ResumeLayout(false);
            this.gbFilterByYear.PerformLayout();
            this.gbFilterByMonth.ResumeLayout(false);
            this.gbFilterByMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbFilterByYear;
        private System.Windows.Forms.DateTimePicker dpToYear_FilterByYear;
        private System.Windows.Forms.DateTimePicker dpFromYear_FilterByYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbFilterByMonth;
        private System.Windows.Forms.DateTimePicker dpToMonth_FilterByMonth;
        private System.Windows.Forms.DateTimePicker dpFromMonth_FilterByMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnFilterAll;
    }
}