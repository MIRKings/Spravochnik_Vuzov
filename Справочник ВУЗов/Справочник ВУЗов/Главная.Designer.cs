namespace Справочник_ВУЗов
{
    partial class Главная
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Главная));
            this.VUZ = new System.Windows.Forms.Button();
            this.CITY = new System.Windows.Forms.Button();
            this.Filials = new System.Windows.Forms.Button();
            this.ADMIN = new System.Windows.Forms.Button();
            this.EXITLABLE = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // VUZ
            // 
            resources.ApplyResources(this.VUZ, "VUZ");
            this.VUZ.Name = "VUZ";
            this.VUZ.UseVisualStyleBackColor = true;
            this.VUZ.Click += new System.EventHandler(this.VUZ_Click);
            // 
            // CITY
            // 
            resources.ApplyResources(this.CITY, "CITY");
            this.CITY.Name = "CITY";
            this.CITY.UseVisualStyleBackColor = true;
            this.CITY.Click += new System.EventHandler(this.CITY_Click);
            // 
            // Filials
            // 
            resources.ApplyResources(this.Filials, "Filials");
            this.Filials.Name = "Filials";
            this.Filials.UseVisualStyleBackColor = true;
            this.Filials.Click += new System.EventHandler(this.Filials_Click);
            // 
            // ADMIN
            // 
            resources.ApplyResources(this.ADMIN, "ADMIN");
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.UseVisualStyleBackColor = true;
            this.ADMIN.Click += new System.EventHandler(this.ADMIN_Click);
            // 
            // EXITLABLE
            // 
            resources.ApplyResources(this.EXITLABLE, "EXITLABLE");
            this.EXITLABLE.Name = "EXITLABLE";
            this.EXITLABLE.TabStop = true;
            this.EXITLABLE.Click += new System.EventHandler(this.EXITLABLE_Click);
            // 
            // Главная
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EXITLABLE);
            this.Controls.Add(this.ADMIN);
            this.Controls.Add(this.Filials);
            this.Controls.Add(this.CITY);
            this.Controls.Add(this.VUZ);
            this.Name = "Главная";
            this.Load += new System.EventHandler(this.Главная_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VUZ;
        private System.Windows.Forms.Button CITY;
        private System.Windows.Forms.Button Filials;
        private System.Windows.Forms.Button ADMIN;
        private System.Windows.Forms.LinkLabel EXITLABLE;
    }
}

