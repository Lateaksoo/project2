namespace project1
{
    partial class AddManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_pwcheck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phonenum = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "전화번호 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "이메일 :";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(101, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 23);
            this.txt_id.TabIndex = 1;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(101, 68);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(100, 23);
            this.txt_pw.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "중복확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "계정추가";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_pwcheck
            // 
            this.txt_pwcheck.Location = new System.Drawing.Point(101, 96);
            this.txt_pwcheck.Name = "txt_pwcheck";
            this.txt_pwcheck.Size = new System.Drawing.Size(100, 23);
            this.txt_pwcheck.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "비밀번호확인 :";
            // 
            // txt_phonenum
            // 
            this.txt_phonenum.AccessibleDescription = "";
            this.txt_phonenum.Location = new System.Drawing.Point(101, 123);
            this.txt_phonenum.Mask = "000-9000-0000";
            this.txt_phonenum.Name = "txt_phonenum";
            this.txt_phonenum.Size = new System.Drawing.Size(100, 23);
            this.txt_phonenum.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(101, 150);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 23);
            this.txt_email.TabIndex = 6;
            // 
            // AddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 218);
            this.Controls.Add(this.txt_phonenum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pwcheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_id;
        private TextBox txt_pw;
        private Button button1;
        private Button button2;
        private TextBox txt_pwcheck;
        private Label label5;
        private MaskedTextBox txt_phonenum;
        private TextBox txt_email;
    }
}