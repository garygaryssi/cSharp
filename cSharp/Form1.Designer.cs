namespace cSharp
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.calResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sum_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.sub_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(224, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.div_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "*";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.mul_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(26, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 48);
            this.button6.TabIndex = 8;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(92, 80);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 48);
            this.button7.TabIndex = 9;
            this.button7.Text = "8\r\n";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(158, 80);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 48);
            this.button8.TabIndex = 10;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(26, 134);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 48);
            this.button9.TabIndex = 11;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(92, 134);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 48);
            this.button10.TabIndex = 12;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(158, 134);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 48);
            this.button11.TabIndex = 13;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(26, 188);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 48);
            this.button12.TabIndex = 14;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(92, 188);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 48);
            this.button13.TabIndex = 15;
            this.button13.Text = "2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(158, 188);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(60, 48);
            this.button14.TabIndex = 16;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(26, 242);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(126, 48);
            this.button15.TabIndex = 17;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(290, 134);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(60, 48);
            this.button16.TabIndex = 19;
            this.button16.Text = "C";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.clear_btn);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(290, 188);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 102);
            this.button17.TabIndex = 20;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.cal_btn);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(290, 80);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(60, 48);
            this.button18.TabIndex = 21;
            this.button18.Text = "<-";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.remove_btn);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(158, 242);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 48);
            this.button19.TabIndex = 22;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // calResult
            // 
            this.calResult.Location = new System.Drawing.Point(26, 43);
            this.calResult.Name = "calResult";
            this.calResult.Size = new System.Drawing.Size(324, 21);
            this.calResult.TabIndex = 24;
            this.calResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.calResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.test_key);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 329);
            this.Controls.Add(this.calResult);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox calResult;
    }
}

