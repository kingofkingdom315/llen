namespace Ilen
{
    partial class AddForm
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
            this.post_comb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mat_type_comb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_pick = new System.Windows.Forms.DateTimePicker();
            this.count_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.labеl6 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // post_comb
            // 
            this.post_comb.FormattingEnabled = true;
            this.post_comb.Location = new System.Drawing.Point(16, 31);
            this.post_comb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.post_comb.Name = "post_comb";
            this.post_comb.Size = new System.Drawing.Size(160, 24);
            this.post_comb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поставщик";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(243, 185);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(100, 28);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(45, 185);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 28);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип материала";
            // 
            // mat_type_comb
            // 
            this.mat_type_comb.FormattingEnabled = true;
            this.mat_type_comb.Location = new System.Drawing.Point(201, 31);
            this.mat_type_comb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mat_type_comb.Name = "mat_type_comb";
            this.mat_type_comb.Size = new System.Drawing.Size(160, 24);
            this.mat_type_comb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Колличество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата";
            // 
            // date_pick
            // 
            this.date_pick.Location = new System.Drawing.Point(20, 126);
            this.date_pick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_pick.Name = "date_pick";
            this.date_pick.Size = new System.Drawing.Size(160, 22);
            this.date_pick.TabIndex = 10;
            // 
            // count_txt
            // 
            this.count_txt.Location = new System.Drawing.Point(16, 80);
            this.count_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.count_txt.Name = "count_txt";
            this.count_txt.Size = new System.Drawing.Size(160, 22);
            this.count_txt.TabIndex = 11;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(201, 80);
            this.price_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(160, 22);
            this.price_txt.TabIndex = 12;
            // 
            // labеl6
            // 
            this.labеl6.AutoSize = true;
            this.labеl6.Location = new System.Drawing.Point(240, 106);
            this.labеl6.Name = "labеl6";
            this.labеl6.Size = new System.Drawing.Size(72, 17);
            this.labеl6.TabIndex = 13;
            this.labеl6.Text = "Название";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(201, 126);
            this.name_text.Margin = new System.Windows.Forms.Padding(4);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(160, 22);
            this.name_text.TabIndex = 14;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 226);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.labеl6);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.count_txt);
            this.Controls.Add(this.date_pick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mat_type_comb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.post_comb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox post_comb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mat_type_comb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date_pick;
        private System.Windows.Forms.TextBox count_txt;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label labеl6;
        private System.Windows.Forms.TextBox name_text;
    }
}