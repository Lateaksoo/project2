using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace project1
{
    public partial class Form1 : Form
    {
        NaverSearch naverSearch = new NaverSearch();
        
        public string cateagory;
        public string startDate;
        public string endDate;
        public string age;
        public string gender;
        public string timeUnit;
        public string keywordName;
        public string productName;
        
        public Form1()
        {
            InitializeComponent();
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

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(cateagory, startDate, endDate, gender, age, timeUnit, keywordName, productName));
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
            cateagory = "";  //��ǰ ����
            switch (comboBoxSearch.Text)
            {
                //case "����ũž": search = "\"name\":\"����ũž\",\"param\":[\"50000089\"]"; break;
                //case "��Ʈ��": search = "\"name\":\"��Ʈ��\",\"param\":[\"50000151\"]"; break;
                //case "�����": search = "\"name\":\"�����\",\"param\":[\"50000153\"]"; break;
                //case "Ű����/���콺": search = "\"name\":\"Ű����/���콺\",\"param\":[\"50002927\"]"; break;
                case "����ũž": cateagory = "50000089"; keywordName = "����ũž"; break;
                case "��Ʈ��": cateagory = "50000151"; keywordName = "��Ʈ��"; break;
                case "�����": cateagory = "50000153"; keywordName = "�����"; break;
                case "Ű����/���콺": cateagory = "50002927"; keywordName = "Ű����/���콺"; break;
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

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(cateagory, startDate, endDate, gender, age, timeUnit, keywordName, productName));
            chart1.Series.Clear();
            CreateChart(chart1, $"{comboBoxSearch.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����", result);

        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            timeUnit = "week"; //�ֺ��� ����

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(cateagory, startDate, endDate, gender, age, timeUnit, keywordName, productName));
            chart1.Series.Clear();
            CreateChart(chart1, $"{comboBoxSearch.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����", result);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            productName = txtSearch.Text;
        }
    }
}