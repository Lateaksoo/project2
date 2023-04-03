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
            bool isAnyChecked = false; // 체크박스가 한 개 이상 체크되었는지 확인하는 변수
            CheckBox[] checkBoxes = { check10, check20, check30, check40, check50, check60, check70, check80 };
            age = "";
            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked) //체크된 값들을 문자열로 만들기 
                {
                    age += $"{checkBox.Text.Replace("대", "")}\",\"";
                    isAnyChecked = true;
                }
            }
            if (age.EndsWith("\",\"")) //마지막에는 \",\"를 지워줘야 한다.
            {
                age = age.Remove(age.Length - 3);
            }
            if (!isAnyChecked) // 체크박스가 한 개 이상 체크되지 않았을 경우
            {
                MessageBox.Show("연령대를 선택해주세요.");
                return; // 메소드 실행 중지
            }

            dynamic result =
            JsonConvert.DeserializeObject(naverSearch.naver(search, startDate, endDate, gender, age));
            List<double> ratios = new List<double>();
            foreach (var data in result.results[0].data)
            {
                ratios.Add((double)data.ratio);
            }

            chart1.Series.Clear();
            Series series = chart1.Series.Add($"{comboBoxSearch.Text}\n {comboBoxSex.Text}성\n {age}대\n, 검색 비율");
            series.ChartType = SeriesChartType.Column;
            for (int i = 0; i < ratios.Count; i++)
            {
                series.Points.AddXY(i + 1, ratios[i]);
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e) 
        {
            startDate = "";  //시작일을 초기화해줌
            startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = "";  //종료일을 초기화해줌
            endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = ""; //성별 고르기
            switch (comboBoxSex.Text)
            {
                case "남": gender = "m"; break;
                case "여": gender = "f"; break;
            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            search = "";  //제품 고르기
            switch (comboBoxSearch.Text)
            {
                case "데스크탑": search = "\"name\":\"데스크탑\",\"param\":[\"50000089\"]"; break;
                case "노트북": search = "\"name\":\"노트북\",\"param\":[\"50000151\"]"; break;
                case "모니터": search = "\"name\":\"모니터\",\"param\":[\"50000153\"]"; break;
                case "키보드/마우스": search = "\"name\":\"키보드/마우스\",\"param\":[\"50002927\"]"; break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //기본으로 선택되어 있는 값
            comboBoxSearch.SelectedIndex = 0;
            comboBoxSex.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddMonths(-6);
            dtpEndDate.Value = DateTime.Now;
        }
    }
}