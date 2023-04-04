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
        private string _category;             //카테고리 번호
        private string _startDate;            //시작일
        private string _endDate;              //종료일
        private string _age;                  //연령
        private string _gender;               //성별
        private string _timeUnit;             //월별,주별 정렬
        private string _keywordName;          //카테고리 이름
        private string _searchProductName;    //검색 상품명

        private string _productName;          //상품명
        private int _productPrice;            //상품가격
        private int _productStock;            //상품재고
        private string _productImage;         //상품 사진 경로

        // 매개변수없는 생성자
        public ProductManagerModel() { }

        #region Product Property
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

        public string SearchProductName
        {
            get { return _searchProductName; }
            set { _searchProductName = value; }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public int ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public int ProductStock
        {
            get { return _productStock; }
            set { _productStock = value; }
        }

        public string ProductImage
        {
            get { return _productImage; }
            set { _productImage = value; }
        }

        #endregion
    }
}
