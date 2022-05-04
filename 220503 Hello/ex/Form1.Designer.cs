namespace ex
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
            this.button1 = new System.Windows.Forms.Button();
            this.textbox_num1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_gawi = new System.Windows.Forms.Button();
            this.button_bawi = new System.Windows.Forms.Button();
            this.button_bo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label_num3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "문제 맞추기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_num1
            // 
            this.textbox_num1.Location = new System.Drawing.Point(153, 79);
            this.textbox_num1.Name = "textbox_num1";
            this.textbox_num1.Size = new System.Drawing.Size(100, 21);
            this.textbox_num1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "1번 문제";
            // 
            // button_gawi
            // 
            this.button_gawi.Location = new System.Drawing.Point(51, 177);
            this.button_gawi.Name = "button_gawi";
            this.button_gawi.Size = new System.Drawing.Size(90, 62);
            this.button_gawi.TabIndex = 3;
            this.button_gawi.Text = "가 위";
            this.button_gawi.UseVisualStyleBackColor = true;
            this.button_gawi.Click += new System.EventHandler(this.button_gawi_Click);
            // 
            // button_bawi
            // 
            this.button_bawi.Location = new System.Drawing.Point(147, 177);
            this.button_bawi.Name = "button_bawi";
            this.button_bawi.Size = new System.Drawing.Size(90, 62);
            this.button_bawi.TabIndex = 4;
            this.button_bawi.Text = "바 위";
            this.button_bawi.UseVisualStyleBackColor = true;
            this.button_bawi.Click += new System.EventHandler(this.button_bawi_Click);
            // 
            // button_bo
            // 
            this.button_bo.Location = new System.Drawing.Point(243, 177);
            this.button_bo.Name = "button_bo";
            this.button_bo.Size = new System.Drawing.Size(90, 62);
            this.button_bo.TabIndex = 5;
            this.button_bo.Text = "보";
            this.button_bo.UseVisualStyleBackColor = true;
            this.button_bo.Click += new System.EventHandler(this.button_bo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(45, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "2번 문제";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(47, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "3번 문제";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "랜덤 문장 출력";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_num3
            // 
            this.label_num3.AutoSize = true;
            this.label_num3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_num3.Location = new System.Drawing.Point(201, 318);
            this.label_num3.Name = "label_num3";
            this.label_num3.Size = new System.Drawing.Size(23, 24);
            this.label_num3.TabIndex = 9;
            this.label_num3.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.label_num3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_bo);
            this.Controls.Add(this.button_bawi);
            this.Controls.Add(this.button_gawi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_num1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox_num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_gawi;
        private System.Windows.Forms.Button button_bawi;
        private System.Windows.Forms.Button button_bo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_num3;
    }
}

