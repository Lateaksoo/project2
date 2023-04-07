namespace project1
{
    partial class DetailProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbDetailImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnFindIamge = new System.Windows.Forms.Button();
            this.txtProductImage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetailImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDetailImage
            // 
            this.pbDetailImage.Location = new System.Drawing.Point(12, 23);
            this.pbDetailImage.Name = "pbDetailImage";
            this.pbDetailImage.Size = new System.Drawing.Size(227, 221);
            this.pbDetailImage.TabIndex = 24;
            this.pbDetailImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "카테고리";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "재고";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(345, 103);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 23);
            this.txtStock.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "가격";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(345, 62);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "상품명";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(345, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(370, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDetail
            // 
            this.txtDetail.HideSelection = false;
            this.txtDetail.Location = new System.Drawing.Point(12, 252);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(433, 139);
            this.txtDetail.TabIndex = 27;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(273, 406);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "편집";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(345, 144);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(100, 23);
            this.comboBoxCategory.TabIndex = 29;
            // 
            // btnFindIamge
            // 
            this.btnFindIamge.Location = new System.Drawing.Point(365, 212);
            this.btnFindIamge.Name = "btnFindIamge";
            this.btnFindIamge.Size = new System.Drawing.Size(80, 23);
            this.btnFindIamge.TabIndex = 31;
            this.btnFindIamge.Text = "사진 찾기";
            this.btnFindIamge.UseVisualStyleBackColor = true;
            this.btnFindIamge.Click += new System.EventHandler(this.btnFindIamge_Click);
            // 
            // txtProductImage
            // 
            this.txtProductImage.Location = new System.Drawing.Point(258, 183);
            this.txtProductImage.Name = "txtProductImage";
            this.txtProductImage.Size = new System.Drawing.Size(187, 23);
            this.txtProductImage.TabIndex = 30;
            // 
            // DetailProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.btnFindIamge);
            this.Controls.Add(this.txtProductImage);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.pbDetailImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Name = "DetailProduct";
            this.Text = "DetailProduct";
            this.Load += new System.EventHandler(this.DetailProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetailImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbDetailImage;
        private Label label5;
        private Label label3;
        private TextBox txtStock;
        private Label label2;
        private TextBox txtPrice;
        private Label label1;
        private TextBox txtName;
        private Button btnSave;
        private TextBox txtDetail;
        private Button btnEdit;
        private ComboBox comboBoxCategory;
        private Button btnFindIamge;
        private TextBox txtProductImage;
    }
}