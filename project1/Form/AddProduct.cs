using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace project1
{
    public partial class AddProduct : Form
    {
        private ProductManagerModel productManagerModel;
        private Manager manager;

        private Form1 form1;

        public AddProduct(Form1 form1)
        {
            InitializeComponent();
            productManagerModel = new ProductManagerModel();
            manager = new Manager(productManagerModel);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.form1 = form1;
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {
            DataTable categoryTable = manager.GetCategoryComboBox();
            // 콤보박스에 카테고리를 추가함
            foreach (DataRow row in categoryTable.Rows)
            {
                comboBoxCategory.Items.Add(row["keyword_name"]);
            }

            //기본으로 선택되어 있는 값
            comboBoxCategory.SelectedIndex = 0;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "") MessageBox.Show("상품명을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtProductStock.Text == "") MessageBox.Show("재고량을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtProductPrice.Text == "") MessageBox.Show("가격을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBoxCategory.Text == "") MessageBox.Show("카테고리를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string sourceImagePath = txtProductImage.Text; // txtProductImage 텍스트 상자에 입력된 이미지 경로
                string targetFileName = Path.GetFileName(sourceImagePath); // 파일 이름 추출
                string targetDirectory = Path.GetDirectoryName(Application.ExecutablePath); // 현재 실행 파일이 있는 디렉토리 경로

                // 경로에서 상위 디렉토리를 추출할 횟수
                int count = 3;

                // 경로에서 필요한 부분만 추출
                for (int i = 0; i < count; i++)
                {
                    targetDirectory = Path.GetDirectoryName(targetDirectory);
                }

                // 추가된 상품의 이미지 경로를 프로그램 내의 상대 경로로 변경
                
                
                string targetImagePath = targetDirectory + "/" + "Image/" + targetFileName;
                

                //string targetImagePath = Path.Combine(targetDirectory, targetFileName); // 파일 경로 생성
                                                                                        
                if (File.Exists(targetImagePath)) // 이미 파일이 존재하는지 확인
                {
                    // 덮어쓰기 여부를 물어봄
                    DialogResult result = MessageBox.Show("같은 이름의 파일이 이미 존재합니다. 덮어쓰시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // 이미지 파일 삭제
                            File.Delete(targetImagePath);

                            // 이미지 파일 복사
                            File.Copy(sourceImagePath, targetImagePath, true);
                        }
                        catch (Exception ex)
                        {
                            txtProductImage.Text = "";  //이미지 파일 저장에 실패하면 잘못된 경로로 판단하고 입력값을 저장하지 않는다.
                        }
                    }
                    else if (result == DialogResult.No) return;  // 파일을 저장하지 않고 재입력을 요구
                }
                else
                {
                    try
                    {
                        // 이미지 파일 복사
                        File.Copy(sourceImagePath, targetImagePath, true);
                    }
                    catch (Exception ex)
                    {
                        txtProductImage.Text = "";  //이미지 파일 저장에 실패하면 잘못된 경로로 판단하고 입력값을 저장하지 않는다.
                    }
                }
                txtProductImage.Text = targetImagePath;

                //데이터베이스에 파일 저장
                manager.AddProduct(txtProductName.Text,
                                   txtProductPrice.Text,
                                   txtProductStock.Text,
                                   txtProductImage.Text,
                                   comboBoxCategory.Text,
                                   txtDetail.Text);

                this.Close(); 
                form1.ProductDataViewLoad(); //새로고침
            }
        }

        private void txtProductImage_Leave(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Bitmap.FromFile($@"{txtProductImage.Text}");
            }
            catch (Exception ex)
            {
                txtProductImage.Text = "";
                return;
            }
        }
    }
}
