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
       
        public string search;
        public string startDate;
        public string endDate;
        public string age;
        public string gender;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isAnyChecked = false; // üũ�ڽ��� �� �� �̻� üũ�Ǿ����� Ȯ���ϴ� ����
            CheckBox[] checkBoxes = { check10, check20, check30, check40, check50, check60, check70, check80 };
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

            dynamic result =
            JsonConvert.DeserializeObject(naverSearch.naver(search, startDate, endDate, gender, age));
            List<double> ratios = new List<double>();
            foreach (var data in result.results[0].data)
            {
                ratios.Add((double)data.ratio);
            }

            chart1.Series.Clear();
            Series series = chart1.Series.Add($"{comboBoxSearch.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����");
            series.ChartType = SeriesChartType.Column;
            for (int i = 0; i < ratios.Count; i++)
            {
                series.Points.AddXY(i + 1, ratios[i]);
            }
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
            search = "";  //��ǰ ����
            switch (comboBoxSearch.Text)
            {
                case "����ũž": search = "\"name\":\"����ũž\",\"param\":[\"50000089\"]"; break;
                case "��Ʈ��": search = "\"name\":\"��Ʈ��\",\"param\":[\"50000151\"]"; break;
                case "�����": search = "\"name\":\"�����\",\"param\":[\"50000153\"]"; break;
                case "Ű����/���콺": search = "\"name\":\"Ű����/���콺\",\"param\":[\"50002927\"]"; break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //�⺻���� ���õǾ� �ִ� ��
            comboBoxSearch.SelectedIndex = 0;
            comboBoxSex.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddMonths(-6);
            dtpEndDate.Value = DateTime.Now;
        }
    }
}