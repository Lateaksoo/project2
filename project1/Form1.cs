using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;

namespace project1
{
        public partial class Form1 : Form
        {
        NaverSearch naverSearch = new NaverSearch();
        Manager manager = new Manager();
        ManagerModel managerModel = new ManagerModel();
        private string category;
        private string startDate;
        private string endDate;
        private string age;
        private string gender;
        private string timeUnit;
        private string keywordName;
        private string productName;

        public Form1()
        {
            InitializeComponent();
            category = managerModel.Category;
            startDate = managerModel.StartDate;
            endDate = managerModel.EndDate;
            age = managerModel.Age;
            gender = managerModel.Gender;
            timeUnit = managerModel.TimeUnit;
            keywordName= managerModel.KeywordName;
            productName = managerModel.ProductName;

        }
        //private void CreateChart(Chart chart, string chartTitle, List<double> ratios)
        //{
        //    Series series = chart.Series.Add(chartTitle);
        //    series.ChartType = SeriesChartType.Column;
        //    for (int i = 0; i < ratios.Count; i++)
        //    {
        //        series.Points.AddXY(i + 1, ratios[i]);
        //    }
        //}
        private void CreateChart(Chart chart, string chartTitle, dynamic result)
        {
            List<double> ratios = new List<double>();
            foreach (var data in result.results[0].data)
            {
                ratios.Add((double)data.ratio);
            }

            Series series = chart.Series.Add(chartTitle);
            series.ChartType = SeriesChartType.Column;
            for (int i = 0; i < ratios.Count; i++)
            {
                series.Points.AddXY(i + 1, ratios[i]);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isAnyChecked = false; // üũ�ڽ��� �� �� �̻� üũ�Ǿ����� Ȯ���ϴ� ����
            CheckBox[] checkBoxes = { check10, check20, check30, check40, check50, check60 };
            age = "";
            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked) //üũ�� ������ ���ڿ��� ����� 
                {
                    age += $"{checkBox.Text.Replace("��", "")}\",\"";
                    isAnyChecked = true;
                }
            }
            if (age.EndsWith("\",\"")) //���������� \",\"�� ������� �Ѵ�.
            {
                age = age.Remove(age.Length - 3);
            }
            if (!isAnyChecked) // üũ�ڽ��� �� �� �̻� üũ���� �ʾ��� ���
            {
                MessageBox.Show("���ɴ븦 �������ּ���.");
                return; // �޼ҵ� ���� ����
            }

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(category, startDate, endDate, gender, age, timeUnit, keywordName, productName));
            chart1.Series.Clear();
            CreateChart(chart1, $"{comboBoxSearch.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����", result);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e) 
        {
            startDate = "";  //�������� �ʱ�ȭ����
            startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = "";  //�������� �ʱ�ȭ����
            endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = ""; //���� ����
            switch (comboBoxSex.Text)
            {
                case "��": gender = "m"; break;
                case "��": gender = "f"; break;
            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = "";  //��ǰ ����
            switch (comboBoxSearch.Text)
            {
                case "����ũž": category = "50000089"; keywordName = "����ũž"; break;
                case "��Ʈ��": category = "50000151"; keywordName = "��Ʈ��"; break;
                case "�����": category = "50000153"; keywordName = "�����"; break;
                case "Ű����/���콺": category = "50002927"; keywordName = "Ű����/���콺"; break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //�⺻���� ���õǾ� �ִ� ��
            timeUnit = "month";
            comboBoxSearch.SelectedIndex = 0;
            comboBoxSex.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddMonths(-6);
            dtpEndDate.Value = DateTime.Now;
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            timeUnit = "month"; //������ ����

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(category, startDate, endDate, gender, age, timeUnit, keywordName, productName));
            chart1.Series.Clear();
            CreateChart(chart1, $"{comboBoxSearch.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����", result);

        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            timeUnit = "week"; //�ֺ��� ����

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(category, startDate, endDate, gender, age, timeUnit, keywordName, productName));
            chart1.Series.Clear();
            CreateChart(chart1, $"{comboBoxSearch.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����", result);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            productName = txtSearch.Text;
        }

        private void btnAddCategory_Click(object sender, EventArgs e) //ī�װ� �߰�
        {
            manager.InsertCategory(txtCategory.Text, txtKeywordName.Text);
        }
    }
}