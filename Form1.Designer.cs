
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.fisrt_combo = new System.Windows.Forms.ComboBox();
            this.second_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first_input = new System.Windows.Forms.TextBox();
            this.first_text = new System.Windows.Forms.Label();
            this.second_text = new System.Windows.Forms.Label();
            this.second_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "변환하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fisrt_combo
            // 
            this.fisrt_combo.FormattingEnabled = true;
            this.fisrt_combo.Location = new System.Drawing.Point(52, 59);
            this.fisrt_combo.Name = "fisrt_combo";
            this.fisrt_combo.Size = new System.Drawing.Size(151, 28);
            this.fisrt_combo.TabIndex = 1;
            this.fisrt_combo.SelectedIndexChanged += new System.EventHandler(this.fisrt_combo_SelectedIndexChanged);
            // 
            // second_combo
            // 
            this.second_combo.FormattingEnabled = true;
            this.second_combo.Location = new System.Drawing.Point(278, 58);
            this.second_combo.Name = "second_combo";
            this.second_combo.Size = new System.Drawing.Size(151, 28);
            this.second_combo.TabIndex = 2;
            this.second_combo.SelectedIndexChanged += new System.EventHandler(this.second_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "에서";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "로 변환";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "거리 단위 환산 프로그램";
            // 
            // first_input
            // 
            this.first_input.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.first_input.Location = new System.Drawing.Point(52, 112);
            this.first_input.Name = "first_input";
            this.first_input.Size = new System.Drawing.Size(262, 32);
            this.first_input.TabIndex = 6;
            this.first_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // first_text
            // 
            this.first_text.AutoSize = true;
            this.first_text.Location = new System.Drawing.Point(320, 124);
            this.first_text.Name = "first_text";
            this.first_text.Size = new System.Drawing.Size(22, 20);
            this.first_text.TabIndex = 8;
            this.first_text.Text = "m";
            // 
            // second_text
            // 
            this.second_text.AutoSize = true;
            this.second_text.Location = new System.Drawing.Point(320, 174);
            this.second_text.Name = "second_text";
            this.second_text.Size = new System.Drawing.Size(22, 20);
            this.second_text.TabIndex = 9;
            this.second_text.Text = "m";
            // 
            // second_result
            // 
            this.second_result.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.second_result.Location = new System.Drawing.Point(52, 159);
            this.second_result.Name = "second_result";
            this.second_result.Size = new System.Drawing.Size(262, 32);
            this.second_result.TabIndex = 10;
            this.second_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 223);
            this.Controls.Add(this.second_result);
            this.Controls.Add(this.second_text);
            this.Controls.Add(this.first_text);
            this.Controls.Add(this.first_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.second_combo);
            this.Controls.Add(this.fisrt_combo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "거리 단위 환산 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fisrt_combo;
        private System.Windows.Forms.ComboBox second_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label first_text;
        private System.Windows.Forms.Label second_text;
        private System.Windows.Forms.TextBox first_input;
        private System.Windows.Forms.TextBox second_result;
    }
}

