using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    [Serializable]
    internal class ManagerModel
    {
        private int _uid;  // 고유 uid 값 ( 1 이상의 정수값 ) 중복허용 안함
        private string _name;   // 이름.  *필수*
        private string _phoneNum;  // 전화번호 *필수*
        private string _password;      // 메모
        private string _email;
        private DateTime _regDate;    // 등록일  (생성일시)


        private string _category;
        private string _startDate;
        private string _endDate;
        private string _age;
        private string _gender;
        private string _timeUnit;
        private string _keywordName;
        private string _productName;
        // ↓ 필요한 생성자, 메소드, 속성등의 멤버를 작성하여 구현해보세요
        // TODO


        // 매개변수없는 생성자
        public ManagerModel() => _regDate = DateTime.Now;
        
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


        public int Uid
        {
            get => _uid;
            set => _uid = value;
        }
        public string Name
        {
            get => _name; set => _name = value;
        }

        public string PhoneNum
        {
            get => _phoneNum; set => _phoneNum = value;
        }
        public string PassWord
        {
            get => _password; set => _password = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public DateTime RegDate
        {
            get => _regDate; set => _regDate = value;
        }

        public override string? ToString()
        {
            return $"{Uid,3}|{Name,8}|{PhoneNum,13}|{PassWord,10}|{RegDate:yyyy-MM-dd hh:mm:ss}";
        }
    }
}
