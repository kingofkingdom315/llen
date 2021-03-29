namespace Ilen
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.all_mat_list = new System.Windows.Forms.ListBox();
            this.mat_off_btn = new System.Windows.Forms.Button();
            this.prod_mat_btn = new System.Windows.Forms.Button();
            this.add_off_mat_btn = new System.Windows.Forms.Button();
            this.add_prod_mat_btn = new System.Windows.Forms.Button();
            this.add_mat_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // all_mat_list
            // 
            this.all_mat_list.FormattingEnabled = true;
            this.all_mat_list.ItemHeight = 16;
            this.all_mat_list.Location = new System.Drawing.Point(16, 15);
            this.all_mat_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.all_mat_list.Name = "all_mat_list";
            this.all_mat_list.Size = new System.Drawing.Size(393, 276);
            this.all_mat_list.TabIndex = 0;
            // 
            // mat_off_btn
            // 
            this.mat_off_btn.Location = new System.Drawing.Point(16, 299);
            this.mat_off_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mat_off_btn.Name = "mat_off_btn";
            this.mat_off_btn.Size = new System.Drawing.Size(193, 49);
            this.mat_off_btn.TabIndex = 1;
            this.mat_off_btn.Text = "Списаные \r\nматериалы";
            this.mat_off_btn.UseVisualStyleBackColor = true;
            this.mat_off_btn.Click += new System.EventHandler(this.mat_off_btn_Click);
            // 
            // prod_mat_btn
            // 
            this.prod_mat_btn.Location = new System.Drawing.Point(217, 299);
            this.prod_mat_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prod_mat_btn.Name = "prod_mat_btn";
            this.prod_mat_btn.Size = new System.Drawing.Size(193, 49);
            this.prod_mat_btn.TabIndex = 2;
            this.prod_mat_btn.Text = "Материалы на \r\nпроизводстве";
            this.prod_mat_btn.UseVisualStyleBackColor = true;
            this.prod_mat_btn.Click += new System.EventHandler(this.prod_mat_btn_Click);
            // 
            // add_off_mat_btn
            // 
            this.add_off_mat_btn.Location = new System.Drawing.Point(419, 15);
            this.add_off_mat_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_off_mat_btn.Name = "add_off_mat_btn";
            this.add_off_mat_btn.Size = new System.Drawing.Size(169, 28);
            this.add_off_mat_btn.TabIndex = 3;
            this.add_off_mat_btn.Text = "Списать материал";
            this.add_off_mat_btn.UseVisualStyleBackColor = true;
            this.add_off_mat_btn.Click += new System.EventHandler(this.add_off_mat_btn_Click);
            // 
            // add_prod_mat_btn
            // 
            this.add_prod_mat_btn.Location = new System.Drawing.Point(419, 50);
            this.add_prod_mat_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_prod_mat_btn.Name = "add_prod_mat_btn";
            this.add_prod_mat_btn.Size = new System.Drawing.Size(169, 44);
            this.add_prod_mat_btn.TabIndex = 4;
            this.add_prod_mat_btn.Text = "Отправить материал \r\nна производство";
            this.add_prod_mat_btn.UseVisualStyleBackColor = true;
            this.add_prod_mat_btn.Click += new System.EventHandler(this.add_prod_mat_btn_Click);
            // 
            // add_mat_btn
            // 
            this.add_mat_btn.Location = new System.Drawing.Point(419, 102);
            this.add_mat_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_mat_btn.Name = "add_mat_btn";
            this.add_mat_btn.Size = new System.Drawing.Size(169, 28);
            this.add_mat_btn.TabIndex = 5;
            this.add_mat_btn.Text = "Добавить материал";
            this.add_mat_btn.UseVisualStyleBackColor = true;
            this.add_mat_btn.Click += new System.EventHandler(this.add_mat_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 353);
            this.Controls.Add(this.add_mat_btn);
            this.Controls.Add(this.add_prod_mat_btn);
            this.Controls.Add(this.add_off_mat_btn);
            this.Controls.Add(this.prod_mat_btn);
            this.Controls.Add(this.mat_off_btn);
            this.Controls.Add(this.all_mat_list);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Склад";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox all_mat_list;
        private System.Windows.Forms.Button mat_off_btn;
        private System.Windows.Forms.Button prod_mat_btn;
        private System.Windows.Forms.Button add_off_mat_btn;
        private System.Windows.Forms.Button add_prod_mat_btn;
        private System.Windows.Forms.Button add_mat_btn;
    }
}

