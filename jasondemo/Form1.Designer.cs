namespace jasondemo
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
            this.btn_GO = new System.Windows.Forms.Button();
            this.rtbInput1 = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.rtbInput2 = new System.Windows.Forms.RichTextBox();
            this.rtbInput3 = new System.Windows.Forms.RichTextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.HP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_GO
            // 
            this.btn_GO.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GO.Location = new System.Drawing.Point(370, 29);
            this.btn_GO.Name = "btn_GO";
            this.btn_GO.Size = new System.Drawing.Size(84, 89);
            this.btn_GO.TabIndex = 0;
            this.btn_GO.Text = "go";
            this.btn_GO.UseVisualStyleBackColor = true;
            this.btn_GO.Click += new System.EventHandler(this.Btn_GO_Click);
            // 
            // rtbInput1
            // 
            this.rtbInput1.Location = new System.Drawing.Point(145, 29);
            this.rtbInput1.Name = "rtbInput1";
            this.rtbInput1.Size = new System.Drawing.Size(100, 37);
            this.rtbInput1.TabIndex = 1;
            this.rtbInput1.Text = "";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(557, 29);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(100, 109);
            this.rtbOutput.TabIndex = 2;
            this.rtbOutput.Text = "";
            // 
            // rtbInput2
            // 
            this.rtbInput2.Location = new System.Drawing.Point(145, 117);
            this.rtbInput2.Name = "rtbInput2";
            this.rtbInput2.Size = new System.Drawing.Size(100, 37);
            this.rtbInput2.TabIndex = 3;
            this.rtbInput2.Text = "";
            // 
            // rtbInput3
            // 
            this.rtbInput3.Location = new System.Drawing.Point(145, 214);
            this.rtbInput3.Name = "rtbInput3";
            this.rtbInput3.Size = new System.Drawing.Size(100, 37);
            this.rtbInput3.TabIndex = 4;
            this.rtbInput3.Text = "";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_back.Location = new System.Drawing.Point(370, 163);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 88);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // HP
            // 
            this.HP.AutoSize = true;
            this.HP.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HP.Location = new System.Drawing.Point(41, 29);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(32, 19);
            this.HP.TabIndex = 6;
            this.HP.Text = "HP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(41, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "MP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(41, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "EXP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.rtbInput3);
            this.Controls.Add(this.rtbInput2);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput1);
            this.Controls.Add(this.btn_GO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GO;
        private System.Windows.Forms.RichTextBox rtbInput1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.RichTextBox rtbInput2;
        private System.Windows.Forms.RichTextBox rtbInput3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

