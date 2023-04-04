using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;

namespace project1
{
    public partial class Form1 : Form
    {
        NaverSearch naverSearch = new NaverSearch();

        private ManagerModel managerModel;
        private Manager manager;
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
            managerModel = new ManagerModel();
            manager = new Manager(managerModel);
            category = managerModel.Category;
            startDate = managerModel.StartDate;
            endDate = managerModel.EndDate;
            age = managerModel.Age;
            gender = managerModel.Gender;
            timeUnit = managerModel.TimeUnit;
            keywordName = managerModel.KeywordName;
            productName = managerModel.ProductName;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable categoryTable = manager.GetCategoryComboBox();

            // �޺��ڽ��� ī�װ��� �߰���
            foreach (DataRow row in categoryTable.Rows)
            {
                comboBoxCategory.Items.Add(row["keyword_name"]);
            }

            //�⺻���� ���õǾ� �ִ� ��
            comboBoxCategory.SelectedIndex = 0;
            timeUnit = "month";
            comboBoxSex.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddMonths(-6);
            dtpEndDate.Value = DateTime.Now;
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
            manager.CreateChart(chart1, $"{comboBoxCategory.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����", result);
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
            manager.CategoryListUp(comboBoxCategory.Text);
            keywordName = managerModel.KeywordName;
            category = managerModel.Category;
        }


        private void btnMonth_Click(object sender, EventArgs e)
        {
            timeUnit = "month"; //������ ����

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(category, startDate, endDate, gender, age, timeUnit, keywordName, productName));
            chart1.Series.Clear();
            manager.CreateChart(chart1, $"{comboBoxCategory.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����", result);

        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            timeUnit = "week"; //�ֺ��� ����

            dynamic result = JsonConvert.DeserializeObject(naverSearch.naver(category, startDate, endDate, gender, age, timeUnit, keywordName, productName));
            chart1.Series.Clear();
            manager.CreateChart(chart1, $"{comboBoxCategory.Text}\n {comboBoxSex.Text}��\n {age}��\n, �˻� ����", result);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            productName = txtSearch.Text;
        }

        private void btnAddCategory_Click(object sender, EventArgs e) //ī�װ� �߰�
        {
            manager.InsertCategory(txtCategory.Text, txtKeywordName.Text);
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e) //ī�װ� ����
        {
            manager.DeleteCategory(txtDeleteKeyName.Text);
        }
    }
}