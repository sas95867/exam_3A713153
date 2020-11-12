namespace exam_3A713153
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lab1 = new System.Windows.Forms.Label();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.rtbout = new System.Windows.Forms.RichTextBox();
            this.lab2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(443, 99);
            this.tbInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(342, 23);
            this.tbInput.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Yellow;
            this.btnGo.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGo.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnGo.Location = new System.Drawing.Point(52, 37);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(261, 151);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "點我確定數字";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab1.Location = new System.Drawing.Point(448, 64);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(105, 24);
            this.lab1.TabIndex = 4;
            this.lab1.Text = "輸入數字吧";
            // 
            // pic2
            // 
            this.pic2.Image = global::exam_3A713153.Properties.Resources._009;
            this.pic2.Location = new System.Drawing.Point(52, 250);
            this.pic2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(261, 342);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(443, 250);
            this.pic1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(338, 342);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
            // 
            // rtbout
            // 
            this.rtbout.Location = new System.Drawing.Point(443, 159);
            this.rtbout.Name = "rtbout";
            this.rtbout.Size = new System.Drawing.Size(246, 29);
            this.rtbout.TabIndex = 5;
            this.rtbout.Text = "";
            this.rtbout.TextChanged += new System.EventHandler(this.rtbout_TextChanged);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab2.Location = new System.Drawing.Point(452, 135);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(74, 21);
            this.lab2.TabIndex = 6;
            this.lab2.Text = "猜的次數";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(900, 683);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.rtbout);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.tbInput);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "猜猜數字並獲得與下方相同的圖片";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.RichTextBox rtbout;
        private System.Windows.Forms.Label lab2;
    }
}

