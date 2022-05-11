namespace ParkingCarProgram
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_logPrint = new System.Windows.Forms.ListBox();
            this.label_now = new System.Windows.Forms.Label();
            this.timer_now = new System.Windows.Forms.Timer(this.components);
            this.dataGridView_parkingManager = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_parkingSpot = new System.Windows.Forms.TextBox();
            this.textBox_carNumber = new System.Windows.Forms.TextBox();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.button_parking = new System.Windows.Forms.Button();
            this.button_parkExit = new System.Windows.Forms.Button();
            this.button_find = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_spotNumber = new System.Windows.Forms.TextBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_parkExit);
            this.groupBox1.Controls.Add(this.button_parking);
            this.groupBox1.Controls.Add(this.textBox_phoneNumber);
            this.groupBox1.Controls.Add(this.textBox_driverName);
            this.groupBox1.Controls.Add(this.textBox_carNumber);
            this.groupBox1.Controls.Add(this.textBox_parkingSpot);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차/출차";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_refresh);
            this.groupBox2.Controls.Add(this.button_remove);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Controls.Add(this.textBox_spotNumber);
            this.groupBox2.Controls.Add(this.button_find);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(384, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차 공간 현황 관리";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_parkingManager);
            this.groupBox3.Location = new System.Drawing.Point(12, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주차 현황";
            // 
            // listBox_logPrint
            // 
            this.listBox_logPrint.FormattingEnabled = true;
            this.listBox_logPrint.ItemHeight = 12;
            this.listBox_logPrint.Location = new System.Drawing.Point(12, 324);
            this.listBox_logPrint.Name = "listBox_logPrint";
            this.listBox_logPrint.Size = new System.Drawing.Size(776, 112);
            this.listBox_logPrint.TabIndex = 3;
            // 
            // label_now
            // 
            this.label_now.AutoSize = true;
            this.label_now.Location = new System.Drawing.Point(16, 439);
            this.label_now.Name = "label_now";
            this.label_now.Size = new System.Drawing.Size(11, 12);
            this.label_now.TabIndex = 4;
            this.label_now.Text = "-";
            // 
            // timer_now
            // 
            this.timer_now.Enabled = true;
            this.timer_now.Interval = 1000;
            this.timer_now.Tick += new System.EventHandler(this.timer_now_Tick);
            // 
            // dataGridView_parkingManager
            // 
            this.dataGridView_parkingManager.AllowUserToAddRows = false;
            this.dataGridView_parkingManager.AllowUserToDeleteRows = false;
            this.dataGridView_parkingManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parkingManager.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_parkingManager.Name = "dataGridView_parkingManager";
            this.dataGridView_parkingManager.ReadOnly = true;
            this.dataGridView_parkingManager.RowTemplate.Height = 23;
            this.dataGridView_parkingManager.Size = new System.Drawing.Size(764, 137);
            this.dataGridView_parkingManager.TabIndex = 0;
            this.dataGridView_parkingManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_parkingManager_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "공간번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "차량번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "차주이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "전화번호";
            // 
            // textBox_parkingSpot
            // 
            this.textBox_parkingSpot.Location = new System.Drawing.Point(91, 24);
            this.textBox_parkingSpot.Name = "textBox_parkingSpot";
            this.textBox_parkingSpot.Size = new System.Drawing.Size(100, 21);
            this.textBox_parkingSpot.TabIndex = 9;
            // 
            // textBox_carNumber
            // 
            this.textBox_carNumber.Location = new System.Drawing.Point(91, 50);
            this.textBox_carNumber.Name = "textBox_carNumber";
            this.textBox_carNumber.Size = new System.Drawing.Size(100, 21);
            this.textBox_carNumber.TabIndex = 10;
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(91, 76);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(100, 21);
            this.textBox_driverName.TabIndex = 11;
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(91, 103);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(100, 21);
            this.textBox_phoneNumber.TabIndex = 12;
            // 
            // button_parking
            // 
            this.button_parking.Location = new System.Drawing.Point(251, 22);
            this.button_parking.Name = "button_parking";
            this.button_parking.Size = new System.Drawing.Size(75, 23);
            this.button_parking.TabIndex = 13;
            this.button_parking.Text = "주차";
            this.button_parking.UseVisualStyleBackColor = true;
            this.button_parking.Click += new System.EventHandler(this.button_parking_Click);
            // 
            // button_parkExit
            // 
            this.button_parkExit.Location = new System.Drawing.Point(251, 49);
            this.button_parkExit.Name = "button_parkExit";
            this.button_parkExit.Size = new System.Drawing.Size(75, 23);
            this.button_parkExit.TabIndex = 14;
            this.button_parkExit.Text = "출차";
            this.button_parkExit.UseVisualStyleBackColor = true;
            this.button_parkExit.Click += new System.EventHandler(this.button_parkExit_Click);
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(246, 23);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(118, 23);
            this.button_find.TabIndex = 15;
            this.button_find.Text = "해당 공간 조회";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(246, 50);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(118, 23);
            this.button_add.TabIndex = 16;
            this.button_add.Text = "공간 추가";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "공간번호";
            // 
            // textBox_spotNumber
            // 
            this.textBox_spotNumber.Location = new System.Drawing.Point(115, 25);
            this.textBox_spotNumber.Name = "textBox_spotNumber";
            this.textBox_spotNumber.Size = new System.Drawing.Size(100, 21);
            this.textBox_spotNumber.TabIndex = 17;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(246, 77);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(118, 23);
            this.button_remove.TabIndex = 18;
            this.button_remove.Text = "공간 삭제";
            this.button_remove.UseVisualStyleBackColor = true;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(246, 104);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(118, 23);
            this.button_refresh.TabIndex = 19;
            this.button_refresh.Text = "전체 갱신";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.label_now);
            this.Controls.Add(this.listBox_logPrint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "주차 관리 프로그램";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_parkExit;
        private System.Windows.Forms.Button button_parking;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.TextBox textBox_carNumber;
        private System.Windows.Forms.TextBox textBox_parkingSpot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_spotNumber;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_parkingManager;
        private System.Windows.Forms.ListBox listBox_logPrint;
        private System.Windows.Forms.Label label_now;
        private System.Windows.Forms.Timer timer_now;
    }
}

