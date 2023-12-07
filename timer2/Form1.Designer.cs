namespace timer2
{
    partial class Timer
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
            this.Start_Stop_Button = new System.Windows.Forms.Button();
            this.ReSet_Button = new System.Windows.Forms.Button();
            this.Set_Button = new System.Windows.Forms.Button();
            this.Hour_TextBox = new System.Windows.Forms.TextBox();
            this.Minute_TextBox = new System.Windows.Forms.TextBox();
            this.Sec_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_Stop_Button
            // 
            this.Start_Stop_Button.Location = new System.Drawing.Point(100, 302);
            this.Start_Stop_Button.Name = "Start_Stop_Button";
            this.Start_Stop_Button.Size = new System.Drawing.Size(141, 51);
            this.Start_Stop_Button.TabIndex = 0;
            this.Start_Stop_Button.Text = "Start";
            this.Start_Stop_Button.UseVisualStyleBackColor = true;
            // 
            // ReSet_Button
            // 
            this.ReSet_Button.Location = new System.Drawing.Point(330, 302);
            this.ReSet_Button.Name = "ReSet_Button";
            this.ReSet_Button.Size = new System.Drawing.Size(134, 51);
            this.ReSet_Button.TabIndex = 1;
            this.ReSet_Button.Text = "ReSet";
            this.ReSet_Button.UseVisualStyleBackColor = true;
            // 
            // Set_Button
            // 
            this.Set_Button.Location = new System.Drawing.Point(553, 302);
            this.Set_Button.Name = "Set_Button";
            this.Set_Button.Size = new System.Drawing.Size(119, 51);
            this.Set_Button.TabIndex = 2;
            this.Set_Button.Text = "Set";
            this.Set_Button.UseVisualStyleBackColor = true;
            // 
            // Hour_TextBox
            // 
            this.Hour_TextBox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Hour_TextBox.Location = new System.Drawing.Point(101, 168);
            this.Hour_TextBox.Name = "Hour_TextBox";
            this.Hour_TextBox.Size = new System.Drawing.Size(141, 42);
            this.Hour_TextBox.TabIndex = 3;
            this.Hour_TextBox.Text = "0";
            this.Hour_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Minute_TextBox
            // 
            this.Minute_TextBox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minute_TextBox.Location = new System.Drawing.Point(331, 168);
            this.Minute_TextBox.Name = "Minute_TextBox";
            this.Minute_TextBox.Size = new System.Drawing.Size(134, 42);
            this.Minute_TextBox.TabIndex = 4;
            this.Minute_TextBox.Text = "0";
            this.Minute_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sec_TextBox
            // 
            this.Sec_TextBox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Sec_TextBox.Location = new System.Drawing.Point(554, 168);
            this.Sec_TextBox.Name = "Sec_TextBox";
            this.Sec_TextBox.Size = new System.Drawing.Size(119, 42);
            this.Sec_TextBox.TabIndex = 5;
            this.Sec_TextBox.Text = "0";
            this.Sec_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(283, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(507, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "시간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "분";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "초";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sec_TextBox);
            this.Controls.Add(this.Minute_TextBox);
            this.Controls.Add(this.Hour_TextBox);
            this.Controls.Add(this.Set_Button);
            this.Controls.Add(this.ReSet_Button);
            this.Controls.Add(this.Start_Stop_Button);
            this.Name = "Timer";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Stop_Button;
        private System.Windows.Forms.Button ReSet_Button;
        private System.Windows.Forms.Button Set_Button;
        private System.Windows.Forms.TextBox Hour_TextBox;
        private System.Windows.Forms.TextBox Minute_TextBox;
        private System.Windows.Forms.TextBox Sec_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

