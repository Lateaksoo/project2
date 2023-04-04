using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    [Serializable]
    internal class ProductManagerModel
    {
        private string _category;
        private string _startDate;
        private string _endDate;
        private string _age;
        private string _gender;
        private string _timeUnit;
        private string _keywordName;
        private string _productName;

        // 매개변수없는 생성자
        public ProductManagerModel() { }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public string EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string TimeUnit
        {
            get { return _timeUnit; }
            set { _timeUnit = value; }
        }

        public string KeywordName
        {
            get { return _keywordName; }
            set { _keywordName = value; }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

    }
}
