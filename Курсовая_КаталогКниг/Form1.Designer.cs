namespace Курсовая_КаталогКниг
{
    partial class Greeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Greeting));
            this.lbWelcome = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butView = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.Color.White;
            this.lbWelcome.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(34, 41);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(487, 33);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Добро пожаловать в наш каталог книг!";
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.Location = new System.Drawing.Point(127, 115);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(283, 81);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // butView
            // 
            this.butView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butView.Location = new System.Drawing.Point(127, 223);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(283, 81);
            this.butView.TabIndex = 2;
            this.butView.Text = "Просмотр/Удаление/Редактирование";
            this.butView.UseVisualStyleBackColor = true;
            this.butView.Click += new System.EventHandler(this.button2_Click);
            // 
            // butSearch
            // 
            this.butSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.Location = new System.Drawing.Point(127, 345);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(283, 81);
            this.butSearch.TabIndex = 3;
            this.butSearch.Text = "Поиск";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(424, 478);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(109, 39);
            this.butExit.TabIndex = 6;
            this.butExit.Text = "Выход";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая_КаталогКниг.Properties.Resources.luxa_org_bordered_Alamak_Lovejoy_08022015c;
            this.ClientSize = new System.Drawing.Size(560, 546);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butView);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.lbWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Greeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог книг";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butView;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butExit;
    }
}

