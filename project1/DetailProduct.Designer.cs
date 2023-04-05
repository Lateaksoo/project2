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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdateDetail = new System.Windows.Forms.Button();
            this.txtimageRoot = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetailImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDetailImage
            // 
            this.pbDetailImage.Location = new System.Drawing.Point(12, 12);
            this.pbDetailImage.Name = "pbDetailImage";
            this.pbDetailImage.Size = new System.Drawing.Size(227, 216);
            this.pbDetailImage.TabIndex = 24;
            this.pbDetailImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "카테고리";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "이미지 경로";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "재고";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(345, 121);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 23);
            this.txtStock.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "가격";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(345, 71);
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
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.Location = new System.Drawing.Point(370, 406);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDetail.TabIndex = 20;
            this.btnUpdateDetail.Text = "수정";
            this.btnUpdateDetail.UseVisualStyleBackColor = true;
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // txtimageRoot
            // 
            this.txtimageRoot.Location = new System.Drawing.Point(345, 165);
            this.txtimageRoot.Name = "txtimageRoot";
            this.txtimageRoot.Size = new System.Drawing.Size(100, 23);
            this.txtimageRoot.TabIndex = 25;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(345, 205);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 23);
            this.txtCategory.TabIndex = 26;
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
            // DetailProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtimageRoot);
            this.Controls.Add(this.pbDetailImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdateDetail);
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
        private Label label4;
        private Label label3;
        private TextBox txtStock;
        private Label label2;
        private TextBox txtPrice;
        private Label label1;
        private TextBox txtName;
        private Button btnUpdateDetail;
        private TextBox txtimageRoot;
        private TextBox txtCategory;
        private TextBox txtDetail;
    }
}