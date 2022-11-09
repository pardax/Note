namespace Link_2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDown = new System.Windows.Forms.RadioButton();
            this.rbtnUp = new System.Windows.Forms.RadioButton();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(90, 22);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(368, 25);
            this.txtWord.TabIndex = 0;
            this.txtWord.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(476, 17);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "다음 찾기";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(476, 53);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "취 소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "찾을 내용";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDown);
            this.groupBox1.Controls.Add(this.rbtnUp);
            this.groupBox1.Location = new System.Drawing.Point(175, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "방향";
            // 
            // rbtnDown
            // 
            this.rbtnDown.AutoSize = true;
            this.rbtnDown.Checked = true;
            this.rbtnDown.Location = new System.Drawing.Point(159, 24);
            this.rbtnDown.Name = "rbtnDown";
            this.rbtnDown.Size = new System.Drawing.Size(73, 19);
            this.rbtnDown.TabIndex = 1;
            this.rbtnDown.TabStop = true;
            this.rbtnDown.Text = "아래쪽";
            this.rbtnDown.UseVisualStyleBackColor = true;
            // 
            // rbtnUp
            // 
            this.rbtnUp.AutoSize = true;
            this.rbtnUp.Location = new System.Drawing.Point(59, 24);
            this.rbtnUp.Name = "rbtnUp";
            this.rbtnUp.Size = new System.Drawing.Size(58, 19);
            this.rbtnUp.TabIndex = 0;
            this.rbtnUp.Text = "위쪽";
            this.rbtnUp.UseVisualStyleBackColor = true;
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(30, 88);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(125, 19);
            this.chkBox.TabIndex = 5;
            this.chkBox.Text = "대/소문자구분";
            this.chkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 149);
            this.Controls.Add(this.chkBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "찾기";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtWord;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.CheckBox chkBox;
        public System.Windows.Forms.RadioButton rbtnDown;
        public System.Windows.Forms.RadioButton rbtnUp;
    }
}

