namespace project1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProductManagement = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.check10 = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
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
            // tabProductManagement
            // 
            this.tabProductManagement.Location = new System.Drawing.Point(4, 24);
            this.tabProductManagement.Name = "tabProductManagement";
            this.tabProductManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductManagement.Size = new System.Drawing.Size(749, 545);
            this.tabProductManagement.TabIndex = 0;
            this.tabProductManagement.Text = "상품관리";
            this.tabProductManagement.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "상품추가";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabPage3.Controls.Add(this.comboBoxSearch);
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
            this.btnWeek.Location = new System.Drawing.Point(173, 494);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(142, 43);
            this.btnWeek.TabIndex = 20;
            this.btnWeek.Text = "주간";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(25, 494);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(142, 43);
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
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "데스크탑",
            "노트북",
            "모니터",
            "키보드/마우스"});
            this.comboBoxSearch.Location = new System.Drawing.Point(104, 25);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSearch.TabIndex = 4;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(60, 434);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 43);
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(231, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(515, 539);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(749, 545);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "계정관리";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 573);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabProductManagement;
        private TabPage tabPage2;
        private TabPage tabPage3;
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
        private ComboBox comboBoxSearch;
        private CheckBox check10;
        private Button btnSearch;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btnWeek;
        private Button btnMonth;
        private Label label6;
        private TextBox txtSearch;
        private TabPage tabPage4;
    }
}