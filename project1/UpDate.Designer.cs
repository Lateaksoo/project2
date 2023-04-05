namespace project1
{
    partial class UpDate
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
            this.txt_phonenum = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pwcheck = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_phonenum
            // 
            this.txt_phonenum.AccessibleDescription = "";
            this.txt_phonenum.Location = new System.Drawing.Point(102, 96);
            this.txt_phonenum.Mask = "000-9000-0000";
            this.txt_phonenum.Name = "txt_phonenum";
            this.txt_phonenum.Size = new System.Drawing.Size(100, 23);
            this.txt_phonenum.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "비밀번호확인 :";
            // 
            // txt_pwcheck
            // 
            this.txt_pwcheck.Location = new System.Drawing.Point(102, 69);
            this.txt_pwcheck.Name = "txt_pwcheck";
            this.txt_pwcheck.PasswordChar = '*';
            this.txt_pwcheck.Size = new System.Drawing.Size(100, 23);
            this.txt_pwcheck.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "계정수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(102, 123);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 23);
            this.txt_email.TabIndex = 20;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(102, 41);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(100, 23);
            this.txt_pw.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "이메일 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "전화번호 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "비밀번호 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "아이디 :";
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Location = new System.Drawing.Point(105, 16);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(39, 15);
            this.lbl_uname.TabIndex = 26;
            this.lbl_uname.Text = "label6";
            // 
            // UpDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 198);
            this.Controls.Add(this.lbl_uname);
            this.Controls.Add(this.txt_phonenum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pwcheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpDate";
            this.Text = "UpDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txt_phonenum;
        private Label label5;
        private TextBox txt_pwcheck;
        private Button button2;
        private TextBox txt_email;
        private TextBox txt_pw;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbl_uname;
    }
}