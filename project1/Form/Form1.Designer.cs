﻿namespace project1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.check60 = new System.Windows.Forms.CheckBox();
            this.check50 = new System.Windows.Forms.CheckBox();
            this.check40 = new System.Windows.Forms.CheckBox();
            this.check30 = new System.Windows.Forms.CheckBox();
            this.check20 = new System.Windows.Forms.CheckBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.check10 = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_Category = new System.Windows.Forms.DataGridView();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDeleteKeyName = new System.Windows.Forms.TextBox();
            this.txtKeywordName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabProductManagement = new System.Windows.Forms.TabPage();
            this.pbtn_searchProduct = new System.Windows.Forms.PictureBox();
            this.txt_searchProduct = new System.Windows.Forms.TextBox();
            this.combo_Search = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).BeginInit();
            this.tabProductManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtn_searchProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_load);
            this.tabPage4.Controls.Add(this.btn_delete);
            this.tabPage4.Controls.Add(this.btn_update);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(749, 545);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "계정관리";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(663, 21);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "새로고침";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(582, 21);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(501, 21);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "수정";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(733, 152);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtSearch);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnWeek);
            this.tabPage3.Controls.Add(this.btnMonth);
            this.tabPage3.Controls.Add(this.comboBoxSex);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dtpEndDate);
            this.tabPage3.Controls.Add(this.check60);
            this.tabPage3.Controls.Add(this.check50);
            this.tabPage3.Controls.Add(this.check40);
            this.tabPage3.Controls.Add(this.check30);
            this.tabPage3.Controls.Add(this.check20);
            this.tabPage3.Controls.Add(this.dtpStartDate);
            this.tabPage3.Controls.Add(this.comboBoxCategory);
            this.tabPage3.Controls.Add(this.check10);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(749, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "판매 트렌드";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(104, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 23);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "검색 상품";
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(25, 481);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(206, 30);
            this.btnWeek.TabIndex = 20;
            this.btnWeek.Text = "주간";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(25, 445);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(206, 30);
            this.btnMonth.TabIndex = 19;
            this.btnMonth.Text = "월간";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "남",
            "여"});
            this.comboBoxSex.Location = new System.Drawing.Point(104, 261);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSex.TabIndex = 18;
            this.comboBoxSex.SelectedIndexChanged += new System.EventHandler(this.comboBoxSex_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "성별 선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "종료일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "시작일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "연령대 선택";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(106, 371);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(125, 23);
            this.dtpEndDate.TabIndex = 13;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // check60
            // 
            this.check60.AutoSize = true;
            this.check60.Location = new System.Drawing.Point(162, 205);
            this.check60.Name = "check60";
            this.check60.Size = new System.Drawing.Size(52, 19);
            this.check60.TabIndex = 10;
            this.check60.Text = "60대";
            this.check60.UseVisualStyleBackColor = true;
            // 
            // check50
            // 
            this.check50.AutoSize = true;
            this.check50.Location = new System.Drawing.Point(104, 205);
            this.check50.Name = "check50";
            this.check50.Size = new System.Drawing.Size(52, 19);
            this.check50.TabIndex = 9;
            this.check50.Text = "50대";
            this.check50.UseVisualStyleBackColor = true;
            // 
            // check40
            // 
            this.check40.AutoSize = true;
            this.check40.Location = new System.Drawing.Point(46, 205);
            this.check40.Name = "check40";
            this.check40.Size = new System.Drawing.Size(52, 19);
            this.check40.TabIndex = 8;
            this.check40.Text = "40대";
            this.check40.UseVisualStyleBackColor = true;
            // 
            // check30
            // 
            this.check30.AutoSize = true;
            this.check30.Location = new System.Drawing.Point(162, 155);
            this.check30.Name = "check30";
            this.check30.Size = new System.Drawing.Size(52, 19);
            this.check30.TabIndex = 7;
            this.check30.Text = "30대";
            this.check30.UseVisualStyleBackColor = true;
            // 
            // check20
            // 
            this.check20.AutoSize = true;
            this.check20.Location = new System.Drawing.Point(104, 155);
            this.check20.Name = "check20";
            this.check20.Size = new System.Drawing.Size(52, 19);
            this.check20.TabIndex = 6;
            this.check20.Text = "20대";
            this.check20.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(106, 324);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(125, 23);
            this.dtpStartDate.TabIndex = 5;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(104, 25);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCategory.TabIndex = 4;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // check10
            // 
            this.check10.AutoSize = true;
            this.check10.Location = new System.Drawing.Point(46, 155);
            this.check10.Name = "check10";
            this.check10.Size = new System.Drawing.Size(52, 19);
            this.check10.TabIndex = 3;
            this.check10.Text = "10대";
            this.check10.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(25, 411);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(206, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "카테고리 선택";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(231, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(515, 539);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_Category);
            this.tabPage2.Controls.Add(this.btnDeleteCategory);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtDeleteKeyName);
            this.tabPage2.Controls.Add(this.txtKeywordName);
            this.tabPage2.Controls.Add(this.txtCategory);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnAddCategory);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "카테고리 관리";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Category
            // 
            this.dataGridView_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Category.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_Category.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Category.Name = "dataGridView_Category";
            this.dataGridView_Category.RowTemplate.Height = 25;
            this.dataGridView_Category.Size = new System.Drawing.Size(314, 539);
            this.dataGridView_Category.TabIndex = 13;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(412, 66);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteCategory.TabIndex = 12;
            this.btnDeleteCategory.Text = "카테고리 삭제";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "카테고리이름";
            // 
            // txtDeleteKeyName
            // 
            this.txtDeleteKeyName.Location = new System.Drawing.Point(412, 37);
            this.txtDeleteKeyName.Name = "txtDeleteKeyName";
            this.txtDeleteKeyName.Size = new System.Drawing.Size(100, 23);
            this.txtDeleteKeyName.TabIndex = 10;
            // 
            // txtKeywordName
            // 
            this.txtKeywordName.Location = new System.Drawing.Point(412, 169);
            this.txtKeywordName.Name = "txtKeywordName";
            this.txtKeywordName.Size = new System.Drawing.Size(100, 23);
            this.txtKeywordName.TabIndex = 6;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(412, 138);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 23);
            this.txtCategory.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "카테고리 삭제";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "카테고리 추가";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "카테고리이름";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(412, 198);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(100, 28);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "카테고리 추가";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "카테고리번호";
            // 
            // tabProductManagement
            // 
            this.tabProductManagement.Controls.Add(this.pbtn_searchProduct);
            this.tabProductManagement.Controls.Add(this.txt_searchProduct);
            this.tabProductManagement.Controls.Add(this.combo_Search);
            this.tabProductManagement.Controls.Add(this.label13);
            this.tabProductManagement.Controls.Add(this.label12);
            this.tabProductManagement.Controls.Add(this.ProductGridView);
            this.tabProductManagement.Controls.Add(this.btnDeleteProduct);
            this.tabProductManagement.Controls.Add(this.btnAddProduct);
            this.tabProductManagement.Location = new System.Drawing.Point(4, 24);
            this.tabProductManagement.Name = "tabProductManagement";
            this.tabProductManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductManagement.Size = new System.Drawing.Size(749, 545);
            this.tabProductManagement.TabIndex = 0;
            this.tabProductManagement.Text = "상품관리";
            this.tabProductManagement.UseVisualStyleBackColor = true;
            // 
            // pbtn_searchProduct
            // 
            this.pbtn_searchProduct.Image = ((System.Drawing.Image)(resources.GetObject("pbtn_searchProduct.Image")));
            this.pbtn_searchProduct.Location = new System.Drawing.Point(468, 2);
            this.pbtn_searchProduct.Name = "pbtn_searchProduct";
            this.pbtn_searchProduct.Size = new System.Drawing.Size(32, 30);
            this.pbtn_searchProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtn_searchProduct.TabIndex = 1;
            this.pbtn_searchProduct.TabStop = false;
            this.pbtn_searchProduct.Click += new System.EventHandler(this.pbtn_searchProduct_Click);
            // 
            // txt_searchProduct
            // 
            this.txt_searchProduct.Location = new System.Drawing.Point(226, 4);
            this.txt_searchProduct.Name = "txt_searchProduct";
            this.txt_searchProduct.Size = new System.Drawing.Size(236, 23);
            this.txt_searchProduct.TabIndex = 9;
            this.txt_searchProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_searchProduct_KeyDown);
            // 
            // combo_Search
            // 
            this.combo_Search.FormattingEnabled = true;
            this.combo_Search.Location = new System.Drawing.Point(63, 4);
            this.combo_Search.Name = "combo_Search";
            this.combo_Search.Size = new System.Drawing.Size(121, 23);
            this.combo_Search.TabIndex = 8;
            this.combo_Search.SelectedIndexChanged += new System.EventHandler(this.combo_Search_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(190, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "검색 : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "카테고리";
            // 
            // ProductGridView
            // 
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(3, 35);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowTemplate.Height = 25;
            this.ProductGridView.Size = new System.Drawing.Size(743, 504);
            this.ProductGridView.TabIndex = 5;
            this.ProductGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellDoubleClick);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(666, 4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "상품 삭제";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(585, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "상품 추가";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProductManagement);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 573);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 573);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).EndInit();
            this.tabProductManagement.ResumeLayout(false);
            this.tabProductManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtn_searchProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage4;
        private TabPage tabPage3;
        private TextBox txtSearch;
        private Label label6;
        private Button btnWeek;
        private Button btnMonth;
        private ComboBox comboBoxSex;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpEndDate;
        private CheckBox check60;
        private CheckBox check50;
        private CheckBox check40;
        private CheckBox check30;
        private CheckBox check20;
        private DateTimePicker dtpStartDate;
        private ComboBox comboBoxCategory;
        private CheckBox check10;
        private Button btnSearch;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TabPage tabPage2;
        private Button btnDeleteCategory;
        private Label label11;
        private TextBox txtDeleteKeyName;
        private TextBox txtKeywordName;
        private TextBox txtCategory;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnAddCategory;
        private Label label7;
        private TabPage tabProductManagement;
        private Button btnDeleteProduct;
        private Button btnAddProduct;
        private TabControl tabControl1;
        private Button btn_load;
        private Button btn_delete;
        private Button btn_update;
        private DataGridView dataGridView1;
        private DataGridView ProductGridView;
        private ComboBox combo_Search;
        private Label label13;
        private Label label12;
        private TextBox txt_searchProduct;
        private PictureBox pbtn_searchProduct;
        private DataGridView dataGridView_Category;
    }
}